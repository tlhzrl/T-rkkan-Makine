using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Areas.Admin.Page.Categories
{
    public class DetailModel : PageModel
    {
        private readonly ApplicationDbContext db;
        
        public Category Category { get; set; }

        public DetailModel(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void OnGet(int id)
        {
            Category = db.Category.Find(id);
        }
    }
}
