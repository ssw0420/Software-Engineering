using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(235, 224, 220);

            label2.BackColor = Color.Transparent;
            label2.Parent = panel1;
            label7.BackColor = Color.Transparent;
            label7.Parent = panel2;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 newform2=new Form2();
            newform2.ShowDialog();
        }
    }
}
