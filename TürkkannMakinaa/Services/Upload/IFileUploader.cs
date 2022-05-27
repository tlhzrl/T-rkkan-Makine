using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TürkkannMakinaa.Services.Upload
{
    public enum FileResult
    {
        Succeded = 1,
        Error = 2
    }

    public class FileUploadResult
    {
        public string FileUrl { get; set; }
        public string OriginalName { get; set; }
        public string Base64 { get; set; }
        public FileResult FileResult { get; set; }

        public string Message { get; set; }
    }



    public interface IFileUploader
    {
        FileUploadResult Upload(IFormFile formFile);
    }
}
