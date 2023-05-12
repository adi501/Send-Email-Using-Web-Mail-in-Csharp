using System;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
//using System.Web.Mail;
using System.Data;
using System.IO;

namespace Send_email_using_web_mail_in_csharp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("webmail.allinonesofttech.com");
                mail.From = new MailAddress("info@allinonesofttech.com");
                mail.To.Add("jc.adi101@gmail.com");
                mail.CC.Add("jc.adi101@gmail.com");
                mail.Subject = "test email from c# code 1";
                mail.IsBodyHtml = true;
                mail.Body = "It's Body";
                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("info@allinonesofttech.com", "your password");
                SmtpServer.EnableSsl = false;
                SmtpServer.Send(mail);
                SmtpServer.Timeout = 20000;
                SmtpServer.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                Console.WriteLine("mail Send");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Console.WriteLine("Hello World!");
        }
    }
}






