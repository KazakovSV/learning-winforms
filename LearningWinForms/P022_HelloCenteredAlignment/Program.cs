namespace P022_HelloCenteredAlignment;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new HelloCenteredAlignment());
    }
}

internal class HelloCenteredAlignment : Form
{
    public HelloCenteredAlignment()
    {
        Text = "Hello Centered Using String Alignment";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var grphics = e.Graphics;
        var brush = new SolidBrush(ForeColor);

        var format = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        grphics.DrawString("Hello, World!", Font, brush, ClientSize.Width / 2, ClientSize.Height / 2, format);
    }
}