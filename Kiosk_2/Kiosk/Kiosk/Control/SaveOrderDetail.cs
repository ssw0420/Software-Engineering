using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kiosk
{
    ////주문 내역과 주문 아이템을 Csv파일에 작성하는 제어 클래스.
    public class SaveOrderDetail
    {
        public void SaveOrderToCsv(List<Panel> cartItems, List<Product> products)
        {
            
            string orderFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv";
            string orderItemFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv";
            int orderId = 1;

            var fileRead = new FileRead();

            if (File.Exists(orderFilePath))
            {
                var existingOrders = fileRead.ReadCsvFile<Order>(orderFilePath);
                if (existingOrders.Any())
                {
                    orderId = existingOrders.Max(o => o.OrderId) + 1;
                }
            }

            var order = new Order
            {
                OrderId = orderId,
                OrderDate = DateTime.Now,
                UserId = 15
            };

            var orderItems = new List<OrderItem>();

            foreach (var panel in cartItems)
            {
                var productId = (int)panel.Tag;
                var quantityLabel = panel.Controls.OfType<Label>().First(l => l.Text.StartsWith("수량:"));
                int quantity = int.Parse(quantityLabel.Text.Split(':')[1].Trim());
                var product = products.First(p => p.ProductId == productId);

                var orderItem = new OrderItem
                {
                    OrderItemId = orderItems.Count + 1,
                    OrderId = orderId,
                    ProductId = productId,
                    Quantity = quantity,
                    Price = product.ProductPrice * quantity
                };
                orderItems.Add(orderItem);
            }

            CsvHelperUtility.WriteCsv(orderFilePath, new List<Order> { order });
            CsvHelperUtility.WriteCsv(orderItemFilePath, orderItems);
        }
    }
}
