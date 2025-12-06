using P031_SysInfoUpdate;

namespace P032_SysInfoEfficient;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoEfficient());
    }
}

internal class SysInfoEfficient : SysInfoUpdate
{
    public SysInfoEfficient()
    {
        Text = "System Information: Efficient";
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var brush = SystemBrushes.WindowText;
        var position = AutoScrollPosition;

        var startRow = (e.ClipRectangle.Top - position.Y) / _height;
        var endRow = (e.ClipRectangle.Bottom - position.Y) / _height;
        endRow = Math.Min(Count - 1, endRow);

        for (int  i = startRow; i <= endRow; i++)
        {
            e.Graphics.DrawString(_labels[i], Font, brush,
                position.X, position.Y + i * _height);
            e.Graphics.DrawString(_values[i], Font, brush,
                position.X + _width, position.Y + i * _height);
        }
    }
}
