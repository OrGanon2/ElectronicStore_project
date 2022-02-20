using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Hyperion_Store.Logic
{
    public class EmailMethods
    {
        public void SendCodeThroughEmail(string? emailAdress, string subject, string body)
        {

            string from = "organon222@gmail.com";
            if (emailAdress != null)
            {


                MailMessage mail = new MailMessage(from, emailAdress);
                using (SmtpClient smtpclient = new SmtpClient())
                {
                    smtpclient.Port = 587;
                    smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpclient.UseDefaultCredentials = false;
                    smtpclient.Host = "smtp.gmail.com";
                    smtpclient.UseDefaultCredentials = false;
                    mail.Subject = subject;
                    mail.Body = body + "\n";
                    smtpclient.EnableSsl = true;
                    smtpclient.Credentials = new System.Net.NetworkCredential()

                    {
                        UserName = "organon222@Gmail.com",
                        Password = "Gray65432123"

                    };
                    smtpclient.Send(mail);
                }


            }
        }
    }
}
