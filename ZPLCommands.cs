using System.Text;
using System;

namespace ZPLSharp.Commands
{

    public static class ZPLCommands
    {

        public const string StartMessage = "^XA";
        public const string EndMessage = "^XZ";
        public const string DownloadFileToFlash = "^DFE:";
        public const string DownloadFileToRam = "^DFR:";
        public const string DownloadGraphicToFlash = "~DGE:";
        public const string DownloadGraphicToRam = "~DGR:";

        public const string ResetPrinter = "~JR";
        public const string HostStatus = "~HS";
        public const string HostMemory = "~HM";
        public const string HostID = "~HI";
        //public const string SetLabelHome = "^LH0,0";
        public const string SetRegRotation = "^PON^FWN";
        //public const string SetPrintSpeed = "^PR";
        public const string SetPrintDarkness = "^MD";
        public const string ClearPartial = "~JX";
        public const string MediaCalibration = "~JC";
        public const string SetupLabel = "~WC";
        public const string PrinterPause = "~PP";
        public const string PrinterStart = "~PS";
        public const string RecallFileFromRam = "^XFR:";
        public const string RecallFileFromFlash = "^XFE:";
        public const string RecallGraphicFromRam = "^XGR:";
        public const string RecallGraphicFromFlash = "^XGE:";

        public static string GetBatteryStatus()
        {
            return "~HB";
        }

        public static string GetHeadDiagnostic()
        {
            return "~HD";
        }

        public static string GetConfigurationLabelReturn()
        {
            return "^HH";
        }

        public static string GetHostIdentification()
        {
            return "~HI";
        }

        public static string GetHostRAMStatus()
        {
            return "~HM";
        }

        public static string GetHostQuery(string ZPLQuery)
        {
            return $"~HQ{ZPLQuery}";
        }

        public static string GetHostStatus()
        {
            return "~HS";
        }

        public static string GetDescriptionInformation()
        {
            return "^HZa";
        }

        public static string CancelAll()
        {
            return "~JA";
        }

        public static string InitializeFlashMemory(ZPLFlashInit Init)
        {
            return $"^JB{(char)Init}";
        }

        public static string ResetMemoryCard()
        {
            return "~JB";
        }

        public static string SetMediaSensorCalibration()
        {
            return "~JC";
        }

        public static string EnableCommunicationsDiagnostics()
        {
            return "~JD";
        }

        public static string DisableCommunicationsDiagnostics()
        {
            return "~JE";
        }

        public static string SetBatteryCondition(bool Set)
        {
            char set = 'N';
            if (Set)
            {
                set = 'Y';
            }
            return $"~JF{set}";
        }

        public static string GraphingSensorCalibration()
        {
            return "~JG";
        }

        public static string SetLabelLength()
        {
            return "~JL";
        }

        public static string SetDotsPerMillimeter(ZPLDotsPerMillimeter Dots)
        {
            return $"^JM{(char)Dots}^FS";
        }

        public static string HeadTestFatal()
        {
            return "~JN";
        }

        public static string HeadTestNonFatal()
        {
            return "~JO";
        }

        public static string PauseAndCancelFormat()
        {
            return "~JP";
        }

        public static string PowerOnReset()
        {
            return "~JR";
        }

        public static string ConfigurationUpdate(ZPLConfigurationUpdate Update)
        {
            return $"^JU{(char)Update}";
        }

        public static string SetRibbonTension(ZPLRibbonTension Tension)
        {
            return $"^JW{(char)Tension}";
        }

        public static string CancelCurrentPartiallyInputFormat()
        {
            return $"~JX";
        }

        public static string ReprintAfterError(bool Reprint)
        {
            char reprint = 'N';

            if (Reprint)
            {
                reprint = 'Y';
            }

            return $"^JZ{reprint}";
        }

        public static string KillBattery()
        {
            return "~KB";
        }

        public static string SelectDateAndTimeFormat(ZPLDateTimeFormat Format)
        {
            return $"^KD{(int)Format}";
        }

        public static string DefineLanguage(ZPLLanguage Language)
        {
            return $"^KL{(int)Language}";
        }

        public static string DefinePrinterName(string Name, string Description)
        {
            return $"^KN{Name},{Description}";
        }

        public static string DefinePassword(string Password)
        {
            return $"^KP{Password}";
        }

