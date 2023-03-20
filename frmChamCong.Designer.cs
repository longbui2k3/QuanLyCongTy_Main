namespace QuanLyCongTy
{
    partial class frmChamCong
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
            lblMSNV = new Label();
            label2 = new Label();
            txtMSNV = new TextBox();
            dtpChamCong = new DateTimePicker();
            btnCheckIn = new Button();
            btnCheckOut = new Button();
            btnNghi = new Button();
            dataGridView1 = new DataGridView();
            txtLiDo = new TextBox();
            lblTotal = new Label();
            btnShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblMSNV
            // 
            lblMSNV.AutoSize = true;
            lblMSNV.Location = new Point(49, 35);
            lblMSNV.Name = "lblMSNV";
            lblMSNV.Size = new Size(50, 20);
            lblMSNV.TabIndex = 0;
            lblMSNV.Text = "MSNV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 108);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "Ngày chấm công";
            // 
            // txtMSNV
            // 
            txtMSNV.Location = new Point(225, 32);
            txtMSNV.Name = "txtMSNV";
            txtMSNV.Size = new Size(328, 27);
            txtMSNV.TabIndex = 2;
            // 
            // dtpChamCong
            // 
            dtpChamCong.Location = new Point(225, 108);
            dtpChamCong.Name = "dtpChamCong";
            dtpChamCong.Size = new Size(250, 27);
            dtpChamCong.TabIndex = 3;
            // 
            // btnCheckIn
            // 
            btnCheckIn.Location = new Point(731, 16);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(157, 59);
            btnCheckIn.TabIndex = 4;
            btnCheckIn.Text = "CheckIn";
            btnCheckIn.UseVisualStyleBackColor = true;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(731, 97);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(157, 59);
            btnCheckOut.TabIndex = 5;
            btnCheckOut.Text = "CheckOut";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnNghi
            // 
            btnNghi.Location = new Point(731, 177);
            btnNghi.Name = "btnNghi";
            btnNghi.Size = new Size(157, 59);
            btnNghi.TabIndex = 6;
            btnNghi.Text = "Xin Nghi";
            btnNghi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 177);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(645, 291);
            dataGridView1.TabIndex = 7;
            // 
            // txtLiDo
            // 
            txtLiDo.Location = new Point(731, 259);
            txtLiDo.Name = "txtLiDo";
            txtLiDo.Size = new Size(228, 27);
            txtLiDo.TabIndex = 8;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(731, 319);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(40, 20);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "tong";
            // 
            // btnShow
            // 
            btnShow.Location = new Point(500, 94);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(157, 59);
            btnShow.TabIndex = 10;
            btnShow.Text = "Hien thi";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // frmChamCong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 480);
            Controls.Add(btnShow);
            Controls.Add(lblTotal);
            Controls.Add(txtLiDo);
            Controls.Add(dataGridView1);
            Controls.Add(btnNghi);
            Controls.Add(btnCheckOut);
            Controls.Add(btnCheckIn);
            Controls.Add(dtpChamCong);
            Controls.Add(txtMSNV);
            Controls.Add(label2);
            Controls.Add(lblMSNV);
            Name = "frmChamCong";
            Text = "frmChamCong";
            Load += frmChamCong_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMSNV;
        private Label label2;
        private TextBox txtMSNV;
        private DateTimePicker dtpChamCong;
        private Button btnCheckIn;
        private Button btnCheckOut;
        private Button btnNghi;
        private DataGridView dataGridView1;
        public void update()
        {
            dataGridView1.Columns.Add("CheckinTime", "Checkin Time");
            dataGridView1.Columns.Add("CheckoutTime", "Checkout Time");
        }

        private TextBox txtLiDo;
        private Label lblTotal;
        private Button btnShow;
    }
}