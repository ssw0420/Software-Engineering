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
        public class Orders
        {
            [Name("사람이름")]
            public string Name { get; set; }
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
            using (var streamReader = new StreamReader("resourse\\aa.csv"))
            {
                using (var csvReader = new CsvReader(streamReader, CultureInfo.InvariantCulture))
                {
                    List<Orders> orders = csvReader.GetRecords<Orders>().ToList();
                    dataGridView1.DataSource = orders;
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
