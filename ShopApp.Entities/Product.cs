using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String ImageUrl { get; set; }
        public Decimal Price { get; set; }

        public List<ProductCategory> ProductCategorys { get; set; }


    }
}
