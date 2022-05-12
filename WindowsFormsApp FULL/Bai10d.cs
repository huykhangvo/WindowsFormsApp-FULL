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
    public partial class Bai10d : Form
    {
        public Bai10d()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int batdau = Convert.ToInt32(SoBatDau.Text);
            int ketthuc = Convert.ToInt32(SoKetThuc.Text);
            int S = 0;

            for (int i = batdau; i <= ketthuc; i++)
            {
                S += i;
            }

            kqtong.Text = S.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double batdau = Convert.ToDouble(SoBatDau.Text);
            Double ketthuc = Convert.ToDouble(SoKetThuc.Text);
            Double Tich = 1;
            for (Double i = batdau; i <= ketthuc; i++)
            {
                Tich *= i;
            }

            kqtich.Text = Tich.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int batdau = Convert.ToInt32(SoBatDau.Text);
            int ketthuc = Convert.ToInt32(SoKetThuc.Text);
            int Tich = 0;
            for (int i = batdau; i <= ketthuc; i++)
            {
                if (i % 2 == 0)
                {
                    Tich += i;
                }
            }

            kqtongchan.Text = Tich.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int batdau = Convert.ToInt32(SoBatDau.Text);
            int ketthuc = Convert.ToInt32(SoKetThuc.Text);
            int Tich = 0;
            for (int i = batdau; i <= ketthuc; i++)
            {
                if (i % 2 == 1)
                {
                    Tich += i;
                }
            }

            kqtongle.Text = Tich.ToString();
        }
    }
}
