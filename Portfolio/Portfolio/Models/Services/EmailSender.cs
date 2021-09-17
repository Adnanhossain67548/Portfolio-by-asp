using Microsoft.Extensions.Configuration;
using Portfolio.Models.Interface;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string name, string message)
        {
            SendGridClient client = new SendGridClient(_configuration["SendGrid-Key"]);
            SendGridMessage msg = new SendGridMessage();

            //First param is email and second is email
            msg.SetFrom(email, name);
            msg.AddTo("jinwoov@gmail.com");
            msg.SetSubject("This is from portfolio");
            msg.AddContent(MimeType.Html, message);

            await client.SendEmailAsync(msg);
        }
    }
}
