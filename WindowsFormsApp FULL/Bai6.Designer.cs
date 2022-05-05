namespace WindowsFormsApp_FULL
{
    partial class Bai6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.kq = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.Trừ = new System.Windows.Forms.Button();
            this.Chia = new System.Windows.Forms.Button();
            this.Nhân = new System.Windows.Forms.Button();
            this.cong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả=";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(77, 23);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(44, 22);
            this.a.TabIndex = 3;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(77, 64);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(44, 22);
            this.b.TabIndex = 4;
            // 
            // kq
            // 
            this.kq.Location = new System.Drawing.Point(77, 94);
            this.kq.Name = "kq";
            this.kq.ReadOnly = true;
            this.kq.Size = new System.Drawing.Size(120, 22);
            this.kq.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tính";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 55);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 28);
            this.button6.TabIndex = 12;
            this.button6.Text = "Làm mới";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(215, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 28);
            this.button7.TabIndex = 13;
            this.button7.Text = "Thoát";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Trừ
            // 
            this.Trừ.Location = new System.Drawing.Point(39, 7);
            this.Trừ.Name = "Trừ";
            this.Trừ.Size = new System.Drawing.Size(33, 32);
            this.Trừ.TabIndex = 10;
            this.Trừ.Text = "-";
            this.Trừ.UseVisualStyleBackColor = true;
            this.Trừ.Click += new System.EventHandler(this.Trừ_Click);
            // 
            // Chia
            // 
            this.Chia.Location = new System.Drawing.Point(39, 45);
            this.Chia.Name = "Chia";
            this.Chia.Size = new System.Drawing.Size(33, 32);
            this.Chia.TabIndex = 9;
            this.Chia.Text = "/";
            this.Chia.UseVisualStyleBackColor = true;
            this.Chia.Click += new System.EventHandler(this.Chia_Click);
            // 
            // Nhân
            // 
            this.Nhân.Location = new System.Drawing.Point(2, 45);
            this.Nhân.Name = "Nhân";
            this.Nhân.Size = new System.Drawing.Size(33, 32);
            this.Nhân.TabIndex = 8;
            this.Nhân.Text = "*";
            this.Nhân.UseVisualStyleBackColor = true;
            this.Nhân.Click += new System.EventHandler(this.Nhân_Click);
            // 
            // cong
            // 
            this.cong.Location = new System.Drawing.Point(2, 8);
            this.cong.Name = "cong";
            this.cong.Size = new System.Drawing.Size(33, 32);
            this.cong.TabIndex = 6;
            this.cong.Text = "+";
            this.cong.UseVisualStyleBackColor = true;
            this.cong.Click += new System.EventHandler(this.cong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cong);
            this.groupBox1.Controls.Add(this.Nhân);
            this.groupBox1.Controls.Add(this.Chia);
            this.groupBox1.Controls.Add(this.Trừ);
            this.groupBox1.Location = new System.Drawing.Point(127, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(76, 82);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 130);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kq);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox kq;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button Trừ;
        private System.Windows.Forms.Button Chia;
        private System.Windows.Forms.Button Nhân;
        private System.Windows.Forms.Button cong;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}