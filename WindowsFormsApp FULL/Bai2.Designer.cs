namespace WindowsFormsApp_FULL
{
    partial class Bai2
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
            this.khunghoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hienthi = new System.Windows.Forms.Label();
            this.btnchao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // khunghoten
            // 
            this.khunghoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khunghoten.ForeColor = System.Drawing.Color.Blue;
            this.khunghoten.Location = new System.Drawing.Point(391, 172);
            this.khunghoten.Multiline = true;
            this.khunghoten.Name = "khunghoten";
            this.khunghoten.Size = new System.Drawing.Size(284, 36);
            this.khunghoten.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(167, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ tên của bạn:";
            // 
            // hienthi
            // 
            this.hienthi.AutoSize = true;
            this.hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hienthi.ForeColor = System.Drawing.Color.Blue;
            this.hienthi.Location = new System.Drawing.Point(75, 303);
            this.hienthi.Name = "hienthi";
            this.hienthi.Size = new System.Drawing.Size(0, 29);
            this.hienthi.TabIndex = 2;
            // 
            // btnchao
            // 
            this.btnchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchao.Location = new System.Drawing.Point(512, 293);
            this.btnchao.Name = "btnchao";
            this.btnchao.Size = new System.Drawing.Size(130, 49);
            this.btnchao.TabIndex = 4;
            this.btnchao.Text = "Chào";
            this.btnchao.UseVisualStyleBackColor = true;
            this.btnchao.Click += new System.EventHandler(this.btnchao_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnchao);
            this.Controls.Add(this.hienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.khunghoten);
            this.Name = "Bai2";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox khunghoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hienthi;
        private System.Windows.Forms.Button btnchao;
    }
}

