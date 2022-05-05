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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {
            lbNgayThu.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChiSoCu.Text))
            {
                MessageBox.Show("Vui lòng nhập chỉ số cũ", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCu.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtChiSoMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập chỉ số mới", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCu.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá", "Ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChiSoCu.Select();
                return;
            }
            float chisocu = float.Parse(txtChiSoCu.Text);
            float chisomoi = float.Parse(txtChiSoMoi.Text);
            float dongia = float.Parse(txtDonGia.Text);
            float thanhtien = (chisomoi - chisocu) * dongia;
            txtThanhTien.Text = thanhtien.ToString();

            txtKhachHang.ReadOnly = true;
            txtChiSoCu.ReadOnly = true;
            txtChiSoMoi.ReadOnly = true;
            txtDonGia.ReadOnly = true;
        }

        private void txtChiSoCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chỉ cho phép nhập số
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtKhachHang.ResetText();
            txtChiSoCu.ResetText();
            txtChiSoMoi.ResetText();
            txtDonGia.ResetText();

            txtKhachHang.ReadOnly = false;
            txtChiSoCu.ReadOnly = false;
            txtChiSoMoi.ReadOnly = false;
            txtDonGia.ReadOnly = false;
            txtKhachHang.Focus();
        }
    }
}
