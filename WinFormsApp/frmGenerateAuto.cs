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
    public partial class frmGenerateAuto : Form
    {
        public frmGenerateAuto()
        {
            InitializeComponent();
        }

        public frmGenerateAuto(string text)
        {
            InitializeComponent();
            Text = "Welcome " + text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGenerateAuto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AddText_Click(object sender, EventArgs e)
        {
            int n = (int)numText.Value;
            for (int i = 0; i < n; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Enter text: {i + 1}";
                lbl.Size = new Size(50, 200);
                lbl.Location = new Point(50, 84 + i * 30);
                lbl.AutoSize = true;
                this.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Text = "0";
                txt.Size = new Size(50, 200);
                txt.Location = new Point(250, 84 + i * 30);
                this.Controls.Add(txt);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numText_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
