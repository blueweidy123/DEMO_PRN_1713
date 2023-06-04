namespace assignment2
{
    public partial class DentlPayment : Form
    {
        public DentlPayment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GetPay()
        {
            if (txtName.Text.Trim().Equals("") || txtName == null)
            {
                MessageBox.Show("Chua nhap ten Khach hang");
                return;
            }
            int total = 0;
            if (chkClean.Checked)
            {
                total += 100000;
            }
            if (chkWhitening.Checked)
            {
                total += 1200000;
            }
            if (chkXRay.Checked)
            {
                total += 200000;
            }
            if (numFilling.Value > 0)
            {
                total += (int)numFilling.Value * 80000;
            }
            if (total == 0)
            {
                MessageBox.Show("quy khack chua su dung dich vu nao");
                return;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            GetPay();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}