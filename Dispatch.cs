using System.Text;
using ZPLSharp.Commands;

namespace ZPLSharp
{

    public static class ZPLDispatch
    {

        public static void DownloadGraphic(string ZebraIPCMapping, ZPLLocation Location, string GraphicName, int BytesPerRow, byte[] Graphic)
        {
            string command = $"~DG{(char)Location}:{GraphicName},{Graphic.Length},{BytesPerRow},{Encoding.ASCII.GetString(Graphic)}";
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DownloadFormat(string ZebraIPCMapping, ZPLLocation Location, string FormatName, ZPLLabelBuilder Format)
        {
            string command = $"{ZPLCommands.StartMessage}^DF{(char)Location}:{FormatName}.ZPL^FS{Format.GetLabel()}{ZPLCommands.EndMessage}";
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PrintLabelUsingFormat(string ZebraIPCMapping, ZPLLocation Location, string FormatName, ZPLFormatFiller Filler)
        {
            string command = $"{ZPLCommands.StartMessage}^XF{(char)Location}:{FormatName}.ZPL^FS{Filler.GetFiller()}{ZPLCommands.EndMessage}";
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PrintLabel(string ZebraIPCMapping, ZPLLabelBuilder Label)
        {
            string command = $"{ZPLCommands.StartMessage}{Label.GetLabel()}{ZPLCommands.EndMessage}";
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DownloadSettings(string ZebraIPCMapping, ZPLSettingsBuilder Settings)
        {
            string command = $"{ZPLCommands.StartMessage}{Settings.GetLabel()}{ZPLCommands.EndMessage}";
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }
    }
}