using System.Windows.Forms;

namespace KS_Tar.Classes
{
    class EmailSender
    {
        public static void SendMail(string email)
        {
            MessageBox.Show(@"Email was sended to  mr. " + email);
        }
    }
}
