using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kiosk
{
    public partial class OrderCheckPopup : Form
    {
        private int totalProductTypes, totalQuantity, totalPrice;
        private List<Panel> cartItems;
        private List<Product> products;
        private CustomerMainForm mainForm;

        public OrderCheckPopup(int totalProductTypes, int totalQuantity, int totalPrice, List<Panel> cartItems, List<Product> products, CustomerMainForm mainForm)
        {
            InitializeComponent();
            designProperties(totalProductTypes, totalQuantity, totalPrice);
            this.cartItems = cartItems;
            this.products = products;
            this.mainForm = mainForm;
        }

        void designProperties(int totalProductTypes, int totalQuantity, int totalPrice)
        {
            this.totalProductTypes = totalProductTypes;
            this.totalQuantity = totalQuantity;
            this.totalPrice = totalPrice;
            orderProductTypesLabel.Text = $"{totalProductTypes} 개";
            orderQuantityLabel.Text = $"{totalQuantity} 가지";
            orderTotalPriceLabel.Text = $"합계 {totalPrice} 원";
        }

        private void orderYes_Click(object sender, EventArgs e)
        {
            SaveOrderToCsv();
            ClearCart();
            OrderCompletePopup orderCompletePopup = new OrderCompletePopup(totalProductTypes, totalQuantity, totalPrice);
            orderCompletePopup.ShowDialog();
            this.Close();
        }

        private void SaveOrderToCsv()
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
        private void ClearCart()
        {
            mainForm.ClearCart();
        }

        private void orderCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
