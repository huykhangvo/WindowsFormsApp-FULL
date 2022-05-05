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
        public main()
        {
            InitializeComponent();
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
    }
}
