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
    public partial class Bai10c : Form
    {
        public Bai10c()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a = Convert.ToDouble(txtA.Text);
            Double b = Convert.ToDouble(txtB.Text);
            if (a > b)
            {
                max.Text = a.ToString();
            }
            else
            {
                max.Text = b.ToString();
            }

        }
    }
}
