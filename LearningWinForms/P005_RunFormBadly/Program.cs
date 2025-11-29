using System.Windows.Forms;

namespace P005_RunFormBadly;

internal class Program
{
    static void Main(string[] args)
    {
        var form = new Form();

        form.Text = "Not a Good Idea...";
        form.Visible = true;

        Application.Run();
    }
}
