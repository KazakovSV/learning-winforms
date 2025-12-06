using System.Drawing.Drawing2D;

namespace P036_AntiAlias;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new AntiAlias());
    }
}

public class AntiAlias : Form
{
    public AntiAlias()
    {
        Text = "Anti Alias Demo";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var pen = new Pen(ForeColor);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        e.Graphics.DrawLine(pen, 2, 2, 18, 10);
    }
}
