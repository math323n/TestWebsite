using System;
using System.Collections.Generic;

#nullable disable

namespace TestWebsite.Entities.Models
{
    public partial class ProductsAboveAveragePrice
    {
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
