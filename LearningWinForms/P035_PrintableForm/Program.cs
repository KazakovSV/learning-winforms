using System.Drawing.Printing;

namespace P035_PrintableForm;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new PrintableForm());
    }
}

public class PrintableForm : Form
{
    public PrintableForm()
    {
        Text = "Printable Form";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        DoPage(e.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
    }

    protected override void OnClick(EventArgs e)
    {
        var document = new PrintDocument { DocumentName = Text };
        document.PrintPage += OnDocumentPrintPage;
        document.Print();
    }

    private void OnDocumentPrintPage(object sender, PrintPageEventArgs e)
    {
        if (e.Graphics != null)
        {
            var boundsSize = e.Graphics.VisibleClipBounds.Size.ToSize();
            DoPage(e.Graphics, Color.Black, boundsSize.Width, boundsSize.Height);
        }
    }

    protected virtual void DoPage(Graphics graphics, Color color, int width, int height)
    {
        var pen = new Pen(color);

        graphics.DrawLine(pen, 0, 0, width - 1, height - 1);
        graphics.DrawLine(pen, 0, height - 1, width - 1, 0);
    }
}
