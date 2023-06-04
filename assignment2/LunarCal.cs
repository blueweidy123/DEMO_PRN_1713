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
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void View_Click(object sender, EventArgs e)
        {
            int solarYear = int.Parse(txtdl.Text);
            ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
            int lunarYear = calendar.GetYear(new DateTime(solarYear, 1, 1));
            txtal.Text = lunarYear.ToString();
        }
    }
}
