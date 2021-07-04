

namespace ZPLSharp
{

    public enum ZPLPrinterDPI
    {
        DPI200,
        DPI300,
        DPI600
    }

    public enum ZPLOrientation
    {
        Normal = 'N',
        Right = 'R',
        UpsideDown = 'I',
        Left = 'B'
    }

    public enum ZPLLineOrientation
    {
        LeftLeaning = 'L',
        RightLeaning = 'R'
    }

    public enum ZPLFont
    {
        Default = 'D',
        ZeroScalable = '0'
    }

    public enum ZPLColor
    {
        Black = 'B',
        White = 'W'
    }

    public enum ZPLSymbol
    {
        RegisteredTrademark = 'A',
        Copyright = 'B',
        Trademark = 'C',
        UnderwritersLabsApproval = 'D',
        CanadianStandardsAssocationApproval = 'E'
    }

    public static class ZPLHostQuery
    {
        public const string PrinterStatus = "ES";
    }

    public enum ZPLFlashInit
    {
        OptionFlashMemory = 'A',
        PCMCIAFlashCard = 'B',
        InternalFlashCard = 'E'
    }

    public enum ZPLDotsPerMillimeter
    {
        A = 'A',
        B = 'B'
    }

    public enum ZPLConfigurationUpdate
    {
        ReloadFactorySettings = 'F',
        ReloadFactoryNetworkSettings = 'N',
        RecallLastSavedSettings = 'R',
        SaveCurrentSettings = 'S'
    }

    public enum ZPLRibbonTension
    {
        Low = 'L',
        Medium = 'M',
        High = 'H'
    }

    public enum ZPLDateTimeFormat
    {
        DisplayVersionNumber = 0,
        MMDDYY24Hour = 1,
        MMDDYY12Hour = 2,
        DDMMYY24Hour = 3,
        DDMMYY12Hour = 4
    }

    public enum ZPLLanguage
    {
        English = 1,
        Spanish = 2,
        French = 3,
        German = 4,
        Italian = 5,
        Norwegian = 6,
        Portuguese = 7,
        Swedish = 8,
        Danish = 9,
        Spanish2 = 10,
        Dutch = 11,
        Finnish = 12,
        Japanese = 13,
        Korean = 14,
        SimplifiedChinese = 15,
        TraditionalChinese = 16,
        Russian = 17,
        Polish = 18,
        Czech = 19,
        Romanian = 20
    }

    public enum ZPLPrintMode
    {
        TearOff = 'T',
        PeelOff = 'P',
        Rewind = 'R',
        Applicator = 'A',
        Cutter = 'C',
        DelayedCutter = 'D',
        RFID = 'F',
        Kiosk = 'K'
    }

    public enum ZPLMediaTracking
    {
        ContinuousMedia = 'N',
        NonContinuousMediaWebSensing = 'Y',
        NonContinuousMediaMarkSensing = 'M',
        AutoDetectDuringCalibration = 'A',
        ContinuousMediaVariableLength = 'V'
    }

    public enum ZPLModeProtection
    {
        DisableDarknessMode = 'D',
        DisablePositionMode = 'P',
        DisableCalibrationMode = 'C',
        EnableAllModes = 'E',
        DisableAllModeSaves = 'S',
        DisablePause = 'W',
        DisableFeed = 'F',
        DisableCancel = 'X',
        DisableMenuChanges = 'M'
    }

    public enum ZPLMediaType
    {
        ThermalTransferMedia = 'T',
        DirectTransferMedia = 'D'
    }

    public enum ZPLNetworkType
    {
        ExternalWired = 1,
        InternalWired = 2,
        Wireless = 3
    }
    public enum ZPLIPResolution
    {
        All = 'A',
        BOOTP = 'B',
        DHCPandBOOTP = 'C',
        DHCP = 'D',
        GleaningOnly = 'G',
        RARP = 'R',
        Permanent = 'P'
    }

    public enum ZPLPrintSpeed
    {
        OneIPS = 1,
        TwoIPS = 2,
        ThreeIPS = 3,
        FourIPS = 4,
        FiveIPS = 5,
        SixIPS = 6,
        SevenIPS = 7,
        EightIPS = 8,
        NineIPS = 9,
        TenIPS = 10,
        ElevenIPS = 11,
        TwelveIPS = 12,
        ThirteenIPS = 13,
        FourteenIPS = 14
    }

    public enum ZPLSlewSpeed
    {
        TwoIPS = 2,
        ThreeIPS = 3,
        FourIPS = 4,
        FiveIPS = 5,
        SixIPS = 6,
        SevenIPS = 7,
        EightIPS = 8,
        NineIPS = 9,
        TenIPS = 10,
        ElevenIPS = 11,
        TwelveIPS = 12,
        ThirteenIPS = 13,
        FourteenIPS = 14
    }

    public enum ZPLBackfeedSpeed
    {
        TwoIPS = 2,
        ThreeIPS = 3,
        FourIPS = 4,
        FiveIPS = 5,
        SixIPS = 6,
        SevenIPS = 7,
        EightIPS = 8,
        NineIPS = 9,
        TenIPS = 10,
        ElevenIPS = 11,
        TwelveIPS = 12,
        ThirteenIPS = 13,
        FourteenIPS = 14
    }

    public enum ZPLTimeFormat
    {
        AM = 'A',
        PM = 'P',
        Military = 'M'
    }

    public enum ZPLVersion
    {
        ZPL1 = 1,
        ZPL2 = 2
    }

    public static class ZPLQuery
    {
        public const string PrinterStatus = "ES";
        public const string InternalWiredPrintServerAddress = "HA";
        public const string PrintheadTestSummary = "JT";
        public const string MaintenanceAlertSettings = "MA";
        public const string MaintenanceInformation = "MI";
        public const string Odometer = "OD";
        public const string PrintheadLifeHistory = "PH";
        public const string PrinterPlugAndPlayString = "PP";
        public const string PrinterSerialNumber = "SN";
        public const string PrinterUSBIDBCDInfo = "UI";
    }

    public enum ZPLLocation
    {
        Ram = 'R',
        Flash = 'F'
    }
}