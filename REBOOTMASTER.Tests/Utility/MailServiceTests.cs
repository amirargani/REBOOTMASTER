using System.Net.Mail;
using REBOOTMASTER.Utility;

namespace REBOOTMASTER.Tests.Utility
{
    public class MailServiceTests
    {
        [Fact]
        public void GetMailMessage_ReturnsCorrectMessage()
        {
            // Arrange
            string from = "sender@example.com";
            string to = "receiver@example.com";
            string body = "Test Body";
            string subject = "Test Subject";
            string disp = "Display Name";

            // Act
            MailMessage result = MailService.GetMailMessage(from, to, body, subject, true, disp);

            // Assert
            Assert.Equal(from, result.From!.Address);
            Assert.Equal(disp, result.From.DisplayName);
            Assert.Equal(subject, result.Subject);
            Assert.Equal(body, result.Body);
            Assert.True(result.IsBodyHtml);
            Assert.Contains(to, result.To.Select(t => t.Address));
        }

        [Fact]
        public void GetSmtpClient_ReturnsConfiguredClient()
        {
            // Arrange
            string user = "user";
            string pass = "pass";
            string host = "smtp.test.com";
            int port = 587;

            // Act
            SmtpClient client = MailService.GetSmtpClient(user, pass, host, port, true);

            // Assert
            Assert.Equal(host, client.Host);
            Assert.Equal(port, client.Port);
            Assert.True(client.EnableSsl);
        }
    }
}