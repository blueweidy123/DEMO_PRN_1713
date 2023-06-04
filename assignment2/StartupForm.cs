using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace assignment2
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            label1.Text = $"On the way there......................: \t\t\t\t{progressBar1.Value}%";

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();

                mwShow mw = new mwShow();
                mw.Show();

                // Close the current form
                this.Close();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
