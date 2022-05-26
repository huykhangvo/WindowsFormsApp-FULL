namespace WindowsFormsApp_FULL
{
    partial class NhapThongTinNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txbCCCD = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbHoten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbThongTin = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dtpkNgaySinh);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.txbCCCD);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.txbHoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Location = new System.Drawing.Point(109, 78);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(314, 22);
            this.dtpkNgaySinh.TabIndex = 11;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(242, 209);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 35);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(149, 208);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(82, 35);
            this.btnNhap.TabIndex = 9;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Location = new System.Drawing.Point(346, 168);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(77, 24);
            this.cbbGioiTinh.TabIndex = 8;
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(109, 168);
            this.txbCCCD.Multiline = true;
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(146, 25);
            this.txbCCCD.TabIndex = 7;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(109, 120);
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(314, 25);
            this.txbDiaChi.TabIndex = 6;
            // 
            // txbHoten
            // 
            this.txbHoten.Location = new System.Drawing.Point(109, 30);
            this.txbHoten.Multiline = true;
            this.txbHoten.Name = "txbHoten";
            this.txbHoten.Size = new System.Drawing.Size(314, 25);
            this.txbHoten.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CCCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbThongTin);
            this.panel1.Location = new System.Drawing.Point(12, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 287);
            this.panel1.TabIndex = 1;
            // 
            // txbThongTin
            // 
            this.txbThongTin.Location = new System.Drawing.Point(4, 4);
            this.txbThongTin.Multiline = true;
            this.txbThongTin.Name = "txbThongTin";
            this.txbThongTin.ReadOnly = true;
            this.txbThongTin.Size = new System.Drawing.Size(448, 280);
            this.txbThongTin.TabIndex = 0;
            // 
            // NhapThongTinNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NhapThongTinNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapThongTinNguoiDung";
            this.Load += new System.EventHandler(this.NhapThongTinNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.TextBox txbCCCD;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbHoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbThongTin;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
    }
}