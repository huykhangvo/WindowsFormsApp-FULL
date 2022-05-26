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
    public partial class CongTyDuLich : Form
    {
        public CongTyDuLich()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Địa điểm xuất phát: " + lbVe.SelectedItem + "\r\n"
                + "Địa điểm đến: " + lbDi.SelectedItem;

        }

        private void CongTyDuLich_Load(object sender, EventArgs e)
        {
            lbDi.Items.Add("Hàn Quốc");
            lbDi.Items.Add("Thái lan");
            lbDi.Items.Add("Úc");

            lbVe.Items.Add("TPHCM");
            lbVe.Items.Add("Hà Nội");
            lbVe.Items.Add("Vũng Tàu");
        }

        private void ngayve_ValueChanged(object sender, EventArgs e)
        {
            txbTongNgay.Text = Convert.ToInt32((ngayve.Value - ngaydi.Value).TotalDays).ToString();
        }
    }
}
