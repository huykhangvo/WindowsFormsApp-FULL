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
    public partial class main : Form
    {
        private string username, password;
        public main()
        {
            InitializeComponent();
        }
        public main(string user, string pass)
        {
            InitializeComponent();
            this.username = user;
            this.password = pass;
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai2();
            f.ShowDialog();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai3();
            f.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai4();
            f.ShowDialog();
        }

        private void bài5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai5();
            f.ShowDialog();
        }

        private void bài6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai6();
            f.ShowDialog();
        }

        private void bài7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai7();
            f.ShowDialog();
        }

        private void bài9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai9();
            f.ShowDialog();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai10a();
            f.ShowDialog();
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai10b();
            f.ShowDialog();
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai10c();
            f.ShowDialog();
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai10d();
            f.ShowDialog();
        }

        private void bài11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai11();
            f.ShowDialog();
        }

        private void bài8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai8();
            f.ShowDialog();
        }

        private void bài12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Bai12();
            f.ShowDialog();
        }

        private void nhậpThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new NhapThongTinNguoiDung();
            f.ShowDialog();
        }

        private void côngTyDuLịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new CongTyDuLich();
            f.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            lbname.Text = username;
            lbpass.Text = password;
        }

        private void truyềnDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmCha();
            f.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new Login();
            f.ShowDialog();
        }
    }
}
