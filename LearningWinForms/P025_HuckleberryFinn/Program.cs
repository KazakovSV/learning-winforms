namespace P025_HuckleberryFinn;

internal class HuckleberryFinn : Form
{
    static void Main(string[] args)
    {
        Application.Run(new HuckleberryFinn());
    }

    public HuckleberryFinn()
    {
        Text = "\"The Adventures of Huckleberry Finn\"";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
        ResizeRedraw = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.DrawString(
            "You don't know about me, without you " +
            "have read a book by the name of \"The " +
            "Adventures of Tom Sawyer,\" but that " +
            "ain't no matter. That book was made by " +
            "Mr. Mark Twain, and he told the truth, " +
            "mainly. There was things which he " +
            "stretched, but mainly he told the truth. " +
            "That is nothing. I never seen anybody " +
            "but lied, one time or another, without " +
            "it was Aunt Polly, or the widow, or " +
            "maybe Mary. Aunt Polly\x2014Tom's Aunt " +
            "Polly, she is\x2014and Mary, and the Widow " +
            "Douglas, is all told about in that book" +
            "\x2014which is mostly a true book; with " +
            "some stretchers, as I said before.",
            Font, SystemBrushes.WindowText, ClientRectangle);
    }
}
