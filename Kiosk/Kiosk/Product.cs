using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPath { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductContent { get; set; }
        public int ProductRating { get; set; }
        public int CategoryId { get; set; }
    }
}
