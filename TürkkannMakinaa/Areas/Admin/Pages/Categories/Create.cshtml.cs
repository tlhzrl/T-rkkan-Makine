using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Page.Categories
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public CreateModel(ApplicationDbContext applicationDb)
        {
            db = applicationDb;
        }

        [BindProperty]
        public Category Category { get; set; }

        public void OnGet()
        {

        }

        public void OnPostCreate()
        {
            db.Category.Add(Category);

            int result = db.SaveChanges();

            if (result > 0)
                ViewData["Message"] = "Kayıt başarılı";
            else
                ViewData["Message"] = "Tekrar deneyiniz";
        }
    }
}
