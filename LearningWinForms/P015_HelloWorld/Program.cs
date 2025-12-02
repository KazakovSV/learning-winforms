namespace P015_HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new HelloWorld());
        }
    }

    internal class HelloWorld : Form
    {
        public HelloWorld()
        {
            Text = "Hello World";
            BackColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString("Hello, Windows Forms!", Font, Brushes.Black, 0, 0);
        }
    }
}
