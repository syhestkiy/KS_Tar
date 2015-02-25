using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using KS_Tar.LoggerService;

namespace KS_Tar.Classes
{
    class EmailSender
    {
        public static void SendMail(string emailTo,string emailFrom,string emaiFromPass,string emailSubject, string emailBody)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 100000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(
                  emailFrom, emaiFromPass);
                MailMessage msg = new MailMessage();
                msg.To.Add(emailTo);
                msg.From = new MailAddress(emailFrom);
                msg.Subject = emailSubject;
                msg.Body = emailBody;
                client.Send(msg);
                MessageBox.Show("Successfully Sent Message.");
                Logger.GetInstance().Log("Повідомлення з темою "+emailSubject+" було успішно відправлено до "+emailTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Logger.GetInstance().Log("Помилка відправлення повідомлення: "+ex.Message);
            }
        }
    }
}
