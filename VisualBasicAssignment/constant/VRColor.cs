using System.Drawing;

namespace VisualBasicAssignment
{
    public class VRColor
    {
        public static object PRIMARY_BG { get; private set; } = ColorTranslator.FromHtml("#FFFFFF");
        public static object SECOND_BG { get; private set; } = ColorTranslator.FromHtml("#F2F2F2");
        public static object COLORED_BG { get; private set; } = ColorTranslator.FromHtml("#039BCD");
        public static object DARK_COLOR_BG { get; private set; } = ColorTranslator.FromHtml("#15262E");
        public static object PRIMARY_TEXT { get; private set; } = ColorTranslator.FromHtml("#7C7C7C");
        public static object SECOND_TEXT { get; private set; } = ColorTranslator.FromHtml("#111111");
        public static object SUCCESS_COLOR { get; private set; } = ColorTranslator.FromHtml("#5CB85C");
        public static object INFO_COLOR { get; private set; } = ColorTranslator.FromHtml("#5BC0DE");
        public static object WARNING_COLOR { get; private set; } = ColorTranslator.FromHtml("#F0AD4E");
        public static object DANGER_COLOR { get; private set; } = ColorTranslator.FromHtml("#D9534F");
        public static object BUTTON_TEXT { get; private set; } = ColorTranslator.FromHtml("#FCFCFC");
        public static object BUTTON_BG { get; private set; } = ColorTranslator.FromHtml("#039BCD");
        public static object HOVER_BUTTON_BG { get; private set; } = ColorTranslator.FromHtml("#006194");
    }
}