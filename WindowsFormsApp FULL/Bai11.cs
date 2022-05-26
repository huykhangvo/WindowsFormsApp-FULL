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
    public partial class Bai11 : Form
    {
        public Bai11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void Bai11_Load(object sender, EventArgs e)
        {
            khungnhap.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl.Items.Clear();
            int son = Convert.ToInt32(cbb.SelectedItem);
            String s = "số được chọn: ";
            if (cbb.SelectedIndex >= 0) { 
                int sum = 0;
                    for (int i = 1; i <= son; i++)
                    {
                        if (son % i == 0)
                        {
                            sum += i;
                        }
                    }
                lbl.Text = s + cbb.SelectedItem.ToString();

                lbl.Items.Add(sum.ToString());

                lbl.Text = lbl.Items.Count.ToString();
            }
            else
                MessageBox.Show("Bạn chưa chọn");
        }

        private void khungnhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            Clipboard.Clear(); //Không cho dán dữ liệu Ctrl + v
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl.Items.Clear();
            int son = Convert.ToInt32(cbb.SelectedItem);


            String s = "số được chọn: ";
            if (cbb.SelectedIndex >= 0)
            {
                for (int i = 1; i <= son; i++)
                {
                    if (son % i == 0)
                    {
                        lbl.Text = s + cbb.SelectedItem.ToString();

                        lbl.Items.Add(i.ToString());

                        lbl.Text = lbl.Items.Count.ToString();
                    }
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn");
        }

        int isPrimeNumber(int n)
        {
            // so nguyen n < 2 khong phai la so nguyen to
            if (n < 2)
            {
                return 0;
            }
            // check so nguyen to khi n >= 2
            int i;
            int squareRoot = (int)Math.Sqrt(n);
            for (i = 2; i <= squareRoot; i++)
            {
                if (n % i == 0)
                {
                    return 0;
                }
            }
            return 1;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            lbl.Items.Clear();
            int son = Convert.ToInt32(cbb.SelectedItem);
            String s = "số được chọn: ";
            if (cbb.SelectedIndex >= 0)
            {
                if (son < 2)
                {
                    MessageBox.Show(son + " Không phải là số nguyên tố");
                }
                    int count = 0;
                    for (int i = 2; i <= Math.Sqrt(son); i++)
                    {
                        if (son % i == 0)
                        {
                            count++;
                        }
                    }
                    if (count == 0)
                    {
                            for (int i = 2; i <= son; i ++)
                            {
                                if (isPrimeNumber(i) == 1)
                                {
                                    lbl.Text = s + cbb.SelectedItem.ToString();

                                    lbl.Items.Add(i.ToString());

                                    lbl.Text = lbl.Items.Count.ToString();
                                }
                            }
                    }else
                        {
                            MessageBox.Show(son + "Không phải là số nguyên tố");
                        }
            }
            else
                MessageBox.Show("Bạn chưa chọn");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)

            {
                Application.Exit();

            }
        }
    }
}
