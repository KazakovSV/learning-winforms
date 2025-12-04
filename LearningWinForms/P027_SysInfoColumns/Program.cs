namespace P027_SysInfoColumns;

internal class SysInfoColumns : Form
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoColumns());
    }

    public SysInfoColumns()
    {
        Text = "System Information: Columns";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var columnSize = e.Graphics.MeasureString("ArrangeStartingPosition ", Font);
        var x = columnSize.Width;
        var y = Font.Height;
        var brush = SystemBrushes.WindowText;

        e.Graphics.DrawString("ArrangeDirection", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.ArrangeDirection.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("ArrangeStartingPosition", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.ArrangeStartingPosition.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("BootMode", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.BootMode.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("Border3DSize", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.Border3DSize.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("BorderSize", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.BorderSize.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("CaptionButtonSize", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.CaptionButtonSize.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("CaptionHeight", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.CaptionHeight.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("ComputerName", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.ComputerName.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("CursorSize", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.CursorSize.ToString(), Font, brush, x, y);

        y += Font.Height;

        e.Graphics.DrawString("DbcsEnabled", Font, brush, 0, y);
        e.Graphics.DrawString(SystemInformation.DbcsEnabled.ToString(), Font, brush, x, y);
    }
}
