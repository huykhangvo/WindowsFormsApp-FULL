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
    public partial class NhapThongTinNguoiDung : Form
    {
        List<string> listGioiTinh = new List<string>() { "Nam", "Nữ", "Khác" };
        public NhapThongTinNguoiDung()
        {
            InitializeComponent();
        }

        private void NhapThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            cbbGioiTinh.DataSource = listGioiTinh;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //chuẩn hoá 2 chuỗi
            string hoten = txbHoten.Text;
            string diachi = txbDiaChi.Text;
            if (kiemtraNhap())
            {
                xulychuanhoachuoi.suachuoi(ref hoten);
                xulychuanhoachuoi.suachuoi(ref diachi);

                txbThongTin.Text = "Họ Tên: " + hoten + Environment.NewLine
                    + "Ngày sinh: " + dtpkNgaySinh.Value.ToShortDateString() + Environment.NewLine
                    + "Giới tính: " + cbbGioiTinh.SelectedItem + Environment.NewLine
                    + "Địa chỉ: " + diachi + Environment.NewLine
                    + "CCCD: " + txbCCCD.Text;


                foreach (var item in groupBox1.Controls)
                {
                    TextBox item1 = item as TextBox;
                    if (item1 != null)
                    {
                        item1.Clear();
                    }
                }
                dtpkNgaySinh.Value = DateTime.Now;
            }




        }
        bool kiemtraNhap()
        {
            if (txbHoten.Text == "")
            {
                MessageBox.Show("Hãy nhập họ tên", "Thông báo");
                txbHoten.Focus();
                return false;
            }

            if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Hãy nhập địa chỉ", "Thông báo");
                txbDiaChi.Focus();
                return false;
            }

            if (txbCCCD.Text == "")
            {
                MessageBox.Show("Hãy nhập căn cước công dân", "Thông báo");
                txbCCCD.Focus();
                return false;
            }

            long ketqua;
            string cccd = txbCCCD.Text;
            if (!(long.TryParse(cccd, out ketqua)))
            {
                MessageBox.Show("Hãy nhập đúng định dạng số căn cước công dân", "Thông báo");
                txbCCCD.Focus();
                return false;
            }

            if (ketqua < 0)
            {
                MessageBox.Show("Số căn cước công dân không được âm", "Thông báo");
                txbCCCD.Focus();
                return false;
            }

            char[] mangCCCD = cccd.ToCharArray();
            if (mangCCCD.Length != 9)
            {
                MessageBox.Show("Số căn cước công dân phải đúng đủ 9 chữ số", "Thông báo");
                txbCCCD.Focus();
                return false;
            }

            return true;
        }
    }
}
