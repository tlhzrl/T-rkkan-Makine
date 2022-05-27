using System;

namespace TürkkannMakinaa.Entities
{
    public class ProductPhoto
    {
        public int Id { get; set; }
        public string OrginalFileName { get; set; }
        public string FileUrl { get; set; }
        public string ProductID { get; set; }
        public Product Product { get; set; }
    }
}