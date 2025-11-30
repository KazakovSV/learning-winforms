namespace P008_FormProperties;

internal class Program
{
    static void Main(string[] args)
    {
        var form = new Form();

        form.Text = "Form Properties";
        form.BackColor = Color.BlanchedAlmond;
        form.Width *= 2;
        form.Height /= 2;

        form.FormBorderStyle = FormBorderStyle.FixedSingle;
        form.MaximizeBox = false;
        form.Cursor = Cursors.Hand;
        form.StartPosition = FormStartPosition.CenterScreen;

        Application.Run(form);
    }
}
