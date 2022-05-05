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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tôi tên là: " + txtHoTen.Text+"\n"+
                "Sinh Ngày: "+ txtNgaySinh.Text+"\n"+
                "Sở thích: "+"\n"+txtSoThich.Text);
        }
    }
}
