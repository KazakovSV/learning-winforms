namespace P028_SysInfoStrings;

internal class Program
{
    static void Main(string[] args)
    {
        Application.Run(new SysInfoList());
    }
}

internal class SysInfoList : Form
{
    private readonly int _x;
    private readonly int _y;

    public SysInfoList()
    {
        Text = "System Information: List";
        BackColor = SystemColors.Window;
        ForeColor = SystemColors.WindowText;

        _y = Font.Height;

        using var graphics = CreateGraphics();
        var spaceSize = graphics.MeasureString(" ", Font);
        _x = (int)(spaceSize.Width + SysInfoStrings.MaxLabelWidth(graphics, Font));
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        for (int i = 0; i < SysInfoStrings.Count; i++)
        {
            e.Graphics.DrawString(SysInfoStrings.Labels[i], Font,
                SystemBrushes.WindowText, 0, i * _y);
            e.Graphics.DrawString(SysInfoStrings.Values[i], Font,
                SystemBrushes.WindowText, _x, i * _y);
        }
    }
}

internal class SysInfoStrings
{
    public static string[] Labels
    {
        get
        {
            return
            [
                "ArrangeDirection",
                "ArrangeStartingPosition",
                "BootMode",
                "Border3DSize",
                "BorderSize",
                "CaptionButtonSize",
                "CaptionHeight",
                "ComputerName",
                "CursorSize",
                "DbcsEnabled",
                "DebugOS",
                "DoubleClickSize",
                "DoubleClickTime",
                "DragFullWindows",
                "DragSize",
                "FixedFrameBorderSize",
                "FrameBorderSize",
                "HighContrast",
                "HorizontalScrollBarArrowWidth",
                "HorizontalScrollBarHeight",
                "HorizontalScrollBarThumbWidth",
                "IconSize",
                "IconSpacingSize",
                "KanjiWindowHeight",
                "MaxWindowTrackSize",
                "MenuButtonSize",
                "MenuCheckSize",
                "MenuFont",
                "MenuHeight",
                "MidEastEnabled",
                "MinimizedWindowSize",
                "MinimizedWindowSpacingSize",
                "MinimumWindowSize",
                "MinWindowTrackSize",
                "MonitorCount",
                "MonitorsSameDisplayFormat",
                "MouseButtons",
                "MouseButtonsSwapped",
                "MousePresent",
                "MouseWheelPresent",
                "MouseWheelScrollLines",
                "NativeMouseWheelSupport",
                "Network",
                "PenWindows",
                "PrimaryMonitorMaximizedWindowSize",
                "PrimaryMonitorSize",
                "RightAlignedMenus",
                "Secure",
                "ShowSounds",
                "SmallIconSize",
                "ToolWindowCaptionButtonSize",
                "ToolWindowCaptionHeight",
                "UserDomainName",
                "UserInteractive",
                "UserName",
                "VerticalScrollBarArrowHeight",
                "VerticalScrollBarThumbHeight",
                "VerticalScrollBarWidth",
                "VirtualScreen",
                "WorkingArea",
            ];
        }
    }

    public static string[] Values
    {
        get
        {
            return
            [
                SystemInformation.ArrangeDirection.ToString(),
                SystemInformation.ArrangeStartingPosition.ToString(),
                SystemInformation.BootMode.ToString(),
                SystemInformation.Border3DSize.ToString(),
                SystemInformation.BorderSize.ToString(),
                SystemInformation.CaptionButtonSize.ToString(),
                SystemInformation.CaptionHeight.ToString(),
                SystemInformation.ComputerName,
                SystemInformation.CursorSize.ToString(),
                SystemInformation.DbcsEnabled.ToString(),
                SystemInformation.DebugOS.ToString(),
                SystemInformation.DoubleClickSize.ToString(),
                SystemInformation.DoubleClickTime.ToString(),
                SystemInformation.DragFullWindows.ToString(),
                SystemInformation.DragSize.ToString(),
                SystemInformation.FixedFrameBorderSize.ToString(),
                SystemInformation.FrameBorderSize.ToString(),
                SystemInformation.HighContrast.ToString(),
                SystemInformation.HorizontalScrollBarArrowWidth.ToString(),
                SystemInformation.HorizontalScrollBarHeight.ToString(),
                SystemInformation.HorizontalScrollBarThumbWidth.ToString(),
                SystemInformation.IconSize.ToString(),
                SystemInformation.IconSpacingSize.ToString(),
                SystemInformation.KanjiWindowHeight.ToString(),
                SystemInformation.MaxWindowTrackSize.ToString(),
                SystemInformation.MenuButtonSize.ToString(),
                SystemInformation.MenuCheckSize.ToString(),
                SystemInformation.MenuFont.ToString(),
                SystemInformation.MenuHeight.ToString(),
                SystemInformation.MidEastEnabled.ToString(),
                SystemInformation.MinimizedWindowSize.ToString(),
                SystemInformation.MinimizedWindowSpacingSize.ToString(),
                SystemInformation.MinimumWindowSize.ToString(),
                SystemInformation.MinWindowTrackSize.ToString(),
                SystemInformation.MonitorCount.ToString(),
                SystemInformation.MonitorsSameDisplayFormat.ToString(),
                SystemInformation.MouseButtons.ToString(),
                SystemInformation.MouseButtonsSwapped.ToString(),
                SystemInformation.MousePresent.ToString(),
                SystemInformation.MouseWheelPresent.ToString(),
                SystemInformation.MouseWheelScrollLines.ToString(),
                SystemInformation.NativeMouseWheelSupport.ToString(),
                SystemInformation.Network.ToString(),
                SystemInformation.PenWindows.ToString(),
                SystemInformation.PrimaryMonitorMaximizedWindowSize.ToString(),
                SystemInformation.PrimaryMonitorSize.ToString(),
                SystemInformation.RightAlignedMenus.ToString(),
                SystemInformation.Secure.ToString(),
                SystemInformation.ShowSounds.ToString(),
                SystemInformation.SmallIconSize.ToString(),
                SystemInformation.ToolWindowCaptionButtonSize.ToString(),
                SystemInformation.ToolWindowCaptionHeight.ToString(),
                SystemInformation.UserDomainName,
                SystemInformation.UserInteractive.ToString(),
                SystemInformation.UserName,
                SystemInformation.VerticalScrollBarArrowHeight.ToString(),
                SystemInformation.VerticalScrollBarThumbHeight.ToString(),
                SystemInformation.VerticalScrollBarWidth.ToString(),
                SystemInformation.VirtualScreen.ToString(),
                SystemInformation.WorkingArea.ToString()
            ];
        }
    }

    public static int Count => Labels.Length;

    public static float MaxLabelWidth(Graphics graphics, Font font)
    {
        return MaxWidth(Labels, graphics, font);
    }

    public static float MaxValueWidth(Graphics graphics, Font font)
    {
        return MaxWidth(Values, graphics, font);

    }

    static float MaxWidth(string[] values, Graphics graphics, Font font)
    {
        var max = 0.0f;

        foreach (var value in values)
        {
            max = Math.Max(max, graphics.MeasureString(value, font).Width);
        }

        return max;
    }
}
