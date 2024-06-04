using System;
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
    public partial class OrderCompletePopup : Form
    {
        private int totalProductTypes, totalQuantity, totalPrice;
        public OrderCompletePopup(int totalProductTypes, int totalQuantity, int totalPrice)
        {
            InitializeComponent();
            designProperties(totalProductTypes, totalQuantity, totalPrice);
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

        private void orderComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
