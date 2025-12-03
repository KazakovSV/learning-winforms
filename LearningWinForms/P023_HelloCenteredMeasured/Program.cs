namespace P023_HelloCenteredMeasured;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new HelloCenteredMeasured());
    }
}

internal class HelloCenteredMeasured : Form
{
    public HelloCenteredMeasured()
    {
        Text = "Hello Centered Using MeasureString";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var graphics = e.Graphics;
        var brush = new SolidBrush(ForeColor);
        var text = "Hello, World!";
        var textSize = graphics.MeasureString(text, Font);

        var textX = (ClientSize.Width - textSize.Width) / 2;
        var textY = (ClientSize.Height - textSize.Height) / 2;

        graphics.DrawString(text, Font, brush, textX, textY);
    }
}
