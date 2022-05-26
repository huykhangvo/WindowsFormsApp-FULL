            int n = Convert.ToInt32(txbN.Text);
            bool kt = true;
            if (n < 2)
            {
                kt = false;
            }
            for (int i = 2; i < n / 2; i++)
            {
                if (n % i == 0)
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
            {
                MessageBox.Show("la so nguyen to" + n);
            }
            else
            {
                MessageBox.Show("Khong phai" + n);
            }


            Khungxuat.ForeColor = Color.Red;
            Khungxuat.ForeColor = Color.Blue;
