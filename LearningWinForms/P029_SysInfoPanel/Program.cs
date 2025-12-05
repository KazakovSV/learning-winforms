using System.Reflection;

namespace P029_SysInfoPanel;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoPanel());
    }
}

internal class SysInfoPanel : Form
{
    private readonly Dictionary<string, string> _properties = [];

    private int _columnWidth;
    private int _rowHeight;

    public SysInfoPanel()
    {
        Text = "System Information: Panel";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        AutoScroll = true;

        LoadSystemInformation();

        using var graphics = CreateGraphics();
        var spaceSize = graphics.MeasureString(" ", Font);
        var maxLabelWidth = _properties.Max(x => graphics.MeasureString(x.Key, Font).Width);
        var maxValueWidth = _properties.Max(x => graphics.MeasureString(x.Value, Font).Width);
        _rowHeight = Font.Height;
        _columnWidth = (int)Math.Ceiling(spaceSize.Width + maxLabelWidth);

        var panel = new Panel
        {
            Parent = this,
            Location = Point.Empty,
            BackColor = Color.Honeydew,
            Size = new Size(
                (int)Math.Ceiling(_columnWidth + maxValueWidth),
                (int)Math.Ceiling((double)_rowHeight * _properties.Count)
            )
        };

        panel.Paint += OnPanelPaint;
    }

    private void OnPanelPaint(object? sender, PaintEventArgs e)
    {
        var brush = SystemBrushes.WindowText;
        var row = 0;

        foreach (var kvp in _properties)
        {
            e.Graphics.DrawString(kvp.Key, Font, brush, 0, row * _rowHeight);
            e.Graphics.DrawString(kvp.Value, Font, brush, _columnWidth, row * _rowHeight);
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
}