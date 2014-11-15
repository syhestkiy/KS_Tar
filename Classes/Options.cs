namespace KS_Tar.Classes
{
    public class Options
    {
        public static int[] MemoryLimitsArray = { 1, 2, 3, 4, 5, 10, 20, 30, 40, 50, 100, 200, 500 };
        public static int[] TimeIntervalsArray = {1, 2, 3, 4, 5, 10, 20, 30, 40, 50, 60};

        public string FromEmail { get; set; }
        public string FromEmailPassword { get; set; }
        public string EmailTo { get; set; }
        public string EmailBody { get; set; }
        public string EmailSubject { get; set; }
        public bool OptionExist { get; set; }
    }
}
