﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public List<ProductCategory> ProductCategorys { get; set; }

        Console.WriteLine("i");
    }
}
