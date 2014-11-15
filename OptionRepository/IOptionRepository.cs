using System.Security.Cryptography.X509Certificates;
using KS_Tar.Classes;

namespace KS_Tar.OptionRepository
{
    public interface IOptionRepository
    {
        void SaveOption(string emailTo, string fromEmail, string fromEmailPass, string emailSubject, string emailBody);
        Options GetOption();
    }
}
