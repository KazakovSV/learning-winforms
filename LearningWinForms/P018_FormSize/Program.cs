
namespace P018_FormSize;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new FormSize());
    }
}

internal class FormSize : Form
{
    public FormSize()
    {
        Text = "Form Size";
        BackColor = Color.White;
    }

    protected override void OnMove(EventArgs e)
    {
        Invalidate();
    }

    protected override void OnResize(EventArgs e)
    {
        Invalidate();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var info = "Location: " + Location + "\n" +
                   "Size: " + Size + "\n" +
                   "Bounds: " + Bounds + "\n" +
                   "Width: " + Width + "\n" +
                   "Height: " + Height + "\n" +
                   "Left: " + Left + "\n" +
                   "Top: " + Top + "\n" +
                   "Right: " + Right + "\n" +
                   "Bottom: " + Bottom + "\n" +
                   "DesktopLocation: " + DesktopLocation + "\n" +
                   "DesktopBounds: " + DesktopBounds + "\n" +
                   "ClientSize: " + ClientSize + "\n" +
                   "ClientRectangle: " + ClientRectangle;
        e.Graphics.DrawString(info, Font, Brushes.Black, 0, 0);
    }
}
