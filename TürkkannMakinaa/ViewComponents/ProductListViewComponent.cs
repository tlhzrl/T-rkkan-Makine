using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Entities;
using TürkkannMakinaa.Model;

namespace TürkkannMakinaa.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;

        public ProductListViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int? categoryId)
        {
            var products = categoryId == 00 ? _db.Products.OrderByDescending(x => x.Stock).Include(x => x.Categories).Take(10).ToList() : _db.Products.OrderByDescending(x => x.Stock).Include(x => x.Categories).Where(x => x.CategoryID == categoryId).Take(10).ToList();


            if (products.Count > 0)
            {
                var model = new ProductByCategoryVM
                {
                    CategoryName = categoryId == null ? "" : products.FirstOrDefault().Categories.CategoryName,
                    Products = products,
                    ProductCounts = products.Count()
                };

                return View(model);
            }
            else
            {
                var model = new ProductByCategoryVM
                {
                    CategoryName = "",
                    Products = new List<Product>(),
                    ProductCounts = products.Count()
                };

                return View(model);
            }
        }
    }
}
