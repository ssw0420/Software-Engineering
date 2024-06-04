using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Kiosk
{
    public partial class ProductDetailPopup : Form
    {
        int quantity = 1;
        // private List<Product> products;
        private Product selectedProduct;
        private CustomerMainForm mainForm;
        public ProductDetailPopup(Product product, CustomerMainForm form)
        {
            InitializeComponent();
            mainForm = form;
            selectedProduct = product;
            LoadProductDetail(product);
        }
        private void LoadProductDetail(Product product)
        {
            productNameLabel.Text = product.ProductName;
            productImagePbx.Image = Image.FromFile(product.ProductImgPath);
            productRatingLabel.Text = product.ProductRating.ToString();
            productPriceLabel.Text = product.ProductPrice.ToString();
            productContentLabel.Text = product.ProductContent;
        }
        //상품 수량 조절 메서드
        private void ModifyProductQuantity(bool isPlus)
        {
            quantity = int.Parse(productQuantityLabel.Text);
            if (isPlus)
            {
                //상품 증가 버튼"+" 클릭시
                quantity++;
                productQuantityLabel.Text = quantity.ToString();
            }
            else
            {
                //상품 증가 버튼"-" 클릭시
                //수량이 1 이상일 때만 수량 감소 가능
                if (quantity >= 1) quantity--;
                productQuantityLabel.Text = quantity.ToString();
            }
        }
        private void productDetailCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productDetailMinus_Click(object sender, EventArgs e)
        {
            if(quantity <= 1)
            {
                return;
            }
            ModifyProductQuantity(false);
        }

        private void productDetailPlus_Click(object sender, EventArgs e)
        {
            ModifyProductQuantity(true);
        }

        private void productDetailAdd_Click(object sender, EventArgs e)
        {
            if (quantity >= 1)
            {
                mainForm.AddToCart(selectedProduct, quantity);
                this.Close();
            }
            else
            {
                MessageBox.Show("상품이 한 개 이상이어야 합니다!");
            }
        }
    }
}
