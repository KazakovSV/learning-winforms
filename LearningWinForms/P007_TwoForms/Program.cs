using System.Windows.Forms;

namespace P007_TwoForms;

internal class Program
{
    static void Main(string[] args)
    {
        var form1 = new Form();
        var form2 = new Form();

        form1.Text = "Form passed to Run()";
        form2.Text = "Second form";
        form2.Show();

        Application.Run(form1);

        MessageBox.Show(
            "Application.Run() has returned control back to Main(). Bye bye!",
            "Two Forms");
    }
}
