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
    public partial class ProductDetailPopup : Form
    {
        private int quantity = 1;
        public ProductDetailPopup()
        {
            InitializeComponent();
            productQuan.Text = quantity.ToString();
        }

        private void cancelProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quanMinus_Click(object sender, EventArgs e)
        {
            quantity -= 1;
            productQuan.Text = quantity.ToString();
        }

        private void quanPlus_Click(object sender, EventArgs e)
        {
            quantity += 1;
            productQuan.Text = quantity.ToString();
        }

        private void addProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
