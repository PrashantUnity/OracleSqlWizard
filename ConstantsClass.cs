namespace OracleSqlWizard
{
    internal static class ConstantsClass
    {
        public static string ExcelFilePath { get; set; }
        public static string LogText { get; set; }
        public static string SaveFileLocation{ get; set; }
        public static int ReadingLine { get; set; }
        public static int TotalLine { get; set; }
        public static bool IsCancelled { get; set; } = false;

        public static string JobsWithFailedStatus { get; set; } = "";
        public static bool EnableExecuteButton { get; internal set; }

        public static int IndexOfUsedId           { get; set; } = 0;
        public static int IndexOfPassword         { get; set; } = 1;
        public static int IndexOfLocalHost        { get; set; } = 2;
        public static int IndexOfPort             { get; set; } = 3;
        public static int IndexOfDataBaseName     { get; set; } = 4;
        public static int IndexOfOwnerName       { get; set; } = 5;
        public static int IndexOfObjectType       { get; set; } = 6;
        public static int IndexOfObjectName       { get; set; } = 6;
    }
}
