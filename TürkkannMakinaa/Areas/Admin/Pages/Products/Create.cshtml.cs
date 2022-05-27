using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TürkkannMakinaa.Entities;
using TürkkannMakinaa.Services;
using TürkkannMakinaa.Services.Upload;
using TürkkannMakinaa.Validators;
using SelectListItem = Microsoft.AspNetCore.Mvc.Rendering.SelectListItem;

namespace TürkkannMakinaa.Areas.Admin.Page.Products
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext context;
        private readonly ProductCreateValidator _createValidator;

        public CreateModel(ApplicationDbContext applicationDbContext, ProductCreateValidator createValidator)
        {
            context = applicationDbContext;
            _createValidator = createValidator;
        }

        [BindProperty]
        public Product Products { get; set; } = new Product();
       
        [BindProperty]
        public IFormFile File { get; set; }

        public List<SelectListItem> CategoryList
        {
            get
            {
                var CategoryList = new List<SelectListItem>();
                CategoryList.Add(new SelectListItem { Text = "Seçim yapınız", Value = "" });

                var selected = context.Category.Select(a => new SelectListItem
                {

                    Text = a.CategoryName,
                    Value = a.Id.ToString()
                }
                ).ToList();

                CategoryList.AddRange(selected.ToArray());
                return CategoryList;
            }
        }

        public void OnGet()
        {
            ViewData["Categories"] = CategoryList;
            Products.MainPhoto = "";
        }

        public void OnPostCreate()
        {
            CategoryList.Add(new SelectListItem { Text = "Seçim yapınız", Value = null });
            ViewData["Categories"] = CategoryList;


            //var uploader = new FileSystemFileUploader("Images");
            var uploader = new Base64FileUploader();
            //var result = uploader.Upload(File);

            var productService = new ProductService(uploader, context, _createValidator);

            var serviceResult = productService.CreateProduct(Products , File);

            //if (Products.MainPhoto == null)
            //{
            //    ModelState.AddModelError("MainPhoto", "Resim seçiniz");
            //}
            
            if (serviceResult.Succeded)
            {
                ViewData["Message"] = serviceResult.Message;
                ViewData["Succeded"] = serviceResult.Succeded;
            }
            else
            {
                ViewData["Message"] = String.Join(",", serviceResult.ErorList.ToArray());
            }
        }
    }
}
