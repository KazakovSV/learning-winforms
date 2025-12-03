namespace P021_FourCorners;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new FourCorners());
    }
}

internal class FourCorners : Form
{
    public FourCorners()
    {
        Text = "Four Corners Text Alignment";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var grphics = e.Graphics;
        var brush = new SolidBrush(ForeColor);
        var format = new StringFormat();

        format.Alignment = StringAlignment.Near;
        format.LineAlignment = StringAlignment.Near;
        grphics.DrawString("Upper left corner", Font, brush, 0, 0, format);

        format.Alignment = StringAlignment.Far;
        format.LineAlignment = StringAlignment.Near;
        grphics.DrawString("Upper right corner", Font, brush, ClientSize.Width, 0, format);

        format.Alignment = StringAlignment.Near;
        format.LineAlignment = StringAlignment.Far;
        grphics.DrawString("Lower left corner", Font, brush, 0, ClientSize.Height, format);

        format.Alignment = StringAlignment.Far;
        format.LineAlignment = StringAlignment.Far;
        grphics.DrawString("Lower right corner", Font, brush, ClientSize.Width, ClientSize.Height, format);
    }
}
