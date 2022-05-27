using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Pages.Employee
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext db; 

        public EditModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }
        
        [BindProperty]
        public TürkkannMakinaa.Entities.Employee Employee { get; set; }

        public void OnGet(int id)
        {
            Employee = db.Employee.Find(id);
        }

        public void OnPostUpdate()
        {
            var data = db.Employee.Find(Employee.ID);
            data.CustomerName = Employee.CustomerName;
            data.CustomerSurname = Employee.CustomerSurname;
            data.CustomerEMail = Employee.CustomerEMail;
            data.CustomerAddress = Employee.CustomerAddress;
            data.PhoneNumber = Employee.PhoneNumber;

            int result = db.SaveChanges();

            if (result > 0)
                ViewData["Message"] = "Müşteri kayıdı başarılı bir şekilde güncellendi";
            else
                ViewData["Message"] = "Tekrar deneyiniz";
        }
    }
}
