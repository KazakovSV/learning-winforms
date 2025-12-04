namespace P024_HelloCenteredRectangle;

internal class HelloCenteredRectangle : Form
{
    static void Main(string[] args)
    {
        Application.Run(new HelloCenteredRectangle());
    }

    public HelloCenteredRectangle()
    {
        Text = "Hello Centered Using Rectangle";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var format = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
        };

        e.Graphics.DrawString("Hello, World!", Font, SystemBrushes.WindowText, ClientRectangle, format);
    }
}
