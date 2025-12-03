namespace P019_RandomClear;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new RandomClear());
    }
}

internal class RandomClear : Form
{
    private readonly Random _random = new Random();

    public RandomClear()
    {
        Text = "Random Clear";
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var color = Color.FromArgb(_random.Next(256), _random.Next(256), _random.Next(256));
        e.Graphics.Clear(color);
    }
}
