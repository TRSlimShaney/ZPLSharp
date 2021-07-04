using System;
using System.Text;
using ZPLSharp.Commands;

namespace ZPLSharp
{

    public static class ZPLAdministration
    {
        public static string GetBatteryStatus(string ZebraIPCMapping)
        {
            string command = ZPLCommands.GetBatteryStatus();
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static string GetHeadDiagnostic(string ZebraIPCMapping)
        {
            string command = ZPLCommands.GetHeadDiagnostic();
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static void GetConfigurationLabelReturn()
        {
            string command = BeginAndEnd(ZPLCommands.GetConfigurationLabelReturn());
        }

        public static string GetHostIdentification(string ZebraIPCMapping)
        {
            string command = ZPLCommands.GetHostIdentification();
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static string GetHostRAMStatus(string ZebraIPCMapping)
        {
            string command = ZPLCommands.GetHostRAMStatus();
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static string GetHostQuery(string ZebraIPCMapping, string ZPLQuery)
        {
            string command = ZPLCommands.GetHostQuery(ZPLQuery);
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static string GetHostStatus(string ZebraIPCMapping)
        {
            string command = ZPLCommands.GetHostStatus();
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static string GetDescriptionInformation(string ZebraIPCMapping)
        {
            string command = BeginAndEnd(ZPLCommands.GetDescriptionInformation());
            return ZPLIPC.SendWithResponse(ZebraIPCMapping, command);
        }

        public static void CancelAll(string ZebraIPCMapping)
        {
            string command = ZPLCommands.CancelAll();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void InitializeFlashMemory(string ZebraIPCMapping, ZPLFlashInit Init)
        {
            string command = BeginAndEnd(ZPLCommands.InitializeFlashMemory(Init));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void ResetMemoryCard(string ZebraIPCMapping)
        {
            string command = ZPLCommands.ResetMemoryCard();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetMediaSensorCalibration(string ZebraIPCMapping)
        {
            string command = ZPLCommands.SetMediaSensorCalibration();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void EnableCommunicationsDiagnostics(string ZebraIPCMapping)
        {
            string command = ZPLCommands.EnableCommunicationsDiagnostics();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DisableCommunicationsDiagnostics(string ZebraIPCMapping)
        {
            string command = ZPLCommands.DisableCommunicationsDiagnostics();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetBatteryCondition(string ZebraIPCMapping, bool Set)
        {
            string command = ZPLCommands.SetBatteryCondition(Set);
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void GraphingSensorCalibration(string ZebraIPCMapping)
        {
            string command = ZPLCommands.GraphingSensorCalibration();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetLabelLength(string ZebraIPCMapping)
        {
            string command = ZPLCommands.SetLabelLength();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetDotsPerMillimeter(string ZebraIPCMapping, ZPLDotsPerMillimeter Dots)
        {
            string command = BeginAndEnd(ZPLCommands.SetDotsPerMillimeter(Dots));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void HeadTestFatal(string ZebraIPCMapping)
        {
            string command = ZPLCommands.HeadTestFatal();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void HeadTestNonFatal(string ZebraIPCMapping)
        {
            string command = ZPLCommands.HeadTestNonFatal();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PauseAndCancelFormat(string ZebraIPCMapping)
        {
            string command = ZPLCommands.PauseAndCancelFormat();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PowerOnReset(string ZebraIPCMapping)
        {
            string command = ZPLCommands.PowerOnReset();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void ConfigurationUpdate(string ZebraIPCMapping, ZPLConfigurationUpdate Update)
        {
            string command = BeginAndEnd(ZPLCommands.ConfigurationUpdate(Update));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetRibbonTension(string ZebraIPCMapping, ZPLRibbonTension Tension)
        {
            string command = BeginAndEnd(ZPLCommands.SetRibbonTension(Tension));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void CancelCurrentPartiallyInputFormat(string ZebraIPCMapping)
        {
            string command = ZPLCommands.CancelCurrentPartiallyInputFormat();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void ReprintAfterError(string ZebraIPCMapping, bool Reprint)
        {
            string command = BeginAndEnd(ZPLCommands.ReprintAfterError(Reprint));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void KillBattery(string ZebraIPCMapping)
        {
            string command = ZPLCommands.KillBattery();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SelectDateAndTimeFormat(string ZebraIPCMapping, ZPLDateTimeFormat Format)
        {
            string command = BeginAndEnd(ZPLCommands.SelectDateAndTimeFormat(Format));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DefineLanguage(string ZebraIPCMapping, ZPLLanguage Language)
        {
            string command = BeginAndEnd(ZPLCommands.DefineLanguage(Language));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DefinePrinterName(string ZebraIPCMapping, string Name, string Description)
        {
            string command = BeginAndEnd(ZPLCommands.DefinePrinterName(Name, Description));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DefinePassword(string ZebraIPCMapping, string Password)
        {
            string command = BeginAndEnd(ZPLCommands.DefinePassword(Password));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetLabelHome(string ZebraIPCMapping, int XCor, int YCor)
        {
            string command = BeginAndEnd(ZPLCommands.SetLabelHome(XCor, YCor));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetLabelLength(string ZebraIPCMapping, int Length)
        {
            string command = BeginAndEnd(ZPLCommands.SetLabelLength(Length));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void ChangeFont(string ZebraIPCMapping, ZPLFont Font)
        {
            string command = BeginAndEnd(ZPLCommands.ChangeFont(Font));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetLabelReversePrint(string ZebraIPCMapping, bool Reverse)
        {
            string command = BeginAndEnd(ZPLCommands.SetLabelReversePrint(Reverse));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetLabelShiftLeft(string ZebraIPCMapping, int Shift)
        {
            string command = BeginAndEnd(ZPLCommands.SetLabelShiftLeft(Shift));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetLabelShiftDown(string ZebraIPCMapping, int Shift)
        {
            string command = BeginAndEnd(ZPLCommands.SetLabelShiftDown(Shift));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void MapClear(string ZebraIPCMapping, bool Clear)
        {
            string command = BeginAndEnd(ZPLCommands.MapClear(Clear));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetMediaDarkness(string ZebraIPCMapping, int Darkness)
        {
            string command = BeginAndEnd(ZPLCommands.SetMediaDarkness(Darkness));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetMaxLabelLength(string ZebraIPCMapping, int Length)
        {
            string command = BeginAndEnd(ZPLCommands.SetLabelLength(Length));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetPrintMode(string ZebraIPCMapping, ZPLPrintMode Mode, bool PrepeelSelect)
        {
            string command = BeginAndEnd(ZPLCommands.SetPrintMode(Mode, PrepeelSelect));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetMediaTracking(string ZebraIPCMapping, ZPLMediaTracking Tracking, int BlackMarkOffset)
        {
            string command = BeginAndEnd(ZPLCommands.SetMediaTracking(Tracking, BlackMarkOffset));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetModeProtection(string ZebraIPCMapping, ZPLModeProtection Protect)
        {
            string command = BeginAndEnd(ZPLCommands.SetModeProtection(Protect));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetMediaType(string ZebraIPCMapping, ZPLMediaType Type)
        {
            string command = BeginAndEnd(ZPLCommands.SetMediaType(Type));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetHeadColdWarning(string ZebraIPCMapping, bool Warn)
        {
            string command = BeginAndEnd(ZPLCommands.SetHeadColdWarning(Warn));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetNetworkSettings(string ZebraIPCMapping, ZPLNetworkType Type, ZPLIPResolution Resolution, string IP, string SubnetMask, string Gateway, string WINSServer, bool TimeoutCheck, int TimeoutTime, int ARPInterval, int Port)
        {
            string command = BeginAndEnd(ZPLCommands.SetNetworkSettings(Type, Resolution, IP, SubnetMask, Gateway, WINSServer, TimeoutCheck, TimeoutTime, ARPInterval, Port));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void DecommissionPrinter(string ZebraIPCMapping, string SerialNumber, int TimesToWipeFlash)
        {
            string command = ZPLCommands.DecommissionPrinter(SerialNumber, TimesToWipeFlash);
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetPrintOrientation(string ZebraIPCMapping, bool UpsideDown)
        {
            string command = BeginAndEnd(ZPLCommands.SetPrintOrientation(UpsideDown));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PausePrinter(string ZebraIPCMapping)
        {
            string command = ZPLCommands.PausePrinter();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetPrintSpeed(string ZebraIPCMapping, ZPLPrintSpeed PrintSpeed, ZPLSlewSpeed SlewSpeed, ZPLBackfeedSpeed BackfeedSpeed)
        {
            string command = BeginAndEnd(ZPLCommands.SetPrintSpeed(PrintSpeed, SlewSpeed, BackfeedSpeed));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void ResumePrinting(string ZebraIPCMapping)
        {
            string command = ZPLCommands.ResumePrinting();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetDarkness(string ZebraIPCMapping, int Darkness)
        {
            string command = ZPLCommands.SetDarkness(Darkness);
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetDateAndTime(string ZebraIPCMapping, DateTime Date, ZPLTimeFormat Format)
        {

            string command = BeginAndEnd(ZPLCommands.SetDateAndTime(Date, Format));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetZPLVersion(string ZebraIPCMapping, ZPLVersion Version)
        {
            string command = BeginAndEnd(ZPLCommands.SetZPLVersion(Version));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetTearOffPosition(string ZebraIPCMapping, int Position)
        {
            string command = ZPLCommands.SetTearOffPosition(Position);
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PrintConfigurationLabel(string ZebraIPCMapping)
        {
            string command = ZPLCommands.PrintConfigurationLabel();
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PrintWriteQuery(string ZebraIPCMapping, string ZPLQuery)
        {
            string command = ZPLCommands.PrintWriteQuery(ZPLQuery);
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void SetDynamicMediaCalibration(string ZebraIPCMapping, bool DynamicLength, bool DynamicThreshold, bool DynamicGain)
        {
            string command = BeginAndEnd(ZPLCommands.SetDynamicMediaCalibration(DynamicLength, DynamicThreshold, DynamicGain));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }

        public static void PrinterSleep(string ZebraIPCMapping, int SecondsBeforeSleep, bool PrintRestOfLabels)
        {
            string command = BeginAndEnd(ZPLCommands.PrinterSleep(SecondsBeforeSleep, PrintRestOfLabels));
            ZPLIPC.SendWithNoResponse(ZebraIPCMapping, command);
        }


        static string BeginAndEnd(string command)
        {
            return $"{ZPLCommands.StartMessage}{command}{ZPLCommands.EndMessage}";
        }

    }
}