using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class mwShow : Form
    {
        int deactive = 5;
        public mwShow()
        {
            InitializeComponent();
            timer1.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Fauna;
            deactive = 5;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.fs;
            deactive = 5;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.gura;
            deactive = 5;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.f3;
            deactive = 5;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.tr;
            deactive = 5;
        }

        private void StartupF_Load(object sender, EventArgs e)
        {
            radioButton5.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LunarCal lc = new LunarCal();
            lc.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = deactive--.ToString();
            if (deactive < 0)
            {
                LunarCal lc = new LunarCal();
                timer1.Stop();
                lc.Show();
                this.Close();
            }
        }
    }
}
