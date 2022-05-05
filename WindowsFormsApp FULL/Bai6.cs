using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_FULL
{
    public partial class Bai6 : Form
    {
        public Bai6()
        {
            InitializeComponent();
        }

        static char pheptinh;
        private void Bai6_Load(object sender, EventArgs e)
        {

        }

        private void cong_Click(object sender, EventArgs e)
        {
            pheptinh = '+';
        }

        private void Trừ_Click(object sender, EventArgs e)
        {
            pheptinh = '-';
        }

        private void Nhân_Click(object sender, EventArgs e)
        {
            pheptinh = '*';
        }

        private void Chia_Click(object sender, EventArgs e)
        {
            pheptinh = '/';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double soa = Convert.ToDouble(a.Text);
            Double sob = Convert.ToDouble(b.Text);
            Double ketqua = 0;
            switch (pheptinh)
            {
                case '+':
                    ketqua = soa + sob;
                    break;
                case '-':
                    ketqua = soa - sob;
                    break;
                case '*':
                    ketqua = soa * sob;
                    break;
                case '/':
                    ketqua = soa / sob;
                    break;

            }
            kq.Text = ketqua.ToString();
            a.ReadOnly = true;
            b.ReadOnly = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a.ResetText();
            b.ResetText();
            kq.ResetText();

            a.ReadOnly = false;
            b.ReadOnly = false;
            a.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
