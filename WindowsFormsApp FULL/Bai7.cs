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
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nhapgio.Text.Trim() == "")
            {
                MessageBox.Show("Bạn không thể để trống");
                return;
            }
            Double time = Convert.ToDouble(nhapgio.Text);
            if (time >= 5 && time < 12)
            {
                MessageBox.Show("Good Morning");
            }else if(time >= 12 && time < 18)
            {
                MessageBox.Show("Good Afternoon");
            }else
            {
                MessageBox.Show("Good Night");
            }
        }

        private void nhapgio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ':'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu 2 chấm
            if ((e.KeyChar == ':') && ((sender as TextBox).Text.IndexOf(':') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
