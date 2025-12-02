namespace P012_TwoPaintHandlers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var form = new Form
            {
                Text = "Two Paint Handlers",
                BackColor = Color.White
            };

            form.Paint += OnPaint1;
            form.Paint += OnPaint2;

            Application.Run(form);
        }

        private static void OnPaint1(object? sender, PaintEventArgs e)
        {
            if (sender is Form form)
            {
                e.Graphics.DrawString("First Paint Event Handler",
                    form.Font, Brushes.Black, 0, 0);
            }
        }

        private static void OnPaint2(object? sender, PaintEventArgs e)
        {
            if (sender is Form form)
            {
                e.Graphics.DrawString("Second Paint Event Handler",
                    form.Font, Brushes.Black, 0, 100);
            }
        }
    }
}
