namespace Kiosk
{
    partial class OrderCompletePopup
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
            this.orderQuantityLabel = new System.Windows.Forms.Label();
            this.orderProductTypesLabel = new System.Windows.Forms.Label();
            this.orderTotalPriceLabel = new System.Windows.Forms.Label();
            this.orderCompleteLabel = new System.Windows.Forms.PictureBox();
            this.orderComplete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderCompleteLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderComplete)).BeginInit();
            this.SuspendLayout();
            // 
            // orderQuantityLabel
            // 
            this.orderQuantityLabel.AutoSize = true;
            this.orderQuantityLabel.BackColor = System.Drawing.Color.White;
            this.orderQuantityLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderQuantityLabel.Location = new System.Drawing.Point(381, 375);
            this.orderQuantityLabel.Name = "orderQuantityLabel";
            this.orderQuantityLabel.Size = new System.Drawing.Size(107, 32);
            this.orderQuantityLabel.TabIndex = 7;
            this.orderQuantityLabel.Text = "label2";
            // 
            // orderProductTypesLabel
            // 
            this.orderProductTypesLabel.AutoSize = true;
            this.orderProductTypesLabel.BackColor = System.Drawing.Color.White;
            this.orderProductTypesLabel.Font = new System.Drawing.Font("굴림", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderProductTypesLabel.Location = new System.Drawing.Point(199, 375);
            this.orderProductTypesLabel.Name = "orderProductTypesLabel";
            this.orderProductTypesLabel.Size = new System.Drawing.Size(107, 32);
            this.orderProductTypesLabel.TabIndex = 8;
            this.orderProductTypesLabel.Text = "label1";
            // 
            // orderTotalPriceLabel
            // 
            this.orderTotalPriceLabel.AutoSize = true;
            this.orderTotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.orderTotalPriceLabel.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderTotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.orderTotalPriceLabel.Location = new System.Drawing.Point(577, 370);
            this.orderTotalPriceLabel.Name = "orderTotalPriceLabel";
            this.orderTotalPriceLabel.Size = new System.Drawing.Size(126, 37);
            this.orderTotalPriceLabel.TabIndex = 6;
            this.orderTotalPriceLabel.Text = "label3";
            // 
            // orderCompleteLabel
            // 
            this.orderCompleteLabel.BackColor = System.Drawing.Color.White;
            this.orderCompleteLabel.Image = global::Kiosk.Properties.Resources.OrderCompleteText;
            this.orderCompleteLabel.Location = new System.Drawing.Point(174, 142);
            this.orderCompleteLabel.Name = "orderCompleteLabel";
            this.orderCompleteLabel.Size = new System.Drawing.Size(669, 66);
            this.orderCompleteLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderCompleteLabel.TabIndex = 9;
            this.orderCompleteLabel.TabStop = false;
            // 
            // orderComplete
            // 
            this.orderComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.orderComplete.Image = global::Kiosk.Properties.Resources.orderCompleteButton;
            this.orderComplete.Location = new System.Drawing.Point(411, 646);
            this.orderComplete.Name = "orderComplete";
            this.orderComplete.Size = new System.Drawing.Size(194, 101);
            this.orderComplete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderComplete.TabIndex = 10;
            this.orderComplete.TabStop = false;
            this.orderComplete.Click += new System.EventHandler(this.orderComplete_Click);
            // 
            // OrderCompletePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.OrderPopupForm3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 822);
            this.Controls.Add(this.orderComplete);
            this.Controls.Add(this.orderCompleteLabel);
            this.Controls.Add(this.orderProductTypesLabel);
            this.Controls.Add(this.orderQuantityLabel);
            this.Controls.Add(this.orderTotalPriceLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCompletePopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderCompletePopup";
            ((System.ComponentModel.ISupportInitialize)(this.orderCompleteLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderComplete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderTotalPriceLabel;
        private System.Windows.Forms.Label orderQuantityLabel;
        private System.Windows.Forms.Label orderProductTypesLabel;
        private System.Windows.Forms.PictureBox orderCompleteLabel;
        private System.Windows.Forms.PictureBox orderComplete;
    }
}