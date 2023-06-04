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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DentlPayment dp = new DentlPayment();
            dp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecurityPanel sp = new SecurityPanel();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartupForm sf = new StartupForm();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
