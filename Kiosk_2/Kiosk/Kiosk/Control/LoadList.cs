using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiosk.Control
{
    //카테고리 목록과 상품 목록을 Csv파일로부터 가져오는 클래스
    internal class LoadList
    {
        private List<Category> categories;
        private List<Product> products;
        //csv파일에서 존재하는 카테고리 목록을 읽어오는 메서드
        public List<Category> LoadCategories()
        {
            categories = CsvHelperUtility.ReadCsv<Category>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\categories.csv", new CategoryMap());
            return categories;
        }
        //csv파일에서 존재하는 상품 목록을 읽어오는 메서드
        public List<Product> LoadProducts()
        {
            products = CsvHelperUtility.ReadCsv<Product>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\products.csv", new ProductMap());
            return products;
        }
    }
}
