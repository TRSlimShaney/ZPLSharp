using System.Text;
using System;
using ZPLSharp.Commands;

namespace ZPLSharp
{

    public class ZPLSettingsBuilder
    {
        StringBuilder Settings = new StringBuilder();

        public ZPLSettingsBuilder()
        {
        }

        public StringBuilder GetLabel()
        {
            return Settings;
        }

        public void SelectDateAndTimeFormat(ZPLDateTimeFormat Format)
        {
            Settings.Append(ZPLCommands.SelectDateAndTimeFormat(Format));
        }

        public void DefineLanguage(ZPLLanguage Language)
        {
            Settings.Append(ZPLCommands.DefineLanguage(Language));
        }

        public void DefinePrinterName(string Name, string Description)
        {
            Settings.Append(ZPLCommands.DefinePrinterName(Name, Description));
        }

        public void DefinePassword(string Password)
        {
            Settings.Append(ZPLCommands.DefinePassword(Password));
        }

        public void SetLabelHome(int XCor, int YCor)
        {
            Settings.Append(ZPLCommands.SetLabelHome(XCor, YCor));
        }

        public void SetLabelLength(int Length)
        {
            Settings.Append(ZPLCommands.SetLabelLength(Length));
        }

        public void ChangeFont(ZPLFont Font)
        {
            Settings.Append(ZPLCommands.ChangeFont(Font));
        }

        public void SetLabelReversePrint(bool Reverse)
        {
            Settings.Append(ZPLCommands.SetLabelReversePrint(Reverse));
        }

        public void SetLabelShiftLeft(int Shift)
        {
            Settings.Append(ZPLCommands.SetLabelShiftLeft(Shift));
        }

        public void SetLabelShiftDown(int Shift)
        {
            Settings.Append(ZPLCommands.SetLabelShiftDown(Shift));
        }

        public void MapClear(bool Clear)
        {
            Settings.Append(ZPLCommands.MapClear(Clear));
        }

        public void SetMediaDarkness(int Darkness)
        {
            Settings.Append(ZPLCommands.SetMediaDarkness(Darkness));
        }

        public void SetMaxLabelLength(int Length)
        {
            Settings.Append(ZPLCommands.SetMaxLabelLength(Length));
        }

        public void SetPrintMode(ZPLPrintMode Mode, bool PrepeelSelect)
        {
            Settings.Append(ZPLCommands.SetPrintMode(Mode, PrepeelSelect));
        }

        public void SetMediaTracking(ZPLMediaTracking Tracking, int BlackMarkOffset)
        {
            Settings.Append(ZPLCommands.SetMediaTracking(Tracking, BlackMarkOffset));
        }

        public void SetModeProtection(ZPLModeProtection Protect)
        {
            Settings.Append(ZPLCommands.SetModeProtection(Protect));
        }

        public void SetMediaType(ZPLMediaType Type)
        {
            Settings.Append(ZPLCommands.SetMediaType(Type));
        }

        public void SetHeadColdWarning(bool Warn)
        {
            Settings.Append(ZPLCommands.SetHeadColdWarning(Warn));
        }

        public void SetNetworkSettings(ZPLNetworkType Type, ZPLIPResolution Resolution, string IP, string SubnetMask, string Gateway, string WINSServer, bool TimeoutCheck, int TimeoutTime, int ARPInterval, int Port)
        {
            Settings.Append(ZPLCommands.SetNetworkSettings(Type, Resolution, IP, SubnetMask, Gateway, WINSServer, TimeoutCheck, TimeoutTime, ARPInterval, Port));
        }

        public void SetPrintOrientation(bool UpsideDown)
        {
            Settings.Append(ZPLCommands.SetPrintOrientation(UpsideDown));
        }

        public void SetPrintSpeed(ZPLPrintSpeed PrintSpeed, ZPLSlewSpeed SlewSpeed, ZPLBackfeedSpeed BackfeedSpeed)
        {
            Settings.Append(ZPLCommands.SetPrintSpeed(PrintSpeed, SlewSpeed, BackfeedSpeed));
        }

        public void SetDateAndTime(DateTime Date, ZPLTimeFormat Format)
        {
            Settings.Append(ZPLCommands.SetDateAndTime(Date, Format));
        }

        public void SetZPLVersion(ZPLVersion Version)
        {
            Settings.Append(ZPLCommands.SetZPLVersion(Version));
        }

        public void SetDarkness(int Darkness)
        {
            Settings.Append(ZPLCommands.SetDarkness(Darkness));
        }

        public void SetTearOffPosition(int Position)
        {
            Settings.Append(ZPLCommands.SetTearOffPosition(Position));
        }

        public void SetDynamicMediaCalibration(bool DynamicLength, bool DynamicThreshold, bool DynamicGain)
        {
            Settings.Append(ZPLCommands.SetDynamicMediaCalibration(DynamicLength, DynamicThreshold, DynamicGain));
        }

        public void ReprintAfterError(bool Reprint)
        {
            Settings.Append(ZPLCommands.ReprintAfterError(Reprint));
        }
    }
}