﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppModels.ViewModels
{
    public class ProductVM
    {
        public Product? Product { get; set; }
        public IEnumerable<Product> products { get; set; } = new List<Product>();
    }
}
