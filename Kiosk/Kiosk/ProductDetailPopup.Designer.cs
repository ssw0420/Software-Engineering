namespace Kiosk
{
    partial class ProductDetailPopup
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.quanPlus = new System.Windows.Forms.PictureBox();
            this.quanMinus = new System.Windows.Forms.PictureBox();
            this.cancelProduct = new System.Windows.Forms.PictureBox();
            this.addProduct = new System.Windows.Forms.PictureBox();
            this.productQuan = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(220)))));
            this.panel1.BackgroundImage = global::Kiosk.Properties.Resources.detailPanel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Location = new System.Drawing.Point(50, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 529);
            this.panel1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(386, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(529, 80);
            this.label4.TabIndex = 5;
            this.label4.Text = "돼지고기, 김치가 들어가 있는\n전통의 맛이 느껴지는 김치찌개 입니다!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(384, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "김치찌개";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(215, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "8,500 원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(102, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "4.4";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = global::Kiosk.Properties.Resources.BigStar;
            this.pictureBox6.Location = new System.Drawing.Point(40, 376);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(56, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = global::Kiosk.Properties.Resources.kimchiDetail;
            this.pictureBox5.Location = new System.Drawing.Point(20, 27);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(342, 343);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // quanPlus
            // 
            this.quanPlus.Image = global::Kiosk.Properties.Resources.orderproduct_1;
            this.quanPlus.Location = new System.Drawing.Point(561, 621);
            this.quanPlus.Name = "quanPlus";
            this.quanPlus.Size = new System.Drawing.Size(95, 115);
            this.quanPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.quanPlus.TabIndex = 5;
            this.quanPlus.TabStop = false;
            this.quanPlus.Click += new System.EventHandler(this.quanPlus_Click);
            // 
            // quanMinus
            // 
            this.quanMinus.Image = global::Kiosk.Properties.Resources.orderproduct_;
            this.quanMinus.Location = new System.Drawing.Point(317, 644);
            this.quanMinus.Name = "quanMinus";
            this.quanMinus.Size = new System.Drawing.Size(95, 130);
            this.quanMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.quanMinus.TabIndex = 4;
            this.quanMinus.TabStop = false;
            this.quanMinus.Click += new System.EventHandler(this.quanMinus_Click);
            // 
            // cancelProduct
            // 
            this.cancelProduct.Image = global::Kiosk.Properties.Resources.orderproductcancel;
            this.cancelProduct.Location = new System.Drawing.Point(50, 635);
            this.cancelProduct.Name = "cancelProduct";
            this.cancelProduct.Size = new System.Drawing.Size(149, 101);
            this.cancelProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cancelProduct.TabIndex = 3;
            this.cancelProduct.TabStop = false;
            this.cancelProduct.Click += new System.EventHandler(this.cancelProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Image = global::Kiosk.Properties.Resources.baguniadd;
            this.addProduct.Location = new System.Drawing.Point(683, 621);
            this.addProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(303, 165);
            this.addProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.addProduct.TabIndex = 2;
            this.addProduct.TabStop = false;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // productQuan
            // 
            this.productQuan.AutoSize = true;
            this.productQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(220)))));
            this.productQuan.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productQuan.Location = new System.Drawing.Point(463, 653);
            this.productQuan.Name = "productQuan";
            this.productQuan.Size = new System.Drawing.Size(28, 65);
            this.productQuan.TabIndex = 6;
            this.productQuan.Text = "\r\n";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(508, 303);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 19);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ProductDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(224)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1031, 822);
            this.Controls.Add(this.productQuan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quanPlus);
            this.Controls.Add(this.quanMinus);
            this.Controls.Add(this.cancelProduct);
            this.Controls.Add(this.addProduct);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDetailPopup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox addProduct;
        private System.Windows.Forms.PictureBox cancelProduct;
        private System.Windows.Forms.PictureBox quanMinus;
        private System.Windows.Forms.PictureBox quanPlus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label productQuan;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

