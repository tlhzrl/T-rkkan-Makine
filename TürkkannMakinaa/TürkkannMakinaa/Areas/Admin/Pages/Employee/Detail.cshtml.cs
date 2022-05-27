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
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public TürkkannMakinaa.Entities.Employee Employee{ get; set; }

        public DetailModel(ApplicationDbContext applicationDb)
        {
            db = applicationDb;
        }

        public void OnGet(int id)
        {
            Employee = db.Employee.Find(id);
        }
    }
}
