using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSAP.WebApi.Models;

namespace MySkillTest.Application.Abstractions.IEmailService
{
    public interface IEmailService
    {
        Task<bool> SendEmailAsync(string subject, string body, string fromEmail, string toEmails);
        Task<bool> SendNewCompanyRegisteredEmailAsync(RegisteredCompanyModel model);
        Task<bool> SendEmailWithCCAsync(string subject, string body, string fromEmail, string toEmails, List<string> ccEmails);
        Task<bool> SendUserCredentialsEmailAsync(string email, string name, string password);
        Task<bool> SendUserExistsNotificationAsync(string email, string name);
        Task<bool> SendForgotPasswordEmail(string email, int resetCode);
    }

}
