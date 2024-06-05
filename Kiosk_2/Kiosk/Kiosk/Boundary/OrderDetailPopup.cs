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
        private int totalQuantity = 0;

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
                // 주문 시간 패널 생성
                var orderTimePanel = new Panel
                {
                    Width = OrderDetailList.Width - 20,
                    Height = 50,
                    Margin = new Padding(10, 10, 10, 0),
                    BackColor = Color.FromArgb(245, 245, 245) // 패널 배경색 변경
                };


                var orderDateLabel = new Label
                {
                    Text = $"{orderGroup.Key}",
                    TextAlign = ContentAlignment.MiddleLeft,
                    Dock = DockStyle.Left,
                    Width = OrderDetailList.Width / 3,
                    Height = 30,
                    Font = new Font("굴림", 19, FontStyle.Bold), // 글씨 크기 조정
                    BackColor = Color.FromArgb(245, 245, 245) // 라벨 배경색 변경
                };

                orderTimePanel.Controls.Add(orderDateLabel);
                OrderDetailList.Controls.Add(orderTimePanel);

                var orderItemDetailsPanel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Top,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    Width = OrderDetailList.Width - 20,
                    Height = OrderDetailList.Height,
                    BackColor = Color.FromArgb(255, 255, 255) // 패널 배경색 변경
                };

                int itemCount = 0; // 항목 개수 카운트

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
                        itemCount++;
                        var orderItemPanel = new Panel
                        {
                            Width = orderItemDetailsPanel.Width - 20,
                            Height = 50,
                            Margin = new Padding(5, 15, 5, 15), // 항목 간 간격 추가
                            BorderStyle = BorderStyle.None, // 패널 테두리 제거
                            BackColor = Color.FromArgb(255, 255, 255) // 패널 배경색 변경
                        };

                        var registerButton = new Button
                        {
                            Text = "등록",
                            Width = 70,
                            Height = 30,
                            Dock = DockStyle.Right // 버튼을 오른쪽으로 이동
                        };

                        var priceLabel = new Label
                        {
                            Text = $"{item.Price} 원",
                            Width = 300,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("굴림", 19, FontStyle.Bold), // 글씨 크기 조정
                            Dock = DockStyle.Right,
                            BackColor = Color.FromArgb(255, 255, 255) // 라벨 배경색 변경
                        };

                        var quantityLabel = new Label
                        {
                            Text = $"{item.Quantity} 개",
                            Width = 200,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("굴림", 19, FontStyle.Bold), // 글씨 크기 조정
                            Dock = DockStyle.Right,
                            BackColor = Color.FromArgb(255, 255, 255) // 라벨 배경색 변경
                        };

                        var productNameLabel = new Label
                        {
                            Text = item.ProductName,
                            Width = 290,
                            TextAlign = ContentAlignment.MiddleLeft,
                            Font = new Font("굴림", 19, FontStyle.Bold), // 글씨 크기 조정
                            Dock = DockStyle.Right,
                            BackColor = Color.FromArgb(255, 255, 255) // 라벨 배경색 변경
                        };
                        orderItemPanel.Controls.Add(productNameLabel);
                        orderItemPanel.Controls.Add(quantityLabel);
                        orderItemPanel.Controls.Add(priceLabel);
                        orderItemPanel.Controls.Add(registerButton);

                        orderItemDetailsPanel.Controls.Add(orderItemPanel);

                        // 총 수량 계산
                        totalQuantity += item.Quantity;
                    }
                }
                orderItemDetailsPanel.Height = itemCount * 100; // 패널 크기를 동적으로 조절
                OrderDetailList.Controls.Add(orderItemDetailsPanel);
            }

            // 총 주문 수량 라벨 업데이트
            totalQuantityLabel.Text = $"{totalQuantity} 개";
            totalQuantityLabel.Font = new Font("굴림", 29, FontStyle.Bold); // 총 주문 수량 글씨 크기 조정
        }

        private void redirectMain_Click(object sender, EventArgs e)
        {
            CustomerMainForm customerMainForm = new CustomerMainForm();
            customerMainForm.Show();
            this.Hide();
        }

    }
}
