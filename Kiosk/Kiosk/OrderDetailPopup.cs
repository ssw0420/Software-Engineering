using CsvHelper;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Net.WebRequestMethods;

namespace Kiosk
{
    public partial class OrderDetailPopup : Form
    {
        
        public OrderDetailPopup()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(235, 224, 220);

/*            label2.BackColor = Color.Transparent;
            label2.Parent = panel1;
            label7.BackColor = Color.Transparent;
            label7.Parent = panel2;*/


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 newform2=new Form2();
            newform2.ShowDialog();
        }

        private void OrderDetailPopup_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
