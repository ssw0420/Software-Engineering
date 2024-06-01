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
<<<<<<< HEAD
        public class Orders
        {
            
        }
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
        }

        
    
=======
        public OrderDetailPopup()
        {
            InitializeComponent();
        }
    }
>>>>>>> c4a78919c7dece0578fedd71da4c97fa95a4d2b0
}
