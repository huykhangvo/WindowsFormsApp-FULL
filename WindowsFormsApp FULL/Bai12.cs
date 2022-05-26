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
    public partial class Bai12 : Form
    {
        public Bai12()
        {
            InitializeComponent();
        }

        private void Bai12_Load(object sender, EventArgs e)
        {
            khungnhap.Focus();
        }

        bool Kiem_Tra_ListBox()
        {
            if (lbHienThi.Items.Count > 0)
                return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(khungnhap.Text);

                lbHienThi.Items.Add(khungnhap.Text.Trim());

                khungnhap.ResetText();
                khungnhap.Focus();

            }
            catch (Exception)
            {
                MessageBox.Show("Phải nhập kiểu số nguyên!", "Error",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
                khungnhap.ResetText();
                khungnhap.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int result = 0;
            for (int i = 0; i < lbHienThi.Items.Count; i++)
                result += Convert.ToInt32(lbHienThi.Items[i].ToString());
            MessageBox.Show("Tổng các phần tử trong list: " + result);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn chắc có thoát không?", "Thông báo"
                , MessageBoxButtons.OKCancel
                , MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Kiem_Tra_ListBox())
            {
                lbHienThi.Items.RemoveAt(0);//Xoá pt đầu
                lbHienThi.Items.RemoveAt(lbHienThi.Items.Count - 1);//Xoá pt cuối
            }
            else
                MessageBox.Show("List trống, không xoá được?", "Thông báo"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Kiem_Tra_ListBox())
                while (lbHienThi.SelectedItems.Count > 0)
                    lbHienThi.Items.Remove(lbHienThi.SelectedItem);
            else
                MessageBox.Show("List trống, không xoá được?", "Thông báo"
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int n = lbHienThi.Items.Count;
            for(int i = 0; i < n; i++)
            {
                lbHienThi.Items[i] = Convert.ToInt32(lbHienThi.Items[i]) + 2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            int result = 0;
            int n = lbHienThi.Items.Count;
            for (int i = 0; i < n; i++) 
            { 
                if (Convert.ToInt32(lbHienThi.Items[i]) % 2 == 0)
                {
                    result = Convert.ToInt32(lbHienThi.Items[i].ToString());
                    MessageBox.Show("Số chẵn được chọn là: " + result);
                }
            }
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int result = 0;
            int n = lbHienThi.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(lbHienThi.Items[i]) % 2 != 0)
                {
                    result = Convert.ToInt32(lbHienThi.Items[i].ToString());
                    MessageBox.Show("Số lẻ được chọn là: " + result);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = lbHienThi.Items.Count - 1; i >= 0; i--)
                
            {
                if (!String.IsNullOrEmpty(lbHienThi.Items[i] as String))
                {
                    double tmp = double.Parse((lbHienThi.Items[i].ToString()));
                    tmp = Math.Pow(tmp, 2);
                    lbHienThi.Items[i] = tmp.ToString();
                }
            }
        }
    }
}
