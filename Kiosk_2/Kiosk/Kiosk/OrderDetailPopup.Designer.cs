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
            ((System.ComponentModel.ISupportInitialize)(this.redirectMain)).BeginInit();
            this.SuspendLayout();
            // 
            // redirectMain
            // 
            this.redirectMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
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
            this.OrderDetailList.Location = new System.Drawing.Point(38, 179);
            this.OrderDetailList.Name = "OrderDetailList";
            this.OrderDetailList.Size = new System.Drawing.Size(1127, 615);
            this.OrderDetailList.TabIndex = 1;
            // 
            // OrderDetailPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.OrderDetailForm_TablePlus;
            this.ClientSize = new System.Drawing.Size(1336, 1024);
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
    }
}