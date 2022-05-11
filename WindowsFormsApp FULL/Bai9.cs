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
    public partial class Bai9 : Form
    {
        public Bai9()
        {
            InitializeComponent();
        }

        private void btnTinhTongDiem_Click(object sender, EventArgs e)
        {
            Double toan = Convert.ToDouble(txtToan.Text);
            Double ly = Convert.ToDouble(txtLy.Text);
            Double hoa = Convert.ToDouble(txtHoa.Text);
            Double ketqua = toan + ly + hoa;
            txtTongDiem.Text = ketqua.ToString();

            txtToan.ReadOnly = true;
            txtLy.ReadOnly = true;
            txtHoa.ReadOnly = true;

        }

        private void btnXetKetQua_Click(object sender, EventArgs e)
        {
            Double DiemChuan = Convert.ToDouble(txtDiemChuan.Text);
            Double TongDiem = Convert.ToDouble(txtTongDiem.Text);
            if(DiemChuan <= TongDiem)
            {
                txtKetQuaThi.Text = "Đậu";
            }
            else
            {
                txtKetQuaThi.Text = "Rớt";
            }
            txtDiemChuan.ReadOnly = true;
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {

            txtToan.ResetText();
            txtLy.ResetText();
            txtHoa.ResetText();
            txtDiemChuan.ResetText();
            txtTongDiem.ResetText();
            txtKetQuaThi.ResetText();

            txtToan.ReadOnly = false;
            txtLy.ReadOnly = false;
            txtHoa.ReadOnly = false;
            txtDiemChuan.ReadOnly = false;

            txtToan.Focus();
        }
    }
}
