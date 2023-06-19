using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataProvider dp = new DataProvider();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData2();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        DataProvider dp = new DataProvider();
        bool check = false;
        private void LoadData()
        {
            List<Word> data = new List<Word>();

            //lay du lieu tu bang customer add vao data
            using (IDataReader dr = dp.executeQuery2("SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID"))
            {
                while (dr.Read())
                {
                    String id = dr.GetInt32(0).ToString();
                    String word = dr.GetString(1).ToString();
                    String meaning = dr.GetString(3).ToString();
                    String eDate = dr.GetDateTime(2).ToString();
                    String typeN = dr.GetString(4).ToString();
                    Word w = new Word(id, word, meaning, eDate, typeN);
                    data.Add(w);
                }
                dataGridView1.DataSource = data;
            }
            //add data vao data grid
            dataGridView1.DataSource = data;
        }

        private void LoadData2()
        {
            List<string> dataw = new List<string>();

            //lay du lieu tu bang customer add vao data
            using (IDataReader dr = dp.executeQuery2("SELECT * FROM WordType"))
            {
                while (dr.Read())
                {
                    string wtext = dr.GetString(1);
                    dataw.Add(wtext);
                }

            }
            comboBox1.DataSource = dataw;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtword.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtMeaning.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            sa();
            //seach();
        }


        private void sa()
        {
            string strSQL = "SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID WHERE TypeName=@t";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@w",txtword.Text),
                new SqlParameter("@m",txtMeaning.Text),
                new SqlParameter("@t", comboBox1.Text),
            };
            List<Word> data = new List<Word>();

            if (txtMeaning.Text.Length > 0)
            {
                strSQL += " AND Meaning = @m";
            }
            if (txtword.Text.Length > 0)
            {
                strSQL += " AND Word=@w";
            }
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                while (dr.Read())
                {
                    string id = dr.GetInt32(0).ToString();
                    string word = dr.GetString(1);
                    string meaning = dr.GetString(3);
                    string editDate = dr.GetDateTime(2).ToString();
                    string typeName = dr.GetString(4);
                    Word w = new Word(id, word, meaning, editDate, typeName);
                    data.Add(w);
                }
                dr.Close();
            }
            dataGridView1.DataSource = data;
        }
        private void seach()
        {

            List<Word> dataSearch = new List<Word>();
            string sql1 = "SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID WHERE TypeName=@type and Word LIKE @s and [Meaning] LIKE @s1";
            string sql2 = "SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID WHERE TypeName=@type and [Meaning] LIKE @s";


            string s = "";
            string s1 = "";
            if (txtMeaning.Text.Length > 0)
            {
                s = "%" + txtMeaning.Text + "%";
            }
            if (txtMeaning.Text.Length > 0)
            {
                s1 = "%" + txtword + "%";
            }

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@s", s),
                new SqlParameter("@s1", s1),
                new SqlParameter("@type", comboBox1.Text)
            };

            using (IDataReader dr = dp.executeQuery2(sql1, param))
            {
                while (dr.Read())
                {
                    String id = dr.GetInt32(0).ToString();
                    String word = dr.GetString(1).ToString();
                    String meaning = dr.GetString(3).ToString();
                    String eDate = dr.GetDateTime(2).ToString();
                    String typeN = dr.GetString(4).ToString();
                    Word w = new Word(id, word, meaning, eDate, typeN);
                    dataSearch.Add(w);
                }
                dataGridView1.DataSource = dataSearch;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}