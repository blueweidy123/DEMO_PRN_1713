using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace assignment2
{
    public partial class LunarCal : Form
    {
        public LunarCal()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            deactive = 5;
            int solarYear;
            //if (txtdl.Text.Length <4)
            //{
            //    MessageBox.Show("Nhap sai dinh dang");
            //    return;
            //}
            try
            {
                solarYear = int.Parse(txtdl.Text);
                txtal.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("nhap sai");
                txtal.Text = "";
                return;
            }
            if (txtdl.Text.Equals("") || txtdl.Text == null)
            {
                MessageBox.Show("chua nhap nam");
                txtal.Text = "";
                return;
            }

            //int solarYear = int.Parse(txtdl.Text);
            //ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
            //int lunarYear = calendar.GetYear(new DateTime(solarYear, 1, 1));
            int can = solarYear % 10;
            int chi = solarYear % 12;
            //int can = lunarYear % 10;
            //int chi = lunarYear % 12;
            string canS = "";
            string chiS = "";
            switch (can)
            {
                case 0:
                    canS = "Canh";
                    break;
                case 1:
                    canS = "tan";
                    break;
                case 2:
                    canS = "Nham";
                    break;
                case 3:
                    canS = "Quy";
                    break;
                case 4:
                    canS = "Giap";
                    break;
                case 5:
                    canS = "At";
                    break;
                case 6:
                    canS = "Binh";
                    break;
                case 7:
                    canS = "Dinh";
                    break;
                case 8:
                    canS = "Mau";
                    break;
                case 9:
                    canS = "ky";
                    break;
            }

            switch (chi)
            {
                case 0:
                    chiS = "Than";
                    break;
                case 1:
                    chiS = "Dau";
                    break;
                case 2:
                    chiS = "Tuat";
                    break;
                case 3:
                    chiS = "Hoi";
                    break;
                case 4:
                    chiS = "Ti";
                    break;
                case 5:
                    chiS = "Suu";
                    break;
                case 6:
                    chiS = "Dan";
                    break;
                case 7:
                    chiS = "Mao";
                    break;
                case 8:
                    chiS = "Thin";
                    break;
                case 9:
                    chiS = "Ti";
                    break;
                case 10:
                    chiS = "Ngo";
                    break;
                case 11:
                    chiS = "Mui";
                    break;
            }
            txtal.Text = (canS + " " + chiS);
        }

        int deactive = 5;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dea.Text = deactive--.ToString();
            if (deactive < 0)
            {
                this.Close();
            }
        }

        private void txtdl_TextChanged(object sender, EventArgs e)
        {
            deactive = 5;
        }

        private void txtal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
