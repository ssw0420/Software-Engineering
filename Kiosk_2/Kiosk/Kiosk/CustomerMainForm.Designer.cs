namespace Kiosk
{
    partial class CustomerMainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MenuList = new System.Windows.Forms.TableLayoutPanel();
            this.CategoryList = new System.Windows.Forms.FlowLayoutPanel();
            this.orderDetail = new System.Windows.Forms.PictureBox();
            this.callManager = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.callManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.label1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MenuList
            // 
            this.MenuList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MenuList.ColumnCount = 3;
            this.MenuList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.MenuList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MenuList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.MenuList.Location = new System.Drawing.Point(232, 262);
            this.MenuList.Name = "MenuList";
            this.MenuList.RowCount = 2;
            this.MenuList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.MenuList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MenuList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MenuList.Size = new System.Drawing.Size(678, 670);
            this.MenuList.TabIndex = 1;
            // 
            // CategoryList
            // 
            this.CategoryList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.CategoryList.Location = new System.Drawing.Point(15, 86);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(142, 597);
            this.CategoryList.TabIndex = 2;
            // 
            // orderDetail
            // 
            this.orderDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.orderDetail.Image = global::Kiosk.Properties.Resources.OrderDetailButton;
            this.orderDetail.Location = new System.Drawing.Point(15, 846);
            this.orderDetail.Name = "orderDetail";
            this.orderDetail.Size = new System.Drawing.Size(141, 64);
            this.orderDetail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orderDetail.TabIndex = 3;
            this.orderDetail.TabStop = false;
            this.orderDetail.Click += new System.EventHandler(this.orderDetail_Click);
            // 
            // callManager
            // 
            this.callManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(226)))));
            this.callManager.Image = global::Kiosk.Properties.Resources.CallManagerButton;
            this.callManager.Location = new System.Drawing.Point(15, 937);
            this.callManager.Name = "callManager";
            this.callManager.Size = new System.Drawing.Size(141, 64);
            this.callManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.callManager.TabIndex = 4;
            this.callManager.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1017, 203);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(282, 634);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kiosk.Properties.Resources.CustomerMainForm_TablePlus;
            this.ClientSize = new System.Drawing.Size(1336, 1024);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.callManager);
            this.Controls.Add(this.orderDetail);
            this.Controls.Add(this.CategoryList);
            this.Controls.Add(this.MenuList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.callManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel MenuList;
        private System.Windows.Forms.FlowLayoutPanel CategoryList;
        private System.Windows.Forms.PictureBox orderDetail;
        private System.Windows.Forms.PictureBox callManager;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

