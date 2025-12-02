using P015_HelloWorld;

namespace P016_InheritHelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new InheritHelloWorld());
        }
    }

    internal class InheritHelloWorld : HelloWorld
    {
        public InheritHelloWorld()
        {
            Text = "Inherit " + Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawString("Hello from InheritHelloWorld!",
                Font, Brushes.Black, 0, 100);
        }
    }
}
