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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productDetailCancel
            // 
            this.productDetailCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.productDetailCancel.Image = global::Kiosk.Properties.Resources.ProductDetailCancelButton;
            this.productDetailCancel.Location = new System.Drawing.Point(66, 657);
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
            this.productDetailAdd.Location = new System.Drawing.Point(677, 632);
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
            this.productDetailMinus.Location = new System.Drawing.Point(272, 657);
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
            this.productDetailPlus.Location = new System.Drawing.Point(538, 652);
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
            this.productQuantityLabel.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.productQuantityLabel.Location = new System.Drawing.Point(441, 688);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(39, 37);
            this.productQuantityLabel.TabIndex = 4;
            this.productQuantityLabel.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(97, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 207);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ProductDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.OrderPopupForm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 822);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productDetailPlus);
            this.Controls.Add(this.productDetailMinus);
            this.Controls.Add(this.productDetailAdd);
            this.Controls.Add(this.productDetailCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductDetailPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductDetailPopup";
            ((System.ComponentModel.ISupportInitialize)(this.productDetailCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDetailPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}