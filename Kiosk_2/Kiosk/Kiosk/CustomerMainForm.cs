using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class CustomerMainForm : Form
    {
        private List<Category> categories;
        private List<Product> products;
        private int nowCategories;
        public CustomerMainForm()
        {
            InitializeComponent();
            LoadCategories();
            LoadProducts();
            DisplayCategories();
            DisplayProducts(1);
        }

        private void DisplayCategories()
        {
            foreach (var category in categories)
            {

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
                    Tag = category.CategoryId
                };
                label.Click += CategoryLabel_Click;
                CategoryList.Controls.Add(label);
            }
        }

        private void CategoryLabel_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            var categoryId = (int)label.Tag;
            var categoryName = label.Name;
            nowCategories = categoryId;
            DisplayProducts(nowCategories);
        }


        private void LoadCategories()
        {
            categories = CsvHelperUtility.ReadCsv<Category>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\categories.csv", new CategoryMap());
        }

        private void LoadProducts()
        {
            products = CsvHelperUtility.ReadCsv<Product>("C:\\kiosk_2\\Software-Engineering\\Kiosk_2\\Kiosk\\Kiosk\\Resources\\Data\\products.csv", new ProductMap());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void DisplayProducts(int categoryId)
        {
            MenuList.Controls.Clear();
            var categoryProducts = products.Where(p => p.CategoryId == categoryId).ToList();
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
                    Margin = new Padding(5)
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
                // productPictureBox.Click += PictureBox_Click;

                // 제품 별점 라벨
                var ratingLabel = new Label
                {
                    Text = $"별점: {product.ProductRating}",
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Top,
                    Height = 30,
                    BackColor = Color.FromArgb(237, 233, 226),
                    Margin = new Padding(5)
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
                    Margin = new Padding(5)
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

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            var productId = (int)panel.Tag;
            DisplayProductDetail(productId);
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            var pic = sender as PictureBox;
            var productId = (int)pic.Tag;
            DisplayProductDetail(productId);
        }


        private void DisplayProductDetail(int productId)
        {
            var selectedProduct = products.FirstOrDefault(p => p.ProductId == productId);
            ProductDetailPopup productDetailPopup = new ProductDetailPopup(selectedProduct);
            productDetailPopup.ShowDialog();
        }

        private void orderDetail_Click(object sender, EventArgs e)
        {
            OrderDetailPopup orderDetailPopup = new OrderDetailPopup();
            orderDetailPopup.Show();
            this.Hide();
        }
    }
}
