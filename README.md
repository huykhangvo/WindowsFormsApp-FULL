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
