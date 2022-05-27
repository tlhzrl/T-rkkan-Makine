using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TürkkannMakinaa.Entities;

namespace TürkkannMakinaa.Model
{
    public class ProductByCategoryVM
    {
        public string CategoryName { get; set; }
        public int ProductCounts { get; set; }
        public List<Product> Products{ get; set; }
    }
}
