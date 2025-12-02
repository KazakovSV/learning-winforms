using P015_HelloWorld;

namespace P017_InstantiateHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var form = new HelloWorld();

            form.Text = "Instantiate " + form.Text;
            form.Paint += OnPaint;

            Application.Run(form);
        }

        private static void OnPaint(object? sender, PaintEventArgs e)
        {
            if (sender is Form form)
            {
                e.Graphics.DrawString("Hello from InstantiateHelloWorld!",
                    form.Font, Brushes.Black, 0, 100);
            }
        }
    }
}
