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

public class SysInfoUpdate : Form
{
    protected readonly List<string> _labels = [];
    protected readonly List<string> _values = [];
    protected int _width;
    protected int _height;

    public int Count => _labels.Count;

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
        var position = AutoScrollPosition;

        for (int i = 0; i < Count; i++)
        {
            e.Graphics.DrawString(_labels[i], Font, brush,
                position.X, position.Y + i * _height);
            e.Graphics.DrawString(_values[i], Font, brush,
                position.X + _width, position.Y + i * _height);
        }
    }

    private void LoadSystemInformation()
    {
        var type = typeof(SystemInformation);
        var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Static);

        foreach (var property in properties.OrderBy(p => p.Name))
        {
            _labels.Add(property.Name);
            _values.Add(property.GetValue(null)?.ToString() ?? string.Empty);
        }
    }

    private void UpdateSystemInformation()
    {
        using var graphics = CreateGraphics();
        var spaceSize = graphics.MeasureString(" ", Font);
        var maxLabelWidth = _labels.Max(x => graphics.MeasureString(x, Font).Width);
        var maxValueWidth = _values.Max(x => graphics.MeasureString(x, Font).Width);

        _height = Font.Height;
        _width = (int)Math.Ceiling(spaceSize.Width + maxLabelWidth);

        AutoScrollMinSize = new Size(
            (int)Math.Ceiling(_width + maxValueWidth),
            (int)Math.Ceiling((double)_height * Count)
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
