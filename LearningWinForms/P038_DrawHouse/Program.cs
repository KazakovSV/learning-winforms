using P035_PrintableForm;

namespace P038_DrawHouse;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new DrawHouse());
    }
}

public class DrawHouse : PrintableForm
{
    public DrawHouse()
    {
        Text = "Draw a House in One Line";
    }

    protected override void DoPage(Graphics graphics, Color color, int width, int height)
    {
        graphics.DrawLines(new Pen(color),
        [
            new Point( width / 4, 3 * height / 4),
            new Point( width / 4, height / 2),
            new Point( width / 2, height / 4),
            new Point(3 * width / 4, height / 2),
            new Point(3 * width / 4, 3 * height / 4),
            new Point( width / 4, height / 2),
            new Point(3 * width / 4, height / 2),
            new Point( width / 4, 3 * height / 4),
            new Point(3 * width / 4, 3 * height / 4)
        ]);
    }
}
