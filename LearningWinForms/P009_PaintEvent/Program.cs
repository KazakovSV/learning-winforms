namespace P009_PaintEvent;

internal class Program
{
    static void Main(string[] args)
    {
        var form = new Form();

        form.Text = "Paint Event";
        form.Paint += OnPaint;

        Application.Run(form);
    }

    private static void OnPaint(object? sender, PaintEventArgs e)
    {
        var graphics = e.Graphics;
        graphics.Clear(Color.Chocolate);
        Console.WriteLine("Paint Event");
    }
}
