using System.Windows.Forms;

namespace P006_RunFormBetter;

internal class Program
{
    static void Main(string[] args)
    {
        var form = new Form();

        form.Text = "My Very Own Form";

        Application.Run(form);
    }
}
