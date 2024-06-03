using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Map(m => m.CategoryId).Name("categoryId");
            Map(m => m.CategoryName).Name("categoryName");
        }
    }
}
