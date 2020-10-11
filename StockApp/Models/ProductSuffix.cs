﻿using System.Collections.Generic;

namespace StockApp.Models
{
    public class ProductSuffix
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //navigation property
        //one-to-many
        public virtual List<Product> product { get; set; }
    }
}
