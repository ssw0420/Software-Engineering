﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using Kiosk.Control;

namespace Kiosk
{
    public partial class CustomerMainForm : Form
    {
        private List<Category> categories;
        private List<Product> products;
        private List<Panel> cartItems = new List<Panel>();
        private int nowCategories;
        private int totalProductTypes;
        private int totalQuantity;
        private int totalPrice;
        private LoadList loadList = new LoadList();
        
        public CustomerMainForm()
        {
            InitializeComponent();
            //컨트롤 클래스인 LoadEntity의 LoadCategories와 LoadProducts 메서드를 호출하여
            //Csv파일의 카테고리 목록과 상품 목록을 불러온다.
            categories = loadList.LoadCategories();
            products = loadList.LoadProducts();

            DisplayCategories();
            DisplayProducts(1);
            InitializeSummaryLabels();

            this.FormClosing += CustomerMainForm_FormClosing; // 폼이 닫힐 때 이벤트 핸들러 추가
        }

        private void InitializeSummaryLabels()
        {
            totalQuantityLabel.Text = "0 개";
            totalProductTypesLabel.Text = "0 가지";
            totalPriceLabel.Text = "합계 0 원";
        }

        private void UpdateSummaryLabels()
        {
            totalQuantity = cartItems.Sum(panel =>
            {
                var quantityLabel = panel.Controls.OfType<Label>().First(l => l.Text.StartsWith("수량:"));
                return int.Parse(quantityLabel.Text.Split(':')[1].Trim());
            });

            totalPrice = cartItems.Sum(panel =>
            {
                var priceLabel = panel.Controls.OfType<Label>().First(l => l.Text.StartsWith("가격:"));
                return int.Parse(priceLabel.Text.Split(':')[1].Trim().Split(' ')[0]);
            });
            totalProductTypes = cartItems.Count;
            totalQuantityLabel.Text = $"{totalQuantity} 개";
            totalProductTypesLabel.Text = $"{totalProductTypes} 가지";
            totalPriceLabel.Text = $"합계 {totalPrice} 원";
        }

