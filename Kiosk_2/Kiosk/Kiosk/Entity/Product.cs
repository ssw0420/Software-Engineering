using CsvHelper.Configuration;
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
        public string ProductImgPath { get; set; }
        public string ProductCategory { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductContent { get; set; }
        public double ProductRating { get; set; }
        public int CategoryId { get; set; } // 외래 키
        public int UserId { get; set; } // 외래 키
    }
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap()
        {
            Map(m => m.ProductId).Name("productId");
            Map(m => m.ProductName).Name("productName");
            Map(m => m.ProductImgPath).Name("productImgPath");
            Map(m => m.ProductCategory).Name("productCategory");
            Map(m => m.ProductPrice).Name("productPrice");
            Map(m => m.ProductContent).Name("productContent");
            Map(m => m.ProductRating).Name("productRating");
            Map(m => m.CategoryId).Name("categoryId");
            Map(m => m.UserId).Name("userId");
        }
    }
}
