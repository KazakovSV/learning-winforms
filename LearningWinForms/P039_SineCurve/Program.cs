using P035_PrintableForm;

namespace P039_SineCurve;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new SineCurve());
    }
}

public class SineCurve : PrintableForm
{
    public SineCurve()
    {
        Text = "Sine Curve";
    }

    protected override void DoPage(Graphics graphics, Color color, int width, int height)
    {
        var points = new PointF[width];

        for (int i = 0; i < points.Length; i++)
        {
            points[i].X = i;
            points[i].Y = height / 2 * (1 - (float)Math.Sin(i * 2 * Math.PI / (width - 1)));
        }

        graphics.DrawLines(new Pen(color), points);
    }
}
