using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IActionResult DeletePhoto(int PhotoId)
        {
            var photo = _applicationDbContext.ProductPhotos.FirstOrDefault(x => x.Id == PhotoId);

            if (photo != null)
            {
                _applicationDbContext.Remove(photo);
                _applicationDbContext.SaveChanges();
            }

            return Ok();
        }
    }
}