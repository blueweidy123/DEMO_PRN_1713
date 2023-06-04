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
                lbl.Location = new Point(12, 25 + i * 25);
                lbl.AutoSize = true;
                gb1.Controls.Add(lbl);

                TextBox txt = new TextBox();
                txt.Text = "0";
                txt.Size = new Size(200, 200);
                txt.Location = new Point(100, 25 + i * 25);
                txt.AutoSize = true;
                gb1.Controls.Add(txt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Controls.Clear();
            int i = 0;
            foreach (Control control in gb1.Controls)
            {
                if (control is TextBox textBox)
                {
                    Label label = new Label();
                    label.Text = textBox.Text;
                    label.AutoSize = true;


                    CheckBox cb = new CheckBox();
                    cb.AutoSize = true;
                    cb.Location = new Point(6, 22 + i++ * 25);
                    cb.Size = new Size(83, 19);
                    cb.Text = textBox.Text;
                    cb.UseVisualStyleBackColor = true;

                    output.Controls.Add(cb);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string concat = "student checked: ";
            foreach (Control control in output.Controls)
            {
                if (control is CheckBox cb)
                {
                    if (cb.Checked)
                    {
                        concat += cb.Text + "/";
                    }
                }
            }
            MessageBox.Show(concat);
        }
    }
}
