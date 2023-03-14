namespace QuanLyCongTy
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rb_HoTen = new System.Windows.Forms.RadioButton();
            this.rb_MaNV = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_PhongBan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.rb_HoTen);
            this.splitContainer1.Panel2.Controls.Add(this.rb_MaNV);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btn_Search);
            this.splitContainer1.Panel2.Controls.Add(this.txt_Search);
            this.splitContainer1.Panel2.Controls.Add(this.cb_TinhTrang);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.cb_PhongBan);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1384, 691);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 0;
            // 
            // rb_HoTen
            // 
            this.rb_HoTen.AutoSize = true;
            this.rb_HoTen.Checked = true;
            this.rb_HoTen.Location = new System.Drawing.Point(628, 93);
            this.rb_HoTen.Name = "rb_HoTen";
            this.rb_HoTen.Size = new System.Drawing.Size(94, 24);
            this.rb_HoTen.TabIndex = 19;
            this.rb_HoTen.TabStop = true;
            this.rb_HoTen.Text = "Họ và tên";
            this.rb_HoTen.UseVisualStyleBackColor = true;
            // 
            // rb_MaNV
            // 
            this.rb_MaNV.AutoSize = true;
            this.rb_MaNV.Location = new System.Drawing.Point(489, 93);
            this.rb_MaNV.Name = "rb_MaNV";
            this.rb_MaNV.Size = new System.Drawing.Size(118, 24);
            this.rb_MaNV.TabIndex = 18;
            this.rb_MaNV.Text = "Mã nhân viên";
            this.rb_MaNV.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tìm kiếm:";
            // 
            // btn_Search
            // 
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(424, 82);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(42, 42);
            this.btn_Search.TabIndex = 16;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Search.Location = new System.Drawing.Point(142, 83);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(262, 34);
            this.txt_Search.TabIndex = 15;
            // 
            // cb_TinhTrang
            // 
            this.cb_TinhTrang.FormattingEnabled = true;
            this.cb_TinhTrang.Location = new System.Drawing.Point(584, 24);
            this.cb_TinhTrang.Name = "cb_TinhTrang";
            this.cb_TinhTrang.Size = new System.Drawing.Size(151, 28);
            this.cb_TinhTrang.TabIndex = 14;
            this.cb_TinhTrang.Text = "--Tất cả--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(463, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tình trạng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Phòng ban:";
            // 
            // cb_PhongBan
            // 
            this.cb_PhongBan.FormattingEnabled = true;
            this.cb_PhongBan.Items.AddRange(new object[] {
            "--Tất cả phòng ban--"});
            this.cb_PhongBan.Location = new System.Drawing.Point(142, 23);
            this.cb_PhongBan.Name = "cb_PhongBan";
            this.cb_PhongBan.Size = new System.Drawing.Size(301, 28);
            this.cb_PhongBan.TabIndex = 11;
            this.cb_PhongBan.Text = "--Tất cả phòng ban--";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(873, 499);
            this.dataGridView1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 21;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 22;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 691);
            this.Controls.Add(this.splitContainer1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private RadioButton rb_HoTen;
        private RadioButton rb_MaNV;
        private Label label3;
        private Button btn_Search;
        private TextBox txt_Search;
        private ComboBox cb_TinhTrang;
        private Label label2;
        private Label label1;
        private ComboBox cb_PhongBan;
        private DataGridView dataGridView1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}