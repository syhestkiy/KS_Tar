using System;
using System.IO;

namespace KS_Tar.LoggerService
{
    class Logger
    {
        private const string LoggerFileName = "LogInfo.info";

        private Logger()
        {
            if (!File.Exists(LoggerFileName))
            {
                File.Create(LoggerFileName);
            }
        }

        private static Logger _loggerInstance;

        public static Logger GetInstance()
        {
            return _loggerInstance ?? (_loggerInstance = new Logger());
        }

        public void Log(string message)
        {
            var logMessage =
                string.Format(DateTime.Now.Date.ToShortDateString() + " - " + DateTime.Now.ToLongTimeString() +" "+ message);
            //var reader = new StreamReader(LoggerFileName);
            //reader.ReadToEnd();
            
            using (StreamWriter logFile=File.AppendText(LoggerFileName))
            {
                logFile.WriteLine(logMessage);
                logFile.Dispose();
            }
        }
    }
}
