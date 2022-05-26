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
    public partial class frmCha : Form
    {
        public frmCha()
        {
            InitializeComponent();
        }
        private void LoadData(string data)
        {
            txbChaNhan.Text = "";
            txbChaNhan.Text = data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var f = new frmCon();
            f.truyenData = new frmCon.TruyenChoCha(LoadData);
            f.ShowDialog();
        }
    }
}
