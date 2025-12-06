using P035_PrintableForm;

namespace P037_BoxingTheClient;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new BoxingTheClient());
    }
}

public class BoxingTheClient : PrintableForm
{
    public BoxingTheClient()
    {
        Text = "Boxing The Client";
    }

    protected override void DoPage(Graphics graphics, Color color, int width, int height)
    {
        var points = new Point[]
        {
            new Point(0, 0),
            new Point(width - 1, 0),
            new Point(width - 1, height - 1),
            new Point(0, height - 1),
            new Point(0, 0)
        };

        graphics.DrawLines(new Pen(color), points);
    }
}
