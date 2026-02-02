using System.Net.Mail;
using System.Reflection;
using REBOOTMASTER.Config;

namespace REBOOTMASTER.Utility
{
    public class NotificationService
    {
        // Mail: Send Mail Message
        internal static void SendMailMessage(string name, string logMessage, string subject)
        {
            MailMessage mail = MailService.GetMailMessageWithTemplate(Security.GetString(ConfigReaderMail.SmtpUser), Security.GetString(ConfigReaderMail.Recipient), name, logMessage, subject, "REBOOTMASTER", GetTemplatePath());
            ConfigReaderMail.Smtp.Send(mail);
        }

        // Mail: Template Path
        internal static string GetTemplatePath()
        {
            int rnd = new Random().Next(1, 4);
            string? mailTemplatePath = rnd switch
            {
                1 => ConfigReaderMail.TemplatePath1,
                2 => ConfigReaderMail.TemplatePath2,
                3 => ConfigReaderMail.TemplatePath3,
                _ => ConfigReaderMail.TemplatePath1 // Default
            };
            string WorkDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? Environment.CurrentDirectory;
            return WorkDirectory + "\\" + mailTemplatePath;
        }

        // Settings: SMTP Valid
        internal static bool AreSMTPValuesValid()
        {
            return !string.IsNullOrEmpty(ConfigReaderMail.SmtpHost) &&
                   !string.IsNullOrEmpty(ConfigReaderMail.SmtpPort) &&
                   !string.IsNullOrEmpty(ConfigReaderMail.SmtpUser) &&
                   !string.IsNullOrEmpty(ConfigReaderMail.SmtpPassword) &&
                   !string.IsNullOrEmpty(ConfigReaderMail.Recipient);
        }

        // Exception
        internal static void GetException(Exception ex)
        {
            // Send a mail if the service status has stopped.
            SendMailMessage($"REBOOTMASTER Exception: {ex.Message}", "An error has occurred in the REBOOTMASTER, a part of the program. Please check the error. If the program does not function properly, restart it from the beginning. You can find more details about the error in the log file.", $"REBOOTMASTER - [.:!!ERROR!!:.]");

        }
    }
}