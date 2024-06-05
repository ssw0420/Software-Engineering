namespace Kiosk
{
    partial class OrderCheckPopup
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
            this.orderCancel = new System.Windows.Forms.PictureBox();
            this.orderYes = new System.Windows.Forms.PictureBox();
            this.orderQuestionLabel = new System.Windows.Forms.PictureBox();
            this.orderProductTypesLabel = new System.Windows.Forms.Label();
            this.orderQuantityLabel = new System.Windows.Forms.Label();
            this.orderTotalPriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuestionLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // orderCancel
            // 
            this.orderCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.orderCancel.Image = global::Kiosk.Properties.Resources.OrderCancelButton;
            this.orderCancel.Location = new System.Drawing.Point(196, 648);
            this.orderCancel.Name = "orderCancel";
            this.orderCancel.Size = new System.Drawing.Size(243, 105);
            this.orderCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderCancel.TabIndex = 0;
            this.orderCancel.TabStop = false;
            this.orderCancel.Click += new System.EventHandler(this.orderCancel_Click);
            // 
            // orderYes
            // 
            this.orderYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            this.orderYes.Image = global::Kiosk.Properties.Resources.OrderYesButton;
            this.orderYes.Location = new System.Drawing.Point(515, 626);
            this.orderYes.Name = "orderYes";
            this.orderYes.Size = new System.Drawing.Size(303, 165);
            this.orderYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderYes.TabIndex = 1;
            this.orderYes.TabStop = false;
            this.orderYes.Click += new System.EventHandler(this.orderYes_Click);
            // 
            // orderQuestionLabel
            // 
            this.orderQuestionLabel.BackColor = System.Drawing.Color.White;
            this.orderQuestionLabel.Image = global::Kiosk.Properties.Resources.OrderCheckText;
            this.orderQuestionLabel.Location = new System.Drawing.Point(196, 142);
            this.orderQuestionLabel.Name = "orderQuestionLabel";
            this.orderQuestionLabel.Size = new System.Drawing.Size(622, 66);
            this.orderQuestionLabel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderQuestionLabel.TabIndex = 2;
            this.orderQuestionLabel.TabStop = false;
            // 
            // orderProductTypesLabel
            // 
            this.orderProductTypesLabel.AutoSize = true;
            this.orderProductTypesLabel.BackColor = System.Drawing.Color.White;
            this.orderProductTypesLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderProductTypesLabel.Location = new System.Drawing.Point(199, 375);
            this.orderProductTypesLabel.Name = "orderProductTypesLabel";
            this.orderProductTypesLabel.Size = new System.Drawing.Size(64, 21);
            this.orderProductTypesLabel.TabIndex = 3;
            this.orderProductTypesLabel.Text = "label1";
            // 
            // orderQuantityLabel
            // 
            this.orderQuantityLabel.AutoSize = true;
            this.orderQuantityLabel.BackColor = System.Drawing.Color.White;
            this.orderQuantityLabel.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderQuantityLabel.Location = new System.Drawing.Point(381, 375);
            this.orderQuantityLabel.Name = "orderQuantityLabel";
            this.orderQuantityLabel.Size = new System.Drawing.Size(64, 21);
            this.orderQuantityLabel.TabIndex = 4;
            this.orderQuantityLabel.Text = "label2";
            // 
            // orderTotalPriceLabel
            // 
            this.orderTotalPriceLabel.AutoSize = true;
            this.orderTotalPriceLabel.BackColor = System.Drawing.Color.White;
            this.orderTotalPriceLabel.Font = new System.Drawing.Font("Gulim", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderTotalPriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.orderTotalPriceLabel.Location = new System.Drawing.Point(621, 367);
            this.orderTotalPriceLabel.Name = "orderTotalPriceLabel";
            this.orderTotalPriceLabel.Size = new System.Drawing.Size(100, 29);
            this.orderTotalPriceLabel.TabIndex = 5;
            this.orderTotalPriceLabel.Text = "label3";
            // 
            // OrderCheckPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.OrderPopupForm1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1031, 822);
            this.Controls.Add(this.orderTotalPriceLabel);
            this.Controls.Add(this.orderQuantityLabel);
            this.Controls.Add(this.orderProductTypesLabel);
            this.Controls.Add(this.orderQuestionLabel);
            this.Controls.Add(this.orderYes);
            this.Controls.Add(this.orderCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderCheckPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderCheckPopup";
            ((System.ComponentModel.ISupportInitialize)(this.orderCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderQuestionLabel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orderCancel;
        private System.Windows.Forms.PictureBox orderYes;
        private System.Windows.Forms.PictureBox orderQuestionLabel;
        private System.Windows.Forms.Label orderProductTypesLabel;
        private System.Windows.Forms.Label orderQuantityLabel;
        private System.Windows.Forms.Label orderTotalPriceLabel;
    }
}