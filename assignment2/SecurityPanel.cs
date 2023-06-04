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
        }

        private void b1_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "5";
        }

        private void b6_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            txtSCode.Text = SCode += "0";
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
    }
}
