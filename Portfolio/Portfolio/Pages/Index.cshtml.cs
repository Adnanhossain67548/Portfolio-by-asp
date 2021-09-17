using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Portfolio.Models.Interface;

namespace Portfolio.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmailSender _email;

        public IndexModel(IEmailSender emailSender)
        {
            _email = emailSender;
        }
        [BindProperty]
        public EmailInfo EmailInfo { get; set; }

        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            await _email.SendEmailAsync(EmailInfo.Email, EmailInfo.Name, EmailInfo.Message);
        }
    }

    public class EmailInfo
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
