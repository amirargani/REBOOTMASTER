using System.Net;
using System.Text;
using System.Net.Mail;

namespace REBOOTMASTER_Free.Utility
{
    internal class MailService
    {
        public static MailMessage GetMailMessageWithTemplate(string from, string to, string name, string log, string subject, string fromDisplayName, string templatePath)
        {
            StreamReader streamReader = new StreamReader(templatePath);
            DateTime now = DateTime.Now;
            string body = streamReader.ReadToEnd().Replace("[Name]", name).Replace("[DateTime]", now.ToString())
                .Replace("[Log]", log);
            return GetMailMessage(from, to, body, subject, isBodyHtml: true, fromDisplayName);
        }

        public static MailMessage GetMailMessage(string from, string to, string body, string subject, bool isBodyHtml = false, string fromDisplayName = null!)
        {
            return new MailMessage
            {
                From = new MailAddress(from, fromDisplayName ?? from, Encoding.UTF8),
                Body = body,
                Subject = subject,
                IsBodyHtml = isBodyHtml,
                BodyEncoding = Encoding.UTF8,
                To = { to }
            };
        }

        public static SmtpClient GetSmtpClient(string username, string password, string smtpClient, int smtpPort, bool isEncrypted = true)
        {
            return new SmtpClient(smtpClient, smtpPort)
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(username, password),
                EnableSsl = isEncrypted,
            };
        }
    }
}