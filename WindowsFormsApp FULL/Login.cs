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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbTK.Text == "admin" && txbMK.Text == "1")
            {
                MessageBox.Show("Đăng nhập thành công");
                var f = new main(txbTK.Text, txbMK.Text);
                this.Hide();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
}
