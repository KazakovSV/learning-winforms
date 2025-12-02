namespace P011_PaintTwoForms
{
    internal class Program
    {
        private static Form? _form1;
        private static Form? _form2;

        public static void Main(string[] args)
        {
            _form1 = new Form();
            _form2 = new Form();

            _form1.Text = "First form";
            _form1.BackColor = Color.White;
            _form1.Paint += OnPaint;

            _form2.Text = "Second form";
            _form2.BackColor = Color.White;
            _form2.Paint += OnPaint;
            _form2.Show();

            Application.Run(_form1);
        }

        private static void OnPaint(object? sender, PaintEventArgs e)
        {
            if (sender is Form form)
            {
                var graphics = e.Graphics;
                var text = form == _form1
                    ? "Hello from the first form."
                    : "Hello from the second form.";

                graphics.DrawString(text, form.Font, Brushes.Black, 0, 0);
            }
        }
    }
}
