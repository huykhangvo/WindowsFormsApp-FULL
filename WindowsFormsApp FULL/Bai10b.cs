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
    public partial class Bai10b : Form
    {
        public Bai10b()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(khungnhap.Text);
            string s = "";
            for (int i = 1; i <= 10; i++)
                {
                s += n.ToString() + " x " + i.ToString() + " = " + (n * i).ToString() + Environment.NewLine;
            }
            khungketqua.Text = "\n\n\n\n" + s;
           
        }
    }
}
