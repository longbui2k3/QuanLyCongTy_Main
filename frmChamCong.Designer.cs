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
            this.lblMSNV = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.dtpChamCong = new System.Windows.Forms.DateTimePicker();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnNghi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLiDo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMSNV
            // 
            this.lblMSNV.AutoSize = true;
            this.lblMSNV.Location = new System.Drawing.Point(49, 35);
            this.lblMSNV.Name = "lblMSNV";
            this.lblMSNV.Size = new System.Drawing.Size(50, 20);
            this.lblMSNV.TabIndex = 0;
            this.lblMSNV.Text = "MSNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày chấm công";
            // 
            // txtMSNV
            // 
            this.txtMSNV.Location = new System.Drawing.Point(225, 32);
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(328, 27);
            this.txtMSNV.TabIndex = 2;
            // 
            // dtpChamCong
            // 
            this.dtpChamCong.Location = new System.Drawing.Point(225, 108);
            this.dtpChamCong.Name = "dtpChamCong";
            this.dtpChamCong.Size = new System.Drawing.Size(250, 27);
            this.dtpChamCong.TabIndex = 3;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Location = new System.Drawing.Point(731, 16);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(157, 59);
            this.btnCheckIn.TabIndex = 4;
            this.btnCheckIn.Text = "CheckIn";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(731, 97);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(157, 59);
            this.btnCheckOut.TabIndex = 5;
            this.btnCheckOut.Text = "CheckOut";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            // 
            // btnNghi
            // 
            this.btnNghi.Location = new System.Drawing.Point(731, 177);
            this.btnNghi.Name = "btnNghi";
            this.btnNghi.Size = new System.Drawing.Size(157, 59);
            this.btnNghi.TabIndex = 6;
            this.btnNghi.Text = "Xin Nghi";
            this.btnNghi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(645, 291);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtLiDo
            // 
            this.txtLiDo.Location = new System.Drawing.Point(731, 259);
            this.txtLiDo.Name = "txtLiDo";
            this.txtLiDo.Size = new System.Drawing.Size(228, 27);
            this.txtLiDo.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(731, 319);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 20);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "tong";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(500, 94);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(157, 59);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Hien thi";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // frmChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 480);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtLiDo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnNghi);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.dtpChamCong);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMSNV);
            this.Name = "frmChamCong";
            this.Text = "frmChamCong";
            this.Load += new System.EventHandler(this.frmChamCong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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