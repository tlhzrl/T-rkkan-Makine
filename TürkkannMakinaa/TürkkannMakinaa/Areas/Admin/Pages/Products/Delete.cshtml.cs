using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Pages.Products
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public DeleteModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public string Id { get; set; }

        public void OnGet(string id)
        {
            this.Id = id;
        }


        public RedirectToPageResult OnPostDelete(string id)
        {
            var data = db.Products.FirstOrDefault(x => x.Id == id);
            db.Remove(data);
            db.SaveChanges();

            return RedirectToPage("List");
        }

    }
}
