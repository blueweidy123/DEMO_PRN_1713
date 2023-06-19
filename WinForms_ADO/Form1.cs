using Microsoft.Data.SqlClient;
using System.Data;

namespace WinForms_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
        }
        DataProvider dp = new DataProvider();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = txtAccount.Text;
            string pwd = txtPassword.Text;
            if (acc.Trim().Equals("") || pwd.Trim().Equals(""))
            {
                MessageBox.Show("ngu vl nhap input di");
                return;
            }

            string strSelect = "select * from Users where " +
                "account=@acc " +
                "and password=@pwd ";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@acc",acc),
                new SqlParameter("@pwd",pwd)
            };


            bool check = false;
            using (IDataReader idr = dp.executeQuery2(strSelect, param))
            {
                if (idr.Read())
                {
                    check = true;
                }
            }
            if (check)
            {
                MessageBox.Show("login ok");
                string name = getNameByAccount(acc);
                Form2 f2 = new Form2(name);
                f2.Show();
                //this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("login okn't");
            }
        }
        
        private string getNameByAccount(string acc)
        {
            string strSelect = "select * from Users where " +
                "account=@acc";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@acc",acc)
            };

            using (IDataReader idr = dp.executeQuery2(strSelect, param))
            {
                if (idr.Read())
                {
                    string name = idr.GetString(2);
                    idr.Close();
                    return name;
                }
            }
            //idr.Close();
            return "";
        }
    }
}