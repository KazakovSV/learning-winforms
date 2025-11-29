using System.Threading;
using System.Windows.Forms;

namespace P004_ShowFormAndSleep;

internal class Program
{
    static void Main(string[] args)
    {
        var form = new Form();
        form.Show();

        Thread.Sleep(2500);

        form.Text = "My First Form";

        Thread.Sleep(2500);
    }
}
