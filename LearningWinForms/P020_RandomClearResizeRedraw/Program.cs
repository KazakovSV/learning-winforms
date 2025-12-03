namespace P020_RandomClearResizeRedraw;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new RandomClearResizeRedraw());
    }
}

internal class RandomClearResizeRedraw : Form
{
    private readonly Random _random = new Random();

    public RandomClearResizeRedraw()
    {
        Text = "Random Clear with ResizeRedraw";
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var color = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        e.Graphics.Clear(color);
    }
}
