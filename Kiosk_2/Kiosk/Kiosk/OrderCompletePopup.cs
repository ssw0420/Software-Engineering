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
        public OrderCompletePopup()
        {
            InitializeComponent();
        }

        private void orderComplete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
