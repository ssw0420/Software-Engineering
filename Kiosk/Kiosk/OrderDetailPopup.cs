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
    public partial class OrderDetailPopup : Form
    {
        public OrderDetailPopup()
        {
            InitializeComponent();
        }

        private void redirectMain_Click(object sender, EventArgs e)
        {
            CustomerMainForm customerMainForm = new CustomerMainForm();
            customerMainForm.Show();
            this.Hide();
        }
    }
}
