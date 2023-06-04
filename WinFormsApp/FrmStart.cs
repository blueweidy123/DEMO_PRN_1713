using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        int count = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                lblCount.Text = count.ToString();
            }
            else
            {
                timer.Stop();
                lblCount.Text = "timeout!";
                frmGenerateAuto f = new frmGenerateAuto(txtName.Text);
                f.Show();
                this.Hide();
            }
        }

    }
}
