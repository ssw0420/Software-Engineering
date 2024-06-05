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
    public partial class OrderDetailPopup : Form
    {
        private List<Order> orders;
        private List<OrderItem> orderItems;
        private List<Product> products;
        public OrderDetailPopup()
        {
            InitializeComponent();
            EnsureFilesExist();
            LoadData();
            DisplayOrderDetails();
        }
        private void EnsureFilesExist()
        {
            string orderFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv";
            string orderItemFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv";

            if (!System.IO.File.Exists(orderFilePath))
            {
                CsvHelperUtility.WriteCsv(orderFilePath, new List<Order>());
            }

            if (!System.IO.File.Exists(orderItemFilePath))
            {
                CsvHelperUtility.WriteCsv(orderItemFilePath, new List<OrderItem>());
            }
        }

        private void LoadData()
        {
            orders = CsvHelperUtility.ReadCsv<Order>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv", new OrderMap());
            orderItems = CsvHelperUtility.ReadCsv<OrderItem>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv", new OrderItemMap());
            products = CsvHelperUtility.ReadCsv<Product>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\products.csv", new ProductMap());

            if (orders.Count == 0 || orderItems.Count == 0)
            {
                MessageBox.Show("주문 내역이 없습니다.");
            }
        }

        private void DisplayOrderDetails()
        {
            var groupedOrders = orders.GroupBy(o => o.OrderDate)
                                      .OrderBy(g => g.Key);

            foreach (var orderGroup in groupedOrders)
            {
                
                var orderGroupPanel = new Panel
                {
                    Width = 750,
                    Height = 150,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(237, 233, 226)
                };

                var orderDateLabel = new Label
                {
                    Text = $"주문시간: {orderGroup.Key}",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Top,
                    Height = 30,
                    BackColor = Color.FromArgb(237, 233, 226)
                };

                var orderItemDetailsPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown
                };

                foreach (var order in orderGroup)
                {
                    var orderItemDetails = orderItems.Where(oi => oi.OrderId == order.OrderId)
                                                     .Select(oi => new
                                                     {
                                                         ProductName = products.First(p => p.ProductId == oi.ProductId).ProductName,
                                                         oi.Quantity,
                                                         oi.Price
                                                     }).ToList();

                    foreach (var item in orderItemDetails)
                    {
                        var orderItemPanel = new Panel
                        {
                            Width = 720,
                            Height = 30,
                            Margin = new Padding(5),
                            BorderStyle = BorderStyle.None,
                            BackColor = Color.White
                        };

                        var productNameLabel = new Label
                        {
                            Text = item.ProductName,
                            Width = 200,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Dock = DockStyle.Left
                        };

                        var quantityLabel = new Label
                        {
                            Text = $"{item.Quantity} 개",
                            Width = 100,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Dock = DockStyle.Left
                        };

                        var priceLabel = new Label
                        {
                            Text = $"{item.Price} 원",
                            Width = 100,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Dock = DockStyle.Left
                        };

                        var registerButton = new Button
                        {
                            Text = "등록",
                            Width = 50,
                            Height = 20,
                            Dock = DockStyle.Right
                        };

                        orderItemPanel.Controls.Add(registerButton);
                        orderItemPanel.Controls.Add(priceLabel);
                        orderItemPanel.Controls.Add(quantityLabel);
                        orderItemPanel.Controls.Add(productNameLabel);

                        orderItemDetailsPanel.Controls.Add(orderItemPanel);
                    }
                }

                orderGroupPanel.Controls.Add(orderItemDetailsPanel);
                orderGroupPanel.Controls.Add(orderDateLabel);

                OrderDetailList.Controls.Add(orderGroupPanel);
            }
        }

        private void redirectMain_Click(object sender, EventArgs e)
        {
            CustomerMainForm customerMainForm = new CustomerMainForm();
            customerMainForm.Show();
            this.Hide();
        }
    }
}
