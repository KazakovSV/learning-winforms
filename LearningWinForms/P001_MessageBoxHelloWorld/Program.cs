using System.Windows.Forms;

namespace P001_MessageBoxHelloWorld;

internal class Program
{
    static void Main(string[] args)
    {
        MessageBox.Show(
            "Hello, World!",
            "Message Box Window",
            MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation);
    }
}
