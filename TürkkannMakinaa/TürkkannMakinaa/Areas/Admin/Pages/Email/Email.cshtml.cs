using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Pages.Email
{

    public class MailIM
    {
        [Required(ErrorMessage = "E-posta boş geçilemez")]
        public string[] Mails { get; set; }
        
        [Required(ErrorMessage = "Lütfen ana başlık giriniz")]
        public string Subject { get; set; }
        
        [Required(ErrorMessage = "Lütfen lütfen metni giriniz")]
        public string Body { get; set; }
    }
[Authorize]
    public class EmailModel : PageModel
    {
        [BindProperty]
        public MailIM MailModel { get; set; }
        public List<TürkkannMakinaa.Entities.Employee> Employee { get; set; }


        private readonly ApplicationDbContext db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;


        public EmailModel(
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender,
            ApplicationDbContext dbContext

            )
        {
            db = dbContext; ;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        public void OnGet()

        {
            Employee = db.Employee.ToList();
        }

        public async Task OnPostSendEmail()
        {

            var email = string.Join(";", MailModel.Mails);

            Employee = db.Employee.ToList();

            await _emailSender.SendEmailAsync(email, MailModel.Subject, MailModel.Body);



        }

    }
}
