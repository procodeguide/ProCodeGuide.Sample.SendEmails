using ProCodeGuide.Sample.SendEmails.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SendEmails.Services
{
    public interface IEmailService
    {
        bool SendEmail(EmailData emailData);
        bool SendEmailWithAttachment(EmailDataWithAttachment emailData);
        bool SendUserWelcomeEmail(UserData userData);
    }
}
