namespace QuanLyCongTy
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            tabControl1 = new TabControl();
            tc_taikhoan = new TabPage();
            button1 = new Button();
            button2 = new Button();
            tc_workplace = new TabPage();
            tc_crm = new TabPage();
            tc_hrm = new TabPage();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            splitContainer1 = new SplitContainer();
            tabControl1.SuspendLayout();
            tc_taikhoan.SuspendLayout();
            tc_hrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tc_taikhoan);
            tabControl1.Controls.Add(tc_workplace);
            tabControl1.Controls.Add(tc_crm);
            tabControl1.Controls.Add(tc_hrm);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1411, 192);
            tabControl1.TabIndex = 0;
            // 
            // tc_taikhoan
            // 
            tc_taikhoan.Controls.Add(button1);
            tc_taikhoan.Controls.Add(button2);
            tc_taikhoan.Location = new Point(4, 29);
            tc_taikhoan.Name = "tc_taikhoan";
            tc_taikhoan.Padding = new Padding(3);
            tc_taikhoan.Size = new Size(1403, 159);
            tc_taikhoan.TabIndex = 0;
            tc_taikhoan.Text = "Tài khoản";
            tc_taikhoan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(123, 137);
            button1.TabIndex = 0;
            button1.Text = "Đăng nhập";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseCompatibleTextRendering = true;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(123, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(122, 137);
            button2.TabIndex = 1;
            button2.Text = "Đăng Kí";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // tc_workplace
            // 
            tc_workplace.Location = new Point(4, 29);
            tc_workplace.Name = "tc_workplace";
            tc_workplace.Size = new Size(1403, 159);
            tc_workplace.TabIndex = 2;
            tc_workplace.Text = "Workplace";
            tc_workplace.UseVisualStyleBackColor = true;
            // 
            // tc_crm
            // 
            tc_crm.Location = new Point(4, 29);
            tc_crm.Name = "tc_crm";
            tc_crm.Size = new Size(1403, 159);
            tc_crm.TabIndex = 3;
            tc_crm.Text = "CRM";
            tc_crm.UseVisualStyleBackColor = true;
            // 
            // tc_hrm
            // 
            tc_hrm.Controls.Add(button8);
            tc_hrm.Controls.Add(button7);
            tc_hrm.Controls.Add(button6);
            tc_hrm.Controls.Add(button5);
            tc_hrm.Controls.Add(button4);
            tc_hrm.Controls.Add(button3);
            tc_hrm.Location = new Point(4, 29);
            tc_hrm.Name = "tc_hrm";
            tc_hrm.Size = new Size(1403, 159);
            tc_hrm.TabIndex = 4;
            tc_hrm.Text = "HRM";
            tc_hrm.UseVisualStyleBackColor = true;
            tc_hrm.Click += tc_hrm_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(615, 0);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(123, 137);
            button8.TabIndex = 6;
            button8.Text = "Tài Sản";
            button8.TextAlign = ContentAlignment.BottomCenter;
            button8.TextImageRelation = TextImageRelation.ImageAboveText;
            button8.UseCompatibleTextRendering = true;
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(492, 0);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(123, 137);
            button7.TabIndex = 5;
            button7.Text = "Quản Lý KPI";
            button7.TextAlign = ContentAlignment.BottomCenter;
            button7.TextImageRelation = TextImageRelation.ImageAboveText;
            button7.UseCompatibleTextRendering = true;
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(369, 0);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(123, 137);
            button6.TabIndex = 4;
            button6.Text = "Tiền Lương";
            button6.TextAlign = ContentAlignment.BottomCenter;
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(246, 0);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Size = new Size(123, 137);
            button5.TabIndex = 3;
            button5.Text = "Chấm Công";
            button5.TextAlign = ContentAlignment.BottomCenter;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseCompatibleTextRendering = true;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(123, 0);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(123, 137);
            button4.TabIndex = 2;
            button4.Text = "Nhân Sự";
            button4.TextAlign = ContentAlignment.BottomCenter;
            button4.TextImageRelation = TextImageRelation.ImageAboveText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(123, 137);
            button3.TabIndex = 1;
            button3.Text = "Tuyển Dụng";
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.TextImageRelation = TextImageRelation.ImageAboveText;
            button3.UseCompatibleTextRendering = true;
            button3.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl1);
            splitContainer1.Size = new Size(1411, 932);
            splitContainer1.SplitterDistance = 192;
            splitContainer1.SplitterWidth = 10;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1411, 932);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Main";
            Text = "Form1";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tc_taikhoan.ResumeLayout(false);
            tc_hrm.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tc_taikhoan;
        private Button button1;
        private Button button2;
        private TabPage tc_workplace;
        private TabPage tc_crm;
        private TabPage tc_hrm;
        private SplitContainer splitContainer1;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button8;
        private Button button7;
    }
}