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
    public partial class OrderCheckPopup : Form
    {
        public OrderCheckPopup()
        {
            InitializeComponent();
        }

        private void orderYes_Click(object sender, EventArgs e)
        {
            OrderCompletePopup orderCompletePopup = new OrderCompletePopup();
            orderCompletePopup.ShowDialog();
            this.Close();
        }
        private void orderCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
