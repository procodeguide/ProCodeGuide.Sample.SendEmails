using Microsoft.AspNetCore.Mvc;
using ProCodeGuide.Sample.SendEmails.Models;
using ProCodeGuide.Sample.SendEmails.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProCodeGuide.Sample.SendEmails.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        IEmailService _emailService = null;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public bool SendEmail(EmailData emailData)
        {
            return _emailService.SendEmail(emailData);
        }

        [Route("SendEmailWithAttachment")]
        [HttpPost]
        public bool SendEmailWithAttachment([FromForm]EmailDataWithAttachment emailData)
        {
            return _emailService.SendEmailWithAttachment(emailData);
        }

        [Route("SendUserWelcomeEmail")]
        [HttpPost]
        public bool SendUserWelcomeEmail([FromForm]UserData userData)
        {
            return _emailService.SendUserWelcomeEmail(userData);
        }
    }
}
