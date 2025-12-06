using System.Reflection;

using Microsoft.Win32;

namespace P031_SysInfoUpdate;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoUpdate());
    }
}

internal class SysInfoUpdate : Form
{
    private readonly Dictionary<string, string> _properties = [];
    private int _width;
    private int _height;

    public SysInfoUpdate()
    {
        Text = "System Information: Update";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        AutoScroll = true;

        SystemEvents.UserPreferenceChanged += OnUserPreferenceChanged;
        SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChanged;

        LoadSystemInformation();
        UpdateSystemInformation();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var brush = SystemBrushes.WindowText;
        var row = 0;
        var position = AutoScrollPosition;

        foreach (var kvp in _properties)
        {
            e.Graphics.DrawString(kvp.Key, Font, brush,
                position.X, position.Y + row * _height);
            e.Graphics.DrawString(kvp.Value, Font, brush,
                position.X + _width, position.Y + row * _height);
            row++;
        }
    }

    private void LoadSystemInformation()
    {
        var type = typeof(SystemInformation);
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static);

        foreach (var property in properties.OrderBy(p => p.Name))
        {
            _properties.Add(property.Name, property.GetValue(null)?.ToString() ?? string.Empty);
        }
    }

    private void UpdateSystemInformation()
    {
        using var graphics = CreateGraphics();
        var spaceSize = graphics.MeasureString(" ", Font);
        var maxLabelWidth = _properties.Max(x => graphics.MeasureString(x.Key, Font).Width);
        var maxValueWidth = _properties.Max(x => graphics.MeasureString(x.Value, Font).Width);

        _height = Font.Height;
        _width = (int)Math.Ceiling(spaceSize.Width + maxLabelWidth);

        AutoScrollMinSize = new Size(
            (int)Math.Ceiling(_width + maxValueWidth),
            (int)Math.Ceiling((double)_height * _properties.Count)
        );
    }

    private void OnDisplaySettingsChanged(object? sender, EventArgs e)
    {
        UpdateSystemInformation();
        Invalidate();
    }

    private void OnUserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
    {
        UpdateSystemInformation();
        Invalidate();
    }
}
