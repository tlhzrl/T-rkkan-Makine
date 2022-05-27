using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TürkkannMakinaa.Services.Upload
{
    public class Base64FileUploader : IFileUploader
    {
        public FileUploadResult Upload(IFormFile formFile)
        {
            FileUploadResult fileUploadResult = new FileUploadResult();
            fileUploadResult.FileResult = FileResult.Error;
            fileUploadResult.Base64 = "";

            if (formFile != null)
            {
                byte[] bytes;
                using (var memoryStream = new MemoryStream())
                {
                    formFile.CopyTo(memoryStream);
                    bytes = memoryStream.ToArray();
                }

                try
                {
                    string base64 = Convert.ToBase64String(bytes);
                    fileUploadResult.Base64 = base64;
                    fileUploadResult.OriginalName = System.IO.Path.GetFileName(formFile.FileName);
                    fileUploadResult.FileResult = FileResult.Succeded;
                    fileUploadResult.Message = "Base64 başarılı bir şekilde oluştu";
                }
                catch (Exception)
                {

                    fileUploadResult.Message = "Base64 çevirirken hata oluştu";
                }

            }
            
            return fileUploadResult;
        }
    }
}
