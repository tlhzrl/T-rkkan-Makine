using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa
{
    public class ProductDetailModel : PageModel
    {
        private readonly ApplicationDbContext db;

        public ProductDetailModel(ApplicationDbContext applicationDb)
        {
            db = applicationDb;
        }

        public Product Product { get; set; }
        public int Quantity { get; set; } = 1;
        public string SelectedProductId { get; set; }

        public void OnGet(string id)
        {
            Product = db.Products.Include(x => x.Photos).Include(x => x.Rates).FirstOrDefault(x => x.Id == id);
        }
    }
}