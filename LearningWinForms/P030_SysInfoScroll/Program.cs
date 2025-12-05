using System.Reflection;

namespace P030_SysInfoScroll;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoScroll());
    }
}

internal class SysInfoScroll : Form
{
    private readonly Dictionary<string, string> _properties = [];

    private readonly int _columnWidth;
    private readonly int _rowHeight;

    public SysInfoScroll()
    {
        Text = "System Information: Scroll";
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

        AutoScrollMinSize = new Size(
            (int)Math.Ceiling(_columnWidth + maxValueWidth),
            (int)Math.Ceiling((double)_rowHeight * _properties.Count)
        );
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var brush = SystemBrushes.WindowText;
        var row = 0;
        var position = AutoScrollPosition;

        foreach (var kvp in _properties)
        {
            e.Graphics.DrawString(kvp.Key, Font, brush,
                position.X, position.Y + row * _rowHeight);
            e.Graphics.DrawString(kvp.Value, Font, brush,
                position.X + _columnWidth, position.Y + row * _rowHeight);
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
