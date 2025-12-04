namespace P026_SysInfoFirstTry;

internal class SysInfoFirstTry : Form
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoFirstTry());
    }

    public SysInfoFirstTry()
    {
        Text = "System Information: First Try";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var height = 0;

        e.Graphics.DrawString("ArrangeDirection: " + SystemInformation.ArrangeDirection,
            Font, SystemBrushes.WindowText, 0, height);

        e.Graphics.DrawString("ArrangeStartingPosition: " + SystemInformation.ArrangeStartingPosition,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("BootMode: " + SystemInformation.BootMode,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("Border3DSize: " + SystemInformation.Border3DSize,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("BorderSize: " + SystemInformation.BorderSize,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("CaptionButtonSize: " + SystemInformation.CaptionButtonSize,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("CaptionHeight: " + SystemInformation.CaptionHeight,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("ComputerName: " + SystemInformation.ComputerName,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("CursorSize: " + SystemInformation.CursorSize,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);

        e.Graphics.DrawString("DbcsEnabled: " + SystemInformation.DbcsEnabled,
            Font, SystemBrushes.WindowText, 0, height += Font.Height);
    }
}
