namespace Kiosk
{
    partial class OrderDetailPopup
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
            this.redirectMain = new System.Windows.Forms.PictureBox();
            this.OrderDetailList = new System.Windows.Forms.FlowLayoutPanel();
            this.totalQuantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.redirectMain)).BeginInit();
            this.SuspendLayout();
            // 
            // redirectMain
            // 
            this.redirectMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.redirectMain.Image = global::Kiosk.Properties.Resources.redirectMainButton;
            this.redirectMain.Location = new System.Drawing.Point(38, 854);
            this.redirectMain.Name = "redirectMain";
            this.redirectMain.Size = new System.Drawing.Size(239, 61);
            this.redirectMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redirectMain.TabIndex = 0;
            this.redirectMain.TabStop = false;
            this.redirectMain.Click += new System.EventHandler(this.redirectMain_Click);
            // 
            // OrderDetailList
            // 
            this.OrderDetailList.AutoScroll = true;
            this.OrderDetailList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OrderDetailList.Location = new System.Drawing.Point(12, 179);
            this.OrderDetailList.Name = "OrderDetailList";
            this.OrderDetailList.Size = new System.Drawing.Size(1299, 615);
            this.OrderDetailList.TabIndex = 1;
            // 
            // totalQuantityLabel
            // 
            this.totalQuantityLabel.AutoSize = true;
            this.totalQuantityLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.totalQuantityLabel.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.totalQuantityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(85)))), ((int)(((byte)(74)))));
            this.totalQuantityLabel.Location = new System.Drawing.Point(1174, 968);
            this.totalQuantityLabel.Name = "totalQuantityLabel";
            this.totalQuantityLabel.Size = new System.Drawing.Size(126, 37);
            this.totalQuantityLabel.TabIndex = 2;
            this.totalQuantityLabel.Text = "label1";
            // 
            // OrderDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.OrderDetailWhiteForm;
            this.ClientSize = new System.Drawing.Size(1336, 1024);
            this.Controls.Add(this.totalQuantityLabel);
            this.Controls.Add(this.OrderDetailList);
            this.Controls.Add(this.redirectMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetailPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderDetailPopup";
            ((System.ComponentModel.ISupportInitialize)(this.redirectMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redirectMain;
        private System.Windows.Forms.FlowLayoutPanel OrderDetailList;
        private System.Windows.Forms.Label totalQuantityLabel;
    }
}