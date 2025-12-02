namespace P013_InheritTheForm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var form = new InheritTheForm
            {
                Text = "Inherit The Form",
                BackColor = Color.White
            };

            Application.Run(form);
        }
    }

    internal class InheritTheForm : Form
    {
    }
}
