using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Services.Upload;

namespace TürkkannMakinaa.Services
{
    public class FileSystemFileUploader : IFileUploader
    {
        private readonly string _filePath;

        public FileSystemFileUploader(string filePath)
        {
            _filePath = filePath;
        }

        public FileSystemFileUploader()
        {
            _filePath = "Images";
        }

        public FileUploadResult Upload(IFormFile formFile)
        {
            FileUploadResult fileUploadResult = new FileUploadResult();
            fileUploadResult.FileResult = FileResult.Error;
            fileUploadResult.Message = "Dosya yükleme sırasında bir hata oluştu";

            if (formFile.Length > 0)
            {
                var filename = System.IO.Path.GetFileName(formFile.FileName);
                var file_extention = System.IO.Path.GetExtension(formFile.FileName);
                var unique_file_name = Guid.NewGuid().ToString() + file_extention;
               
                fileUploadResult.OriginalName = filename;

                var physicalPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), _filePath, unique_file_name);

                

                if (System.IO.File.Exists(physicalPath))
                {
                    fileUploadResult.Message = "Böyle bir dosya mevcut!";
                }
                else
                {
                    fileUploadResult.FileUrl = $"/site/images/{unique_file_name}";
                    fileUploadResult.Base64 = null;

                    using (var stream = new FileStream(physicalPath, FileMode.Create))
                    {
                        try
                        {
                            formFile.CopyTo(stream);
                            fileUploadResult.FileResult = FileResult.Succeded;
                            fileUploadResult.Message = "Dosya başarılı bir şekilde yüklendi";
                        }
                        catch (Exception)
                        {

                            fileUploadResult.FileResult = FileResult.Error;
                        }
                    }
                }
            }

            return fileUploadResult;
        }
    }
}
