# WindowsFormsApp-FULL
        private void rdoPtBac1_CheckedChanged(object sender, EventArgs e)
        {
            grbPTBac1.Visible = true;
            grbKQ1.Visible = true;
            grbPtBac2.Visible = false;
            grbKQ2.Visible = false;
        }

        private void rdoPtBac2_CheckedChanged(object sender, EventArgs e)
        {
            grbPTBac1.Visible = false;
            grbKQ1.Visible = false;
            grbPtBac2.Visible = true;
            grbKQ2.Visible = true;
        }

        private void nhapSoThuc(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

        }

        private void grbPTBac1_Enter(object sender, EventArgs e)
        {

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txbPtBac1A.Clear();
            txbPtBac1B.Clear();
            txbPtBac2A.Clear();
            txbPtBac2B.Clear();
            txbPtBac2C.Clear();
            txbX.Clear();
            txbX1.Clear();
            txbX2.Clear();            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (rdoPtBac1.Checked)
            {
                //giải pt bậc nhất
                int a = int.Parse(txbPtBac1A.Text);
                double b = double.Parse(txbPtBac1B.Text);

                //txbX.Text = String.Format("{0:0.0}",(0-double.Parse(txbPtBac1B.Text)) / double.Parse(txbPtBac1A.Text));
                Console.WriteLine();
            }
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
                    DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
            
            
                        foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            txtHoTenKH.Focus();
            
            
            
            
            
            
            
            
            
            
            
            