        private void DisplayCategories()
        {
            int index = 0;
            foreach (var category in categories)
            {
                // 카테고리 라벨 폰트 설정 및 Bold
                var label = new Label
                {
                    Name = category.CategoryName,
                    Image = Image.FromFile("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Images\\ButtonImg\\DefaultCategoryButton.png"),
                    ImageAlign = ContentAlignment.MiddleCenter,
                    Text = category.CategoryName,
                    Width = 130,
                    Height = 70,
                    AutoSize = false,
                    Margin = new Padding(15),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Tag = category.CategoryId,
                    Font = new Font("굴림", 14, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
                };
                label.Click += CategoryLabel_Click;
                if(index == 0)
                {
                    label.Image = Image.FromFile("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Images\\ButtonImg\\ClickCategoryButton.png");
                }
                CategoryList.Controls.Add(label);
                index++;
            }
        }

        private void CategoryLabel_Click(object sender, EventArgs e)
        {
            var clickedLabel = sender as Label;
            var clickedCategoryId = (int)clickedLabel.Tag;

            nowCategories = clickedCategoryId;

            // 모든 카테고리 버튼을 순회하면서 이미지 변경
            foreach (System.Windows.Forms.Control control in CategoryList.Controls)
            {
                if (control is Label label)
                {
                    var categoryId = (int)label.Tag;
                    if (categoryId == clickedCategoryId)
                    {
                        label.Image = Image.FromFile("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Images\\ButtonImg\\ClickCategoryButton.png");
                    }
                    else
                    {
                        label.Image = Image.FromFile("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Images\\ButtonImg\\DefaultCategoryButton.png");
                    }
                }
            }

            DisplayProducts(nowCategories);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void DisplayProducts(int categoryId)
        {
            MenuList.Controls.Clear();
            var categoryProducts = products.Where(p => p.CategoryId == categoryId).ToList();

            if (!categoryProducts.Any())
            {
                MessageBox.Show("카테고리가 비어있습니다!");
                return;
            }

            MenuList.RowCount = categoryProducts.Count;

            foreach (var product in categoryProducts)
            {
                // 패널 생성
                var productPanel = new Panel
                {
                    Width = 250,
                    Height = 450,
                    Margin = new Padding(10),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.FromArgb(237, 233, 226),
                    Tag = product.ProductId
                };
                productPanel.Click += ProductPanel_Click;

                // 제품명 라벨
                var productLabel = new Label
                {
                    Text = product.ProductName,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30,
                    BackColor = Color.FromArgb(237, 233, 226),
                    Margin = new Padding(5),
                    Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
                };
                productLabel.Click += (s, e) => ProductPanel_Click(productPanel, e);

                // 제품 이미지
                var productPictureBox = new PictureBox
                {
                    Image = Image.FromFile(product.ProductImgPath),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Width = 181,
                    Height = 181,
                    Dock = DockStyle.Top,
                    Margin = new Padding(5),
                    Tag = product.ProductId
                };
                productPictureBox.Click += (s, e) => ProductPanel_Click(productPanel, e);

                // 제품 별점 라벨
                var ratingLabel = new Label
                {
                    Text = $"별점: {product.ProductRating}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30,
                    BackColor = Color.FromArgb(237, 233, 226),
                    Margin = new Padding(5),
                    Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
                };
                ratingLabel.Click += (s, e) => ProductPanel_Click(productPanel, e);

                // 제품 가격 라벨
                var priceLabel = new Label
                {
                    Text = $"{product.ProductPrice} 원",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30,
                    BackColor = Color.FromArgb(237, 233, 226),
                    Margin = new Padding(5),
                    Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
                };
                priceLabel.Click += (s, e) => ProductPanel_Click(productPanel, e);

                // 패널에 라벨과 이미지 추가
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(ratingLabel);
                productPanel.Controls.Add(productPictureBox);
                productPanel.Controls.Add(productLabel);

                // TableLayoutPanel에 패널 추가
                MenuList.Controls.Add(productPanel);
            }
        }

        public void AddToCart(Product product, int quantity)
        {
            // 장바구니에 동일한 상품이 있는지 확인
            if (cartItems.Any(panel => (int)panel.Tag == product.ProductId))
            {
                MessageBox.Show("현재 장바구니에 등록된 상품입니다.");
                return;
            }

            var cartItemPanel = new Panel
            {
                Width = 250,
                Height = 100,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(237, 233, 226),
                Tag = product.ProductId
            };

            var productNameLabel = new Label
            {
                Text = product.ProductName,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 20,
                BackColor = Color.FromArgb(237, 233, 226),
                Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
            };

            var productPriceLabel = new Label
            {
                Text = $"가격: {product.ProductPrice * quantity} 원",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 20,
                BackColor = Color.FromArgb(237, 233, 226),
                Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
            };

            var productQuantityLabel = new Label
            {
                Text = $"수량: {quantity}",
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Top,
                Height = 20,
                BackColor = Color.FromArgb(237, 233, 226),
                Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
            };

            var decreaseButton = new Button
            {
                Text = "-",
                Width = 30,
                Height = 30,
                Dock = DockStyle.Left,
                Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
            };
            decreaseButton.Click += (s, e) => ModifyCartItemQuantity(cartItemPanel, false);

            var increaseButton = new Button
            {
                Text = "+",
                Width = 30,
                Height = 30,
                Dock = DockStyle.Left,
                Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
            };
            increaseButton.Click += (s, e) => ModifyCartItemQuantity(cartItemPanel, true);

            var removeButton = new Button
            {
                Text = "삭제",
                Width = 50,
                Height = 30,
                Dock = DockStyle.Right,
                Font = new Font("굴림", 12, FontStyle.Bold) // 굴림체, 폰트 크기 및 Bold 설정
            };
            removeButton.Click += (s, e) => RemoveCartItem(cartItemPanel);

            cartItemPanel.Controls.Add(removeButton);
            cartItemPanel.Controls.Add(increaseButton);
            cartItemPanel.Controls.Add(decreaseButton);
            cartItemPanel.Controls.Add(productQuantityLabel);
            cartItemPanel.Controls.Add(productPriceLabel);
            cartItemPanel.Controls.Add(productNameLabel);

            cartItems.Add(cartItemPanel);
            CartLayoutPanel.Controls.Add(cartItemPanel); // 장바구니 패널에 추가

            UpdateSummaryLabels(); // 하단부 라벨 업데이트
        }

        private void ModifyCartItemQuantity(Panel cartItemPanel, bool isIncrease)
        {
            var productId = (int)cartItemPanel.Tag;
            var product = products.First(p => p.ProductId == productId);
            var quantityLabel = cartItemPanel.Controls.OfType<Label>().First(l => l.Text.StartsWith("수량:"));
            var priceLabel = cartItemPanel.Controls.OfType<Label>().First(l => l.Text.StartsWith("가격:"));

            int quantity = int.Parse(quantityLabel.Text.Split(':')[1].Trim());
            if (isIncrease)
            {
                quantity++;
            }
            else
            {
                if (quantity > 1)
                    quantity--;
            }

            quantityLabel.Text = $"수량: {quantity}";
            priceLabel.Text = $"가격: {product.ProductPrice * quantity} 원";

            UpdateSummaryLabels(); // 하단부 라벨 업데이트
        }

        private void RemoveCartItem(Panel cartItemPanel)
        {
            cartItems.Remove(cartItemPanel);
            CartLayoutPanel.Controls.Remove(cartItemPanel);
            UpdateSummaryLabels(); // 하단부 라벨 업데이트
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            var productId = (int)panel.Tag;
            DisplayProductDetail(productId);
        }

        //제품 상세 팝업 띄우는 메서드
        private void DisplayProductDetail(int productId)
        {
            var selectedProduct = products.FirstOrDefault(p => p.ProductId == productId);
            ProductDetailPopup productDetailPopup = new ProductDetailPopup(selectedProduct, this);
            productDetailPopup.ShowDialog();
        }

        private void orderDetail_Click(object sender, EventArgs e)
        {
            OrderDetailPopup orderDetailPopup = new OrderDetailPopup();
            orderDetailPopup.Show();
            this.Hide();
        }

        private void cartOrder_Click(object sender, EventArgs e)
        {
            CheckOrder checkOrder = new CheckOrder();
            checkOrder.checkOrderCorrect(totalProductTypes, totalQuantity, totalPrice, cartItems, products, this);
        }

        public void ClearCart()
        {
            cartItems.Clear();
            CartLayoutPanel.Controls.Clear();
            UpdateSummaryLabels();
        }

        private void CustomerMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InitializeCsvFiles();
        }

        private void InitializeCsvFiles()
        {
            string orderFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orders.csv";
            string orderItemFilePath = "C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\orderItems.csv";

            InitializeCsvFile<Order>(orderFilePath);
            InitializeCsvFile<OrderItem>(orderItemFilePath);
        }

        private static void InitializeCsvFile<T>(string filePath)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                ShouldQuote = args => true,
                HasHeaderRecord = true
            };

            using (var writer = new StreamWriter(filePath, false)) // append: false, 파일을 덮어씀
            using (var csv = new CsvWriter(writer, config))
            {
                csv.WriteHeader<T>();
                csv.NextRecord(); // 헤더와 데이터 사이의 줄바꿈
            }
        }
    }
}
