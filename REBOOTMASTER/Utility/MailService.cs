using System.Net;
using System.Text;
using System.Net.Mail;

namespace REBOOTMASTER.Utility
{
    public class MailService
    {
        // Mail: Get Mail Message With Template
        public static MailMessage GetMailMessageWithTemplate(string from, string to, string name, string log, string subject, string fromDisplayName, string templatePath)
        {
            StreamReader streamReader = new StreamReader(templatePath); // Template file path
            DateTime now = DateTime.Now; // Current date and time
            string body = streamReader.ReadToEnd().Replace("[Name]", name).Replace("[DateTime]", now.ToString()) // Replace placeholders
                .Replace("[Log]", log);
            return GetMailMessage(from, to, body, subject, isBodyHtml: true, fromDisplayName); // Create MailMessage
        }

        // Mail: Get Mail Message
        public static MailMessage GetMailMessage(string from, string to, string body, string subject, bool isBodyHtml = false, string fromDisplayName = null!)
        {
            return new MailMessage // Create MailMessage
            {
                From = new MailAddress(from, fromDisplayName ?? from, Encoding.UTF8), // From address with optional display name
                Body = body, // Email body
                Subject = subject, // Email subject
                IsBodyHtml = isBodyHtml, // Is body HTML
                BodyEncoding = Encoding.UTF8, // Body encoding
                To = { to } // To address
            };
        }

        // Mail: Get SMTP Client
        public static SmtpClient GetSmtpClient(string username, string password, string smtpClient, int smtpPort, bool isEncrypted = true)
        {
            return new SmtpClient(smtpClient, smtpPort) // Create SmtpClient
            {
                UseDefaultCredentials = false, // Do not use default credentials
                DeliveryMethod = SmtpDeliveryMethod.Network, // Use network delivery method
                Credentials = new NetworkCredential(username, password), // Set credentials
                EnableSsl = isEncrypted, // Enable SSL if specified
            };
        }
    }
}