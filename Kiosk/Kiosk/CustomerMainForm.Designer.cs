namespace Kiosk
{
    partial class CustomerMainForm
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
            this.categoryflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.orderDetail = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryflowLayoutPanel
            // 
            this.categoryflowLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.categoryflowLayoutPanel.Location = new System.Drawing.Point(12, 65);
            this.categoryflowLayoutPanel.Name = "categoryflowLayoutPanel";
            this.categoryflowLayoutPanel.Size = new System.Drawing.Size(145, 498);
            this.categoryflowLayoutPanel.TabIndex = 0;
            // 
            // orderDetail
            // 
            this.orderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.orderDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.orderDetail.Image = global::Kiosk.Properties.Resources.orderdetailbutton2;
            this.orderDetail.Location = new System.Drawing.Point(17, 851);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(141, 64);
            this.orderDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderDetail.TabIndex = 1;
            this.orderDetail.TabStop = false;
            this.orderDetail.Click += new System.EventHandler(this.orderDetail_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::Kiosk.Properties.Resources.Call;
            this.pictureBox2.Location = new System.Drawing.Point(16, 934);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::Kiosk.Properties.Resources._15_테이블;
            this.pictureBox3.Location = new System.Drawing.Point(1099, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(118, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Exit.ForeColor = System.Drawing.Color.Firebrick;
            this.Exit.Location = new System.Drawing.Point(39, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(89, 19);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "종료하기";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.CustomerFormImg;
            this.ClientSize = new System.Drawing.Size(1336, 1024);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.orderDetail);
            this.Controls.Add(this.categoryflowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainForm";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel categoryflowLayoutPanel;
        private System.Windows.Forms.PictureBox orderDetail;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Exit;
    }
}