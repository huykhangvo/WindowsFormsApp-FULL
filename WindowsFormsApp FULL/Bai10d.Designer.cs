namespace WindowsFormsApp_FULL
{
    partial class Bai10d
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SoBatDau = new System.Windows.Forms.TextBox();
            this.SoKetThuc = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kqtong = new System.Windows.Forms.TextBox();
            this.kqtich = new System.Windows.Forms.TextBox();
            this.kqtongchan = new System.Windows.Forms.TextBox();
            this.kqtongle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.SoKetThuc);
            this.groupBox1.Controls.Add(this.SoBatDau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Nhập giới hạn của dãy số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số kết thúc";
            // 
            // SoBatDau
            // 
            this.SoBatDau.Location = new System.Drawing.Point(166, 38);
            this.SoBatDau.Name = "SoBatDau";
            this.SoBatDau.Size = new System.Drawing.Size(60, 30);
            this.SoBatDau.TabIndex = 2;
            // 
            // SoKetThuc
            // 
            this.SoKetThuc.Location = new System.Drawing.Point(372, 38);
            this.SoKetThuc.Name = "SoKetThuc";
            this.SoKetThuc.Size = new System.Drawing.Size(60, 30);
            this.SoKetThuc.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.kqtongle);
            this.groupBox2.Controls.Add(this.kqtongchan);
            this.groupBox2.Controls.Add(this.kqtich);
            this.groupBox2.Controls.Add(this.kqtong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tổng các số";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tích các số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tổng các số chẳn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng các số lẻ";
            // 
            // kqtong
            // 
            this.kqtong.Location = new System.Drawing.Point(190, 45);
            this.kqtong.Name = "kqtong";
            this.kqtong.Size = new System.Drawing.Size(131, 30);
            this.kqtong.TabIndex = 4;
            // 
            // kqtich
            // 
            this.kqtich.Location = new System.Drawing.Point(190, 100);
            this.kqtich.Name = "kqtich";
            this.kqtich.Size = new System.Drawing.Size(131, 30);
            this.kqtich.TabIndex = 5;
            // 
            // kqtongchan
            // 
            this.kqtongchan.Location = new System.Drawing.Point(190, 150);
            this.kqtongchan.Name = "kqtongchan";
            this.kqtongchan.Size = new System.Drawing.Size(131, 30);
            this.kqtongchan.TabIndex = 6;
            // 
            // kqtongle
            // 
            this.kqtongle.Location = new System.Drawing.Point(190, 211);
            this.kqtongle.Name = "kqtongle";
            this.kqtongle.Size = new System.Drawing.Size(131, 30);
            this.kqtongle.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tính tổng các số";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(327, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Tính tích các số";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(327, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 30);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tổng các số chẳn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(327, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Tổng các số lẻ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Bai10d
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai10d";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tính toán trên dãy số";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox SoKetThuc;
        private System.Windows.Forms.TextBox SoBatDau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kqtongle;
        private System.Windows.Forms.TextBox kqtongchan;
        private System.Windows.Forms.TextBox kqtich;
        private System.Windows.Forms.TextBox kqtong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}