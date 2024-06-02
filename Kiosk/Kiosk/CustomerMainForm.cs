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
    public partial class CustomerMainForm : Form
    {
        private List<Category> categories;
        public CustomerMainForm()
        {
            InitializeComponent();
            LoadCategories();
            DisplayCategories();
        }

        private void LoadCategories()
        {
            categories = CsvHelperUtility.ReadCsv<Category>("C:\\kiosk_2\\Software-Engineering\\Kiosk\\Kiosk\\Data\\categories.csv", new CategoryMap());
        }

        private void DisplayCategories()
        {
            foreach (Category category in categories)
            {
                var categories_pictureBox = new Button
                {
                    Text = category.CategoryName,
                    Tag = category.CategoryId,
                    Width = 180,
                    Height = 50,
                    Margin = new Padding(10)
                };
                categories_pictureBox.Click += CategoryButton_Click;
                categoryflowLayoutPanel.Controls.Add(categories_pictureBox);
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            var categoryId = button.Tag as string;
            MessageBox.Show($"Category {categoryId} clicked!");
        }
        private void CustomerMainForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void orderDetail_Click(object sender, EventArgs e)
        {
            OrderDetailPopup orderDetailPopup = new OrderDetailPopup();
            orderDetailPopup.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
