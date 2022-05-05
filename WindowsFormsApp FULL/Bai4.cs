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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            Double bankinh = float.Parse(txtbankinh.Text);
            Double PI = 3.14;
            Double chuvi = 2 * PI * bankinh;
            Double dientich = PI * bankinh * bankinh;

            kqchuvi.Text = chuvi.ToString();
            kqdt.Text = dientich.ToString();
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            txtbankinh.ResetText();
            kqchuvi.ResetText();
            kqdt.ResetText();
        }
    }
}
