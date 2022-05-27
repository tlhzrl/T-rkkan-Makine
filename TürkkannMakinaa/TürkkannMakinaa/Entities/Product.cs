using System.Collections.Generic;

namespace TürkkannMakinaa.Entities
{
    public class Product
    {
        public Product()
        {
            this.Id = System.Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public string MainPhoto { get; set; }
        public string Properties { get; set; }
        
        public List<ProductRate> Rates { get; set; }
        public List<ProductPhoto> Photos { get; set; }
        public Category Categories { get; set; }

        public string Currency { get; set; }
        public string OriginalName { get; set; }
        public int Stock { get; set; }


    }
}