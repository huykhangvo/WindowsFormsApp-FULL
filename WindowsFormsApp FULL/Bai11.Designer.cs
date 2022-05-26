namespace WindowsFormsApp_FULL
{
    partial class Bai11
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
            this.cbb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.khungnhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.khungnhap);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // cbb
            // 
            this.cbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb.FormattingEnabled = true;
            this.cbb.Location = new System.Drawing.Point(24, 73);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(190, 24);
            this.cbb.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // khungnhap
            // 
            this.khungnhap.Location = new System.Drawing.Point(24, 34);
            this.khungnhap.Name = "khungnhap";
            this.khungnhap.Size = new System.Drawing.Size(100, 22);
            this.khungnhap.TabIndex = 0;
            this.khungnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.khungnhap_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl);
            this.groupBox2.Location = new System.Drawing.Point(281, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lbl
            // 
            this.lbl.FormattingEnabled = true;
            this.lbl.ItemHeight = 16;
            this.lbl.Location = new System.Drawing.Point(6, 30);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(312, 148);
            this.lbl.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(287, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(318, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tổng các ước số";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(287, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(318, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "Số lượng các ước số chẵn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(287, 334);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(318, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "Số lượng các số nguyên tố";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Bai11
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 381);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.Load += new System.EventHandler(this.Bai11_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb;
        private System.Windows.Forms.TextBox khungnhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
    }
}