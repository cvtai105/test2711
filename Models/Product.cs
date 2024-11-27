using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace test2711.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}