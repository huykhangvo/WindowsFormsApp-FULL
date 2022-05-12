namespace WindowsFormsApp_FULL
{
    partial class Bai8
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
            this.button1 = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.khungketqua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Y);
            this.groupBox1.Controls.Add(this.M);
            this.groupBox1.Controls.Add(this.D);
            this.groupBox1.Location = new System.Drawing.Point(36, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Ngày/tháng/năm";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm thứ trong tuần";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(7, 40);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(40, 22);
            this.D.TabIndex = 0;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(98, 40);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(40, 22);
            this.M.TabIndex = 1;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(181, 40);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(60, 22);
            this.Y.TabIndex = 2;
            // 
            // khungketqua
            // 
            this.khungketqua.Location = new System.Drawing.Point(36, 165);
            this.khungketqua.Multiline = true;
            this.khungketqua.Name = "khungketqua";
            this.khungketqua.Size = new System.Drawing.Size(330, 22);
            this.khungketqua.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "/";
            // 
            // Bai8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 203);
            this.Controls.Add(this.khungketqua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bai8";
            this.Text = "Bai8";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.TextBox D;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox khungketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}