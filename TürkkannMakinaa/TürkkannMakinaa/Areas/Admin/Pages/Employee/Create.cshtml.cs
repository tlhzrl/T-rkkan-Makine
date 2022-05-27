using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Page.Employee
{
 [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public CreateModel(ApplicationDbContext applicationDbContext)
        {
            db = applicationDbContext;
        }
        [BindProperty] 
        public TürkkannMakinaa.Entities.Employee Employee { get; set; }
        public void OnGet()
        {
        }

        public void OnPostCreate()
        {
            db.Employee.Add(Employee);

            int result = db.SaveChanges();

            if (result >0 )
            {
                ViewData["Message"] = "Müşteri kayıt tamamlandı";
            }
            else
            {
                ViewData["Message"] = "Tekrar deneyiniz";
            }
        }
    }
}
