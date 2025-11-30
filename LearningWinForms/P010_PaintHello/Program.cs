namespace P010_PaintHello;

internal class Program
{
    static void Main(string[] args)
    {
        var form = new Form
        {
            Text = "Paint Hello",
            BackColor = Color.White,
        };

        form.Paint += OnPaint;

        Application.Run(form);
    }

    private static void OnPaint(object? sender, PaintEventArgs e)
    {
        if (sender is Form form)
        {
            var graphics = e.Graphics;
            graphics.DrawString("Hello, World!", form.Font, Brushes.Black, 0, 0);
        }
    }
}
