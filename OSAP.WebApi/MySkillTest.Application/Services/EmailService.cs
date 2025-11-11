using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MySkillTest.Application.Abstractions.IEmailService;
using MySkillTest.Application.Utils;
using OSAP.WebApi.Models;
namespace MySkillTest.Application.Services
{


    public class EmailService : IEmailService
    {
        private readonly EmailSettings emailSettings;

        public EmailService(IOptions<EmailSettings> options)
        {
            emailSettings = options.Value ?? throw new ArgumentNullException(nameof(options));
        }

        public async Task<bool> SendEmailAsync(string subject, string body, string fromEmail, string toEmails)
        {
            if (!emailSettings.AllowSendEmails)
                return true; // skip sending in non-prod environments

            var message = CreateEmailMessage(subject, body, fromEmail, toEmails);
            return await SendAsync(message);
        }

        public async Task<bool> SendEmailWithCCAsync(string subject, string body, string fromEmail, string toEmails, List<string> ccEmails)
        {
            if (!emailSettings.AllowSendEmails)
                return true;

            var message = CreateEmailMessage(subject, body, fromEmail, toEmails);

            if (ccEmails != null && ccEmails.Any())
            {
                foreach (var cc in ccEmails)
                {
                    message.Cc.Add(MailboxAddress.Parse(cc));
                }
            }

            return await SendAsync(message);
        }

        public async Task<bool> SendNewCompanyRegisteredEmailAsync(RegisteredCompanyModel model)
        {
            if (!emailSettings.AllowSendEmails)
                return true;

            string subject = $"{emailSettings.AppName} Registration";

            string body = $@"
                Hi Abid,<br/><br/>
                New Company has been registered. Please find the details below,<br/><br/>
                <strong>Email Address:</strong> {model.EmailAddress}<br/>
                <strong>Company Name:</strong> {model.CompanyName}<br/>
                <strong>Mobile Number:</strong> {model.MobileNumber}<br/><br/>
                Have a nice day...<br/><br/>
                Thanks,<br/>
                Team {emailSettings.AppName}";

            string fromMail = emailSettings.FromMail ?? emailSettings.From;
            string toMail = emailSettings.To;

            var res = await SendEmailAsync(subject, body, fromMail, toMail);
            return res;
        }
        public async Task<bool> SendUserCredentialsEmailAsync(string email, string name, string password)
        {
            string portalUrl = emailSettings.PortalURL;
            string subject = $"{emailSettings.AppName} Registration";

            string body = $@"
            Hi {name},<br/><br/>
            Please find your UserName and Password below:<br/><br/>
            <strong>User Name:</strong> {email}<br/>
            <strong>Password:</strong> {password}<br/>
            Please <a href='{portalUrl}'>Click Here</a> to login.<br/><br/>
            Have a nice day...<br/><br/>
            Thanks,<br/>
            Team {emailSettings.AppName}";

            string fromEmail = emailSettings.FromMail ?? emailSettings.From;
            return await SendEmailAsync(subject, body, fromEmail, email);
        }


        public async Task<bool> SendUserExistsNotificationAsync(string email, string name)
        {
            if (!emailSettings.AllowSendEmails)
                return true; // skip sending in non-prod environments

            string portalUrl = emailSettings.PortalURL;
            string subject = $"{emailSettings.AppName} - Account Already Exists";

            string body = $@"
                Hi {name},<br/><br/>
                An account with your email <strong>{email}</strong> already exists in our system.<br/><br/>
                If you forgot your password, please <a href='{portalUrl}/reset-password'>click here</a> to reset it.<br/><br/>
                If you did not attempt to register again, you can safely ignore this email.<br/><br/>
                Thanks,<br/>
                Team {emailSettings.AppName}";

            string fromEmail = emailSettings.FromMail ?? emailSettings.From;
            return await SendEmailAsync(subject, body, fromEmail, email);
        }

        private MimeMessage CreateEmailMessage(string subject, string body, string fromEmail, string toEmails)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(fromEmail ?? emailSettings.From));
            email.To.Add(MailboxAddress.Parse(toEmails));
            email.Subject = subject;

            var builder = new BodyBuilder
            {
                HtmlBody = body
            };

            email.Body = builder.ToMessageBody();
            return email;
        }

        private async Task<bool> SendAsync(MimeMessage message)
        {
            try
            {
                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                await smtp.ConnectAsync(emailSettings.SmtpHost, emailSettings.SmtpPort, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(emailSettings.Username, emailSettings.Password);
                await smtp.SendAsync(message);
                await smtp.DisconnectAsync(true);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Email sending failed: {ex.Message}");
                return false;
            }
        }
    }

}
