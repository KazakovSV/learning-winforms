namespace P014_InheritWithConstructor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Application.Run(new InheritWithConstructor());
        }
    }

    internal class InheritWithConstructor : Form
    {
        public InheritWithConstructor()
        {
            Text = "Inherit with Constructor";
            BackColor = Color.White;
        }
    }
}
