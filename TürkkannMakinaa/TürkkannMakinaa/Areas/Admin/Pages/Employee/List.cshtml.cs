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
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public List<TürkkannMakinaa.Entities.Employee> Employee { get; set; }

        public ListModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }
        public void OnGet()
        {
            Employee = db.Employee.ToList();
        }
    }
}
