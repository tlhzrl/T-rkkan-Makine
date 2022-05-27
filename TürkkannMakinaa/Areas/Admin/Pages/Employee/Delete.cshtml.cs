using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Pages.Employee
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public DeleteModel(ApplicationDbContext applicationDb)
        {
            db = applicationDb;
        }

        public int Id { get; set; }

        public void OnGet(int id)
        {
            this.Id = id;
        }

        public RedirectToPageResult OnPostDelete(int id)
        {
            var data = db.Employee.Find(id);
            db.Remove(data);
            db.SaveChanges();

            return RedirectToPage("List");
        }
    }
}
