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
    public partial class SecurityPanel : Form
    {
        String SCode = "";
        public SecurityPanel()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += Form1_KeyPress;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Trigger button click event
                //MessageBox.Show("asd");
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "1";
            bok.Focus();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "2";
            bok.Focus();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "3";
            bok.Focus();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "4";
            bok.Focus();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "5";
            bok.Focus();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "6";
            bok.Focus();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "7";
            bok.Focus();
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "8";
            bok.Focus();
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "9";
            bok.Focus();
        }

        private void b0_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "0";
            bok.Focus();
        }

        private void bclear_Click(object sender, EventArgs e)
        {
            CodeClear();
        }

        private void CodeClear()
        {
            txtSCode.Text = SCode = "";
        }

        private void bok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(txtSCode.Text);
            okch();
        }

        private void okch()
        {
            string time = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss   \t");
            switch (SCode)
            {
                case "1645":
                    lvLog.Items.Add((string)time + "\tTechnicians");
                    CodeClear();
                    break;
                case "1689":
                    lvLog.Items.Add((string)time + "\tTechnicians");
                    CodeClear();
                    break;
                case "8345":
                    lvLog.Items.Add((string)time + "\tCustodians");
                    CodeClear();
                    break;
                case "9998":
                    lvLog.Items.Add((string)time + "\tScientist");
                    CodeClear();
                    break;
                case "1006":
                    lvLog.Items.Add((string)time + "\tScientist");
                    CodeClear();
                    break;
                case "1007":
                    lvLog.Items.Add((string)time + "\tScientist");
                    CodeClear();
                    break;
                case "1008":
                    lvLog.Items.Add((string)time + "\tScientist");
                    CodeClear();
                    break;
                default:
                    lvLog.Items.Add((string)time + "\tRestricted Access!");
                    CodeClear();
                    break;
            }
        }

        private void entercheck(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ActiveControl == null)
                {
                    MessageBox.Show("Enter key pressed while no control has focus.");
                }
            }
        }

        private void SecurityPanel_Load(object sender, EventArgs e)
        {
            bok.Focus();
        }

        private void b1_Enter(object sender, EventArgs e)
        {
            //okch();
        }

        private void b2_Enter(object sender, EventArgs e)
        {
            //okch();

        }

        private void SecurityPanel_Enter(object sender, EventArgs e)
        {
            //okch();
        }

        private void SecurityPanel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("enter");
            }
        }
    }
}
