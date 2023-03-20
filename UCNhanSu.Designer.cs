namespace QuanLyCongTy
{
    partial class UCNhanSu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_NhanVien = new System.Windows.Forms.TabPage();
            this.tp_HopDong = new System.Windows.Forms.TabPage();
            this.tp_BaoHiem = new System.Windows.Forms.TabPage();
            this.tb_NghiBu = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_NhanVien);
            this.tabControl1.Controls.Add(this.tp_HopDong);
            this.tabControl1.Controls.Add(this.tp_BaoHiem);
            this.tabControl1.Controls.Add(this.tb_NghiBu);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1618, 725);
            this.tabControl1.TabIndex = 0;
            // 
            // tp_NhanVien
            // 
            this.tp_NhanVien.Location = new System.Drawing.Point(4, 29);
            this.tp_NhanVien.Name = "tp_NhanVien";
            this.tp_NhanVien.Padding = new System.Windows.Forms.Padding(3);
            this.tp_NhanVien.Size = new System.Drawing.Size(1610, 692);
            this.tp_NhanVien.TabIndex = 0;
            this.tp_NhanVien.Text = "Thông Tin Nhân Viên";
            this.tp_NhanVien.UseVisualStyleBackColor = true;
            this.tp_NhanVien.Click += new System.EventHandler(this.tp_NhanVien_Click);
            // 
            // tp_HopDong
            // 
            this.tp_HopDong.Location = new System.Drawing.Point(4, 29);
            this.tp_HopDong.Name = "tp_HopDong";
            this.tp_HopDong.Padding = new System.Windows.Forms.Padding(3);
            this.tp_HopDong.Size = new System.Drawing.Size(1412, 700);
            this.tp_HopDong.TabIndex = 1;
            this.tp_HopDong.Text = "Hợp Đồng Lao Động";
            this.tp_HopDong.UseVisualStyleBackColor = true;
            // 
            // tp_BaoHiem
            // 
            this.tp_BaoHiem.Location = new System.Drawing.Point(4, 29);
            this.tp_BaoHiem.Name = "tp_BaoHiem";
            this.tp_BaoHiem.Size = new System.Drawing.Size(1412, 700);
            this.tp_BaoHiem.TabIndex = 2;
            this.tp_BaoHiem.Text = "Đóng Bảo Hiểm";
            this.tp_BaoHiem.UseVisualStyleBackColor = true;
            // 
            // tb_NghiBu
            // 
            this.tb_NghiBu.Location = new System.Drawing.Point(4, 29);
            this.tb_NghiBu.Name = "tb_NghiBu";
            this.tb_NghiBu.Padding = new System.Windows.Forms.Padding(3);
            this.tb_NghiBu.Size = new System.Drawing.Size(1412, 700);
            this.tb_NghiBu.TabIndex = 3;
            this.tb_NghiBu.Text = "Nghỉ Bù";
            this.tb_NghiBu.UseVisualStyleBackColor = true;
            // 
            // UCNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UCNhanSu";
            this.Size = new System.Drawing.Size(1618, 725);
            this.Load += new System.EventHandler(this.UCNhanSu_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tp_NhanVien;
        private TabPage tp_HopDong;
        private TabPage tp_BaoHiem;
        private TabPage tb_NghiBu;
    }
}
