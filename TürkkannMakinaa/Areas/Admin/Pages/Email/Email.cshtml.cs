using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Pages.Email
{
    public class MailIM
    {
        public string Mails { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
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


        //    await _emailSender.SendEmailAsync(email, emailMessage.Subject, emailMessage.Body);

        }

    }
}
