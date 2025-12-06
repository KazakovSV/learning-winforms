using System.Drawing.Printing;

namespace P034_HelloPrinter;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new HelloPrinter());
    }
}

internal class HelloPrinter : Form
{
    public HelloPrinter()
    {
        Text = "Hello Printer!";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var format = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        e.Graphics.DrawString("Click to print", Font, SystemBrushes.WindowText, ClientRectangle, format);
    }

    protected override void OnClick(EventArgs e)
    {
        var document = new PrintDocument { DocumentName = Text };
        document.PrintPage += OnPrintPage;
        document.Print();
    }

    private void OnPrintPage(object sender, PrintPageEventArgs e)
    {
        if (e.Graphics != null)
        {
            e.Graphics.DrawString(Text, Font, Brushes.Black, 0, 0);

            var textSize = e.Graphics.MeasureString(Text, Font);

            e.Graphics.DrawLine(Pens.Black, textSize.ToPointF(), e.Graphics.VisibleClipBounds.Size.ToPointF());
        }
    }
}
