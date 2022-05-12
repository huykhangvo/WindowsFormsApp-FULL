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
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ngay = D.Text.ToString();
            String thang = M.Text.ToString();
            String nam = Y.Text.ToString();
            DateTime time = new DateTime(Convert.ToInt32(nam), Convert.ToInt32(thang), Convert.ToInt32(ngay));
            int thutrongtuan = (int)time.DayOfWeek;
            String thu = "";
            switch (thutrongtuan)
            {
                case 0:
                    thu = "Chủ nhật";
                    break;
                case 1:
                    thu = "Thứ hai";
                    break;
                case 2:
                    thu = "Thứ ba";
                    break;
                case 3:
                    thu = "Thứ tư";
                    break;
                case 4:
                    thu = "Thứ năm";
                    break;
                case 5:
                    thu = "Thứ sáu";
                    break;
                case 6:
                    thu = "Thứ bảy";
                    break;
            }
            khungketqua.Text = "Ngày " + ngay + " Tháng " + thang + " Năm " + nam + " Là " + thu;
        }
    }
}