        public static string SetLabelHome(int XCor, int YCor)
        {
            return $"^LH{XCor},{YCor}";
        }

        public static string SetLabelLength(int Length)
        {
            return $"^LL{Length}";
        }

        public static string ChangeFont(ZPLFont Font)
        {
            return $"^CF{(char)Font}";
        }

        public static string SetLabelReversePrint(bool Reverse)
        {
            char reverse = 'N';

            if (Reverse)
            {
                reverse = 'Y';
            }

            return $"^LR{reverse}";
        }

        public static string SetLabelShiftLeft(int Shift)
        {
            return $"^LS{Shift}";
        }

        public static string SetLabelShiftDown(int Shift)
        {
            return $"^LT{Shift}";
        }

        public static string MapClear(bool Clear)
        {
            char clear = 'N';

            if (Clear)
            {
                clear = 'Y';
            }

            return $"^MC{clear}";
        }

        public static string SetMediaDarkness(int Darkness)
        {
            return $"^MD{Darkness}";
        }

        public static string SetMaxLabelLength(int Length)
        {
            return $"^ML{Length}";
        }

        public static string SetPrintMode(ZPLPrintMode Mode, bool PrepeelSelect)
        {
            char pps = 'N';

            if (PrepeelSelect)
            {
                pps = 'Y';
            }

            return $"^ML{(char)Mode},{pps}";
        }

        public static string SetMediaTracking(ZPLMediaTracking Tracking, int BlackMarkOffset)
        {
            return $"^MN{(char)Tracking},{BlackMarkOffset}";
        }

        public static string SetModeProtection(ZPLModeProtection Protect)
        {
            return $"^MP{(char)Protect}";
        }

        public static string SetMediaType(ZPLMediaType Type)
        {
            return $"^MT{(char)Type}";
        }

        public static string SetHeadColdWarning(bool Warn)
        {
            char warn = 'N';

            if (Warn)
            {
                warn = 'Y';
            }

            return $"^MW{warn}";
        }

        public static string SetNetworkSettings(ZPLNetworkType Type, ZPLIPResolution Resolution, string IP, string SubnetMask, string Gateway, string WINSServer, bool TimeoutCheck, int TimeoutTime, int ARPInterval, int Port)
        {
            char timeoutcheck = 'N';

            if (TimeoutCheck)
            {
                timeoutcheck = 'Y';
            }

            return $"^ND{(int)Type},{(char)Resolution},{IP},{SubnetMask},{Gateway},{SubnetMask},{Gateway},{WINSServer},{timeoutcheck},{TimeoutTime},{ARPInterval},{Port}";
        }

        public static string DecommissionPrinter(string SerialNumber, int TimesToWipeFlash)
        {
            return $"~PM{SerialNumber},{TimesToWipeFlash}";
        }

        public static string SetPrintOrientation(bool UpsideDown)
        {
            char usd = 'N';

            if (UpsideDown)
            {
                usd = 'I';
            }

            return $"^PO{usd}";
        }

        public static string PausePrinter()
        {
            return "~PP";
        }

        public static string SetPrintSpeed(ZPLPrintSpeed PrintSpeed, ZPLSlewSpeed SlewSpeed, ZPLBackfeedSpeed BackfeedSpeed)
        {
            return $"^PR{(int)PrintSpeed},{(int)SlewSpeed},{(int)BackfeedSpeed}";
        }

        public static string ResumePrinting()
        {
            return $"~PS";
        }

        public static string SetDarkness(int Darkness)
        {
            var number = PadToLength(Darkness, 2);
            return $"~SD";
        }

        public static string SetDateAndTime(DateTime Date, ZPLTimeFormat Format)
        {

            var month = PadToLength(Date.Month, 2);
            var day = PadToLength(Date.Day, 2);
            string year = Date.Year.ToString();
            var hour = PadToLength(Date.Hour, 2);
            var minute = PadToLength(Date.Minute, 2);
            var second = PadToLength(Date.Second, 2);

            return $"^ST{month},{day},{year},{hour},{minute},{second},{(char)Format}";
        }

        public static string SetZPLVersion(ZPLVersion Version)
        {
            return $"^SZ{(int)Version}";
        }

        public static string SetTearOffPosition(int Position)
        {
            var number = PadToLength(Position, 3);
            return $"~TA{number}";
        }

        public static string PrintConfigurationLabel()
        {
            return "~WC";
        }

