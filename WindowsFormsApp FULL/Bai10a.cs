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
    public partial class Bai10a : Form
    {
        public Bai10a()
        {
            InitializeComponent();
        }
        private string don_vi(int n)
        {
            switch (n)
            {
                case 0: return "Không";
                case 1: return "Một";
                case 2: return "Hai";
                case 3: return "Ba";
                case 4: return "Bốn";
                case 5: return "Năm";
                case 6: return "Sáu";
                case 7: return "Bảy";
                case 8: return "Tám";
                default: return "Chín";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s, s1, k1;
            int d;
            s = khungnhap.Text;
            if(s.Length == 1)
            {
                k1 = s.Substring(s.Length - 1, 1);
                d = int.Parse(k1);
                s1 = don_vi(d);
                khungketqua.Text = s1;
            }
            else
            {
                khungketqua.Text = "Chua lap trinh toi";
            }
        }
    }
}
