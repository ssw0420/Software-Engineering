using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;
using CsvHelper.Configuration.Attributes;
using CsvHelper.Configuration;

namespace Kiosk
{
    public partial class OrderDetailPopup : Form
    {

        public OrderDetailPopup()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // 폼 초기화
            this.Text = "Order Detail";
            // this.AutoScroll = true; // 스크롤 가능하도록 설정
        }

        public class Order
        {
            [Name("orderTime")]
            public string OrderTime { get; set; }
            [Name("orderProductName")]
            public string OrderProductName { get; set; }
            [Name("orderQuan")]
            public string OrderQuan { get; set; }
            [Name("orderPrice")]
            public string OrderPrice { get; set; }
        }

        private void OrderDetailPopup_Load(object sender, EventArgs e)
        {
            List<Order> orders;
            using (var streamReader = new StreamReader("C:\\kiosk_2\\Software-Engineering\\Kiosk\\Kiosk\\resource\\Order.csv", Encoding.UTF8))
            using (var csvReader = new CsvReader(streamReader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true }))
            {
                orders = csvReader.GetRecords<Order>().ToList();
            }

            // 주문 시간별로 그룹화
            var groupedOrders = orders.GroupBy(o => o.OrderTime);

            int initialYOffset = 150; // 첫 주문 시간 레이블의 Y 위치
            int productYOffset = initialYOffset + 40; // 첫 주문 항목 레이블의 Y 위치
            int currentYOffset = productYOffset; // 현재 Y 위치를 추적하기 위한 변수

            decimal totalAmount = 0; // 전체 주문 내역의 총 금액을 계산하기 위한 변수
            decimal totalQuan = 0; // 전체 주문 내역의 총 수량을 계산하기 위한 변수
            foreach (var orderGroup in groupedOrders)
            {
                // 첫 번째 주문 시간 그룹의 Y 위치 고정
                if (orderGroup.Key == orders.First().OrderTime)
                {
                    currentYOffset = productYOffset;
                }
                else
                {
                    currentYOffset += 40; // 이전 그룹과의 간격을 두기 위해 추가로 Y 위치 조정
                }

                // 주문 시간 레이블
                var lblOrderTime = new Label
                {
                    Text = $" {orderGroup.Key}",
                    AutoSize = true,
                    Font = new Font("Arial", 25, FontStyle.Bold),
                    Location = new Point(110, currentYOffset),
                    BackColor = Color.Transparent
                };
                this.Controls.Add(lblOrderTime);

                // 각 주문 시간의 주문 항목들 출력 및 총 금액 계산
                foreach (var order in orderGroup)
                {
                    var productNameLabel = new Label
                    {
                        Text = $" {order.OrderProductName}",
                        AutoSize = true,
                        Font = new Font("Arial", 20, FontStyle.Regular),
                        Location = new Point(540, currentYOffset),
                        BackColor = Color.Transparent
                    };
                    var quantityLabel = new Label
                    {
                        Text = $" {order.OrderQuan}",
                        AutoSize = true,
                        Font = new Font("Arial", 20, FontStyle.Regular),
                        Location = new Point(920, currentYOffset),
                        BackColor = Color.Transparent
                    };
                    var priceLabel = new Label
                    {
                        Text = $" {order.OrderPrice}",
                        AutoSize = true,
                        Font = new Font("Arial", 20, FontStyle.Regular),
                        Location = new Point(1150, currentYOffset),
                        BackColor = Color.Transparent
                    };

                    // 주문 항목의 금액을 총 금액에 더함
                    totalAmount += decimal.Parse(order.OrderPrice);
                    totalQuan += decimal.Parse(order.OrderQuan);

                    this.Controls.Add(productNameLabel);
                    this.Controls.Add(quantityLabel);
                    this.Controls.Add(priceLabel);

                    currentYOffset += 40; // 다음 항목의 Y 위치 조정
                }

                currentYOffset += 30; // 각 주문 시간 그룹 사이의 여백
            }

            // 전체 총 금액 출력 레이블
            var totalAmountLabel = new Label
            {
                Text = $" {totalAmount}원",
                AutoSize = true,
                Font = new Font("Arial", 20, FontStyle.Regular),
                Location = new Point(1350, 810),
                BackColor = Color.Transparent
            };
            var totalQuanLabel = new Label
            {
                Text = $" {totalQuan}개",
                AutoSize = true,
                Font = new Font("Arial", 20, FontStyle.Regular),
                Location = new Point(1150, 810),
                BackColor = Color.Transparent
            };
            this.Controls.Add(totalAmountLabel);
            this.Controls.Add(totalQuanLabel);
        }

    }
}

