using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TürkkannMakinaa.Entities;
using TürkkannMakinaa.Services.Upload;

namespace TürkkannMakinaa.Areas.Admin.Pages.Products
{
    public class ListModel : PageModel
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IFileUploader _fileUploader;

        public List<Product> ProductList { get; set; }

        [BindProperty]
        public List<IFormFile> files { get; set; }

        [BindProperty]
        public string SelectedProductId { get; set; }

        public ListModel(ApplicationDbContext applicationDbContext, IFileUploader fileUploader)
        {
            _applicationDbContext = applicationDbContext;
            _fileUploader = fileUploader;
        }
        public void OnGet()
        {
            ProductList = _applicationDbContext.Products.Include(x => x.Categories).ToList();
        }

        public IActionResult OnPostAddPhotos()
        {
            foreach (IFormFile file in files)
            {
                var result = _fileUploader.Upload(file);

                if (result.FileResult == Services.Upload.FileResult.Succeded)
                {
                    var photo = new ProductPhoto
                    {
                        OrginalFileName = result.OriginalName,
                        ProductID = this.SelectedProductId,
                        FileUrl = result.FileUrl
                    };

                    _applicationDbContext.ProductPhotos.Add(photo);
                }
            }

            int dbresult = _applicationDbContext.SaveChanges();

            if (dbresult > 0)
            {
                TempData["Message"] = "Fotograflar başarı ile yüklendi.";
            }

            return RedirectToPage("List");
        }
    }
}