        public static string PrintWriteQuery(string ZPLQuery)
        {
            return $"~WQ{ZPLQuery}";
        }

        public static string SetDynamicMediaCalibration(bool DynamicLength, bool DynamicThreshold, bool DynamicGain)
        {
            char dl = 'N';
            char dt = 'N';
            char dg = 'N';

            if (DynamicLength)
            {
                dl = 'Y';
            }
            if (DynamicThreshold)
            {
                dt = 'Y';
            }
            if (DynamicGain)
            {
                dg = 'Y';
            }

            return $"^XS{dl},{dt}";
        }

        public static string PrinterSleep(int SecondsBeforeSleep, bool PrintRestOfLabels)
        {
            char prol = 'N';

            if (!PrintRestOfLabels)
            {
                prol = 'Y';
            }

            return $"^ZZ{SecondsBeforeSleep},{prol}";
        }



        public static string AddText(int XCor, int YCor, ZPLFont Font, ZPLOrientation Orientation, int FontHeight, int FontWidth, string Text)
        {
            return $"^FO{XCor},{YCor}^A{(char)Font}{(char)Orientation},{FontHeight},{FontWidth}^FD{Text}^FS";
        }

        public static string AddField(int XCor, int YCor, ZPLFont Font, ZPLOrientation Orientation, int FontHeight, int FontWidth, int FieldNumber, int FieldLength)
        {
            return $"^FO{XCor},{YCor}^A{(char)Font}{(char)Orientation},{FontHeight},{FontWidth}^FN{FieldNumber}^FA{FieldLength}^FS";
        }

        public static string AddBox(int XCor, int YCor, int Width, int Height, int BorderThickness, int ZeroToEightRounding, ZPLColor Color)
        {
            return $"^FO{XCor},{YCor}^GB{Width},{Height},{BorderThickness},{Color},{ZeroToEightRounding}^FS";
        }

        public static string AddCircle(int XCor, int YCor, int Diameter, int BorderThickness)
        {
            return $"^FO{XCor},{YCor}^GC{Diameter},{BorderThickness},B^FS";
        }

        public static string AddDiagonalLine(int XCor, int YCor, int Width, int Height, int BorderThickness, ZPLColor Color, ZPLLineOrientation Orientation)
        {
            return $"^FO{XCor},{YCor},^GD{Width},{Height},{BorderThickness},{Color},{Orientation}^FS";
        }

        public static string AddEllipse(int XCor, int YCor, int Width, int Height, int BorderThickness, ZPLColor Color)
        {
            return $"^FO{XCor},{YCor}^GE{Width},{Height},{BorderThickness},{Color}^FS";
        }

        public static string AddGraphic(int XCor, int YCor, ZPLLocation Location, string GraphicName, int XZoom, int YZoom)
        {
            return $"^FO{XCor},{YCor}^XG{(char)Location}:{GraphicName},{XZoom},{YZoom}^FS";
        }

        public static string AddSymbol(int XCor, int YCor, ZPLSymbol Symbol)
        {
            return $"^FO{XCor},{YCor}^GS^FD{Symbol}^FS";
        }

        public static string AddBarCode128(int XCor, int YCor, ZPLOrientation Orientation, int Height, bool PrintInterpretationLine, bool PrintInterpretationLineAboveCode, bool UCCCheckDigit, string Text)
        {
            char pil = 'N';
            char pilac = 'N';
            char ucccheck = 'N';

            if (PrintInterpretationLine)
            {
                pil = 'Y';
                if (PrintInterpretationLineAboveCode)
                {
                    pilac = 'Y';
                }
            }

            if (UCCCheckDigit)
            {
                ucccheck = 'Y';
            }

            return $"^FO{XCor},{YCor}^BY3^BC{Orientation},{Height},{pil},{pilac},{ucccheck}^FD{Text}^FS";
        }

        public static string AddSquareDataMatrix(int XCor, int YCor, ZPLOrientation Orientation, int RowsAndCols, string Text)
        {
            return $"^FO{XCor},{YCor}^BX{Orientation},{RowsAndCols},200^FD{Text}^FS";
        }




        static StringBuilder PadToLength(int Number, int Length)
        {
            var number = new StringBuilder(Number.ToString());
            while (number.Length < Length)
            {
                number.Insert(0, '0');
            }
            return number;
        }

    }
}