namespace Kiosk
{
    partial class ProductDetailPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.productDetailCancel = new System.Windows.Forms.PictureBox();
            this.productDetailAdd = new System.Windows.Forms.PictureBox();
            this.productDetailMinus = new System.Windows.Forms.PictureBox();
            this.productDetailPlus = new System.Windows.Forms.PictureBox();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productRatingLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productContentLabel = new System.Windows.Forms.Label();
            this.productImagePbx = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePbx)).BeginInit();
            this.SuspendLayout();
            // 
            // productDetailCancel
            // 
            this.productDetailCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.productDetailCancel.Image = global::Kiosk.Properties.Resources.ProductDetailCancelButton;
            this.productDetailCancel.Location = new System.Drawing.Point(75, 821);
            this.productDetailCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productDetailCancel.Name = "productDetailCancel";
            this.productDetailCancel.Size = new System.Drawing.Size(149, 101);
            this.productDetailCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.productDetailCancel.TabIndex = 0;
            this.productDetailCancel.TabStop = false;
            this.productDetailCancel.Click += new System.EventHandler(this.productDetailCancel_Click);
            // 
            // productDetailAdd
            // 
            this.productDetailAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.productDetailAdd.Image = global::Kiosk.Properties.Resources.ProductDetailAddButton;
            this.productDetailAdd.Location = new System.Drawing.Point(774, 790);
            this.productDetailAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productDetailAdd.Name = "productDetailAdd";
            this.productDetailAdd.Size = new System.Drawing.Size(303, 165);
            this.productDetailAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.productDetailAdd.TabIndex = 1;
            this.productDetailAdd.TabStop = false;
            this.productDetailAdd.Click += new System.EventHandler(this.productDetailAdd_Click);
            // 
            // productDetailMinus
            // 
            this.productDetailMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.productDetailMinus.Image = global::Kiosk.Properties.Resources.ProductDetailMinusButton;
            this.productDetailMinus.Location = new System.Drawing.Point(311, 821);
            this.productDetailMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productDetailMinus.Name = "productDetailMinus";
            this.productDetailMinus.Size = new System.Drawing.Size(95, 92);
            this.productDetailMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.productDetailMinus.TabIndex = 2;
            this.productDetailMinus.TabStop = false;
            this.productDetailMinus.Click += new System.EventHandler(this.productDetailMinus_Click);
            // 
            // productDetailPlus
            // 
            this.productDetailPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.productDetailPlus.Image = global::Kiosk.Properties.Resources.ProductDetailPlus;
            this.productDetailPlus.Location = new System.Drawing.Point(615, 815);
            this.productDetailPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productDetailPlus.Name = "productDetailPlus";
            this.productDetailPlus.Size = new System.Drawing.Size(95, 97);
            this.productDetailPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.productDetailPlus.TabIndex = 3;
            this.productDetailPlus.TabStop = false;
            this.productDetailPlus.Click += new System.EventHandler(this.productDetailPlus_Click);
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.productQuantityLabel.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productQuantityLabel.Location = new System.Drawing.Point(477, 856);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(48, 47);
            this.productQuantityLabel.TabIndex = 4;
            this.productQuantityLabel.Text = "1";
            // 
            // productRatingLabel
            // 
            this.productRatingLabel.AutoSize = true;
            this.productRatingLabel.BackColor = System.Drawing.Color.Transparent;
            this.productRatingLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productRatingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(85)))), ((int)(((byte)(74)))));
            this.productRatingLabel.Location = new System.Drawing.Point(182, 622);
            this.productRatingLabel.Name = "productRatingLabel";
            this.productRatingLabel.Size = new System.Drawing.Size(68, 27);
            this.productRatingLabel.TabIndex = 5;
            this.productRatingLabel.Text = "별점";
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.productPriceLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productPriceLabel.Location = new System.Drawing.Point(402, 622);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(68, 27);
            this.productPriceLabel.TabIndex = 6;
            this.productPriceLabel.Text = "가격";
            // 
            // productNameLabel
            // 
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Gulim", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productNameLabel.Location = new System.Drawing.Point(589, 126);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(496, 118);
            this.productNameLabel.TabIndex = 7;
            this.productNameLabel.Text = "productName";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productContentLabel
            // 
            this.productContentLabel.BackColor = System.Drawing.Color.Transparent;
            this.productContentLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productContentLabel.Location = new System.Drawing.Point(576, 290);
            this.productContentLabel.Name = "productContentLabel";
            this.productContentLabel.Size = new System.Drawing.Size(509, 235);
            this.productContentLabel.TabIndex = 8;
            this.productContentLabel.Text = "productContent";
            // 
            // productImagePbx
            // 
            this.productImagePbx.BackColor = System.Drawing.Color.White;
            this.productImagePbx.Location = new System.Drawing.Point(111, 126);
            this.productImagePbx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productImagePbx.Name = "productImagePbx";
            this.productImagePbx.Size = new System.Drawing.Size(391, 429);
            this.productImagePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImagePbx.TabIndex = 9;
            this.productImagePbx.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(85)))), ((int)(((byte)(74)))));
            this.label1.Location = new System.Drawing.Point(107, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "별점 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(327, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 27);
            this.label2.TabIndex = 11;
            this.label2.Text = "가격 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.label3.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(535, 856);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "개";
            // 
            // ProductDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.OrderPopupForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1178, 1028);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productRatingLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productImagePbx);
            this.Controls.Add(this.productContentLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productDetailPlus);
            this.Controls.Add(this.productDetailMinus);
            this.Controls.Add(this.productDetailAdd);
            this.Controls.Add(this.productDetailCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductDetailPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetailPopup";
            ((System.ComponentModel.ISupportInitialize)(this.productDetailCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productDetailCancel;
        private System.Windows.Forms.PictureBox productDetailAdd;
        private System.Windows.Forms.PictureBox productDetailMinus;
        private System.Windows.Forms.PictureBox productDetailPlus;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label productNameLabel;
        public System.Windows.Forms.Label productContentLabel;
        public System.Windows.Forms.Label productPriceLabel;
        public System.Windows.Forms.PictureBox productImagePbx;
        public System.Windows.Forms.Label productRatingLabel;
    }
}