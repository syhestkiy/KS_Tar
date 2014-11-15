using System.IO;
using System.Text.RegularExpressions;
using KS_Tar.Classes;

namespace KS_Tar.OptionRepository
{
    class OptionRepository : IOptionRepository
    {
        public void SaveOption(string emailTo, string fromEmail, string fromEmailPass, string emailSubject, string emailBody)
        {
            if (!File.Exists("setting.ini"))
            {
                File.Create("setting.ini");
            }
            var options =
                string.Format("{0}\n{1}\n{2}\n{3}\n{4}",
                    emailTo, fromEmail, fromEmailPass, emailSubject, emailBody);
            using (var outfile = new StreamWriter("setting.ini"))
            {
                outfile.Write(string.Empty);
                outfile.Write(options);
                outfile.Dispose();
            }
        }

        public Options GetOption()
        {
            string emailTo = string.Empty, fromEmail = string.Empty, fromEmailPass = string.Empty, emailSubject = string.Empty, emailBody = string.Empty;
            bool optionExist = false;
            if (File.Exists("setting.ini"))
            {
                var sr = new StreamReader("setting.ini");
                emailTo = sr.ReadLine();
                fromEmail = sr.ReadLine();
                fromEmailPass = sr.ReadLine();
                emailSubject = sr.ReadLine();
                emailBody = sr.ReadToEnd();
                if (emailSubject != null && (fromEmailPass != null && (fromEmail != null && (emailTo != null && (emailTo.Length != null && fromEmail.Length != null && fromEmailPass.Length != null && emailBody.Length != null && emailSubject.Length != null)))))
                    optionExist = true;
                else
                    optionExist = false;
                sr.Dispose();
            }
            else
            {
                emailTo = "example@mail.com";
                fromEmail = "example@gmail.com";
                fromEmailPass = "password";
                emailSubject = "default";
                emailBody = "message";
                optionExist = false;
            }
            return new Options
            {
                EmailTo = emailTo,
                FromEmail = fromEmail,
                FromEmailPassword = fromEmailPass,
                EmailSubject = emailSubject,
                EmailBody = emailBody,
                OptionExist = optionExist
            };
        }
    }
}
