namespace P033_XMarksTheSpot;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new XMarksTheSpot());
    }
}

internal class XMarksTheSpot : Form
{
    public XMarksTheSpot()
    {
        Text = "X Marks The Spot";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var pen = new Pen(ForeColor);

        e.Graphics.DrawLine(pen, 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);
        e.Graphics.DrawLine(pen, 0, ClientSize.Height - 1, ClientSize.Width - 1, 0);
    }
}
