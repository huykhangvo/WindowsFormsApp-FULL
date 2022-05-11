namespace WindowsFormsApp_FULL
{
    partial class Bai10a
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
            this.khungnhap = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.khungketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số (0 --> 9)";
            // 
            // khungnhap
            // 
            this.khungnhap.Location = new System.Drawing.Point(66, 64);
            this.khungnhap.Multiline = true;
            this.khungnhap.Name = "khungnhap";
            this.khungnhap.Size = new System.Drawing.Size(184, 38);
            this.khungnhap.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // khungketqua
            // 
            this.khungketqua.Location = new System.Drawing.Point(427, 64);
            this.khungketqua.Multiline = true;
            this.khungketqua.Name = "khungketqua";
            this.khungketqua.Size = new System.Drawing.Size(122, 38);
            this.khungketqua.TabIndex = 3;
            // 
            // Bai10a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 221);
            this.Controls.Add(this.khungketqua);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.khungnhap);
            this.Controls.Add(this.label1);
            this.Name = "Bai10a";
            this.Text = "Bai10a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox khungnhap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox khungketqua;
    }
}