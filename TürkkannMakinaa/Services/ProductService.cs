using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Entities;
using TürkkannMakinaa.Services.Upload;
using TürkkannMakinaa.Validators;

namespace TürkkannMakinaa.Services
{
    public class ServiceResult
    {
        public string Message { get; set; }
        public bool Succeded { get; set; }
        public List<string> ErorList { get; set; } = new List<string>();
    }

    public class ProductService
    {
        private readonly IFileUploader _fileUploader;
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ProductCreateValidator _validator;

        public ProductService(IFileUploader fileUploader, ApplicationDbContext applicationDbContext, ProductCreateValidator validator)
        {
            _fileUploader = fileUploader;
            _applicationDbContext = applicationDbContext;
            _validator = validator;
        }

        public ServiceResult CreateProduct(Product product, IFormFile file)
        {
            var serviceResult = new ServiceResult();

            var uploadResult = _fileUploader.Upload(file);

            if (uploadResult.FileResult == FileResult.Succeded)
            {
                product.MainPhoto = uploadResult.Base64;
                product.OriginalName = uploadResult.OriginalName;

                var validationResult = _validator.Validate(product);

                if (validationResult.IsValid)
                {
                    _applicationDbContext.Add(product);
                    int result = _applicationDbContext.SaveChanges();

                    if (result >0)
                    {
                        serviceResult.Succeded = true;
                        serviceResult.Message = "Kayıt başarılı";
                    }
                    else
                    {
                        serviceResult.ErorList.Add("Kayıt işlemi gerçekleşemedi!");
                        serviceResult.Succeded = false;
                    }
                }
            }

            else
            {
                serviceResult.ErorList.Add(uploadResult.Message);
                serviceResult.Succeded = false;
            }

            return serviceResult;
        }
    }
}
