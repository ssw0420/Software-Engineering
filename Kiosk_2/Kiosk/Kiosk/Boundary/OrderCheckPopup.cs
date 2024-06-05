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
        private SaveOrderDetail saveOrderDetail;
        public OrderCheckPopup(int totalProductTypes, int totalQuantity, int totalPrice, List<Panel> cartItems, List<Product> products, CustomerMainForm mainForm)
        {
            InitializeComponent();
            saveOrderDetail = new SaveOrderDetail();
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
            //제어클래스인 SaveOrderDetail 클래스의 SaveOrderToCsv 메서드를 호출하여
            //주문 내역과 주문 아이템을 Csv파일에 작성한다.
            saveOrderDetail.SaveOrderToCsv(cartItems, products);
            ClearCart();
            OrderCompletePopup orderCompletePopup = new OrderCompletePopup(totalProductTypes, totalQuantity, totalPrice);
            orderCompletePopup.ShowDialog();
            this.Close();
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
