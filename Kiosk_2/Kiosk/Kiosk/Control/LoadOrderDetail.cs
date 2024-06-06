using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk.Control
{
    //주문 내역을 CSV파일로부터 읽어오는 클래스
    internal class LoadOrderDetail
    {
        public void LoadData(ref List<Order> orders, ref List<OrderItem> orderItems, ref List<Product> products)
        {
            orders = CsvHelperUtility.ReadCsv<Order>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv", new OrderMap());
            orderItems = CsvHelperUtility.ReadCsv<OrderItem>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv", new OrderItemMap());
            products = CsvHelperUtility.ReadCsv<Product>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\products.csv", new ProductMap());

            if (orders.Count == 0 || orderItems.Count == 0)
            {
                MessageBox.Show("주문 내역이 없습니다.");
            }
        }
    }
}
