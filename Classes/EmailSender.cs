using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace KS_Tar.Classes
{
    class EmailSender
    {
        public static void SendMail(string email, string emailBody)
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
                  "ivan.syhestkiy@gmail.com", "fibonachi!!@#%*");
                MailMessage msg = new MailMessage();
                msg.To.Add(email);
                msg.From = new MailAddress("ivan.syhestkiy@gmail.com");
                msg.Subject = "memory is almost over";
                msg.Body = emailBody;
                client.Send(msg);
                MessageBox.Show("Successfully Sent Message.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
