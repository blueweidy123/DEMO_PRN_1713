using Microsoft.Data.SqlClient;
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

namespace WinForms_ADO
{
    public partial class Form2 : Form
    {
        public string Name { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string name)
        {
            InitializeComponent();
            this.Name = name;
            Text = name;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Text = "welcome " + Name;
            LoadData();
        }

        DataProvider dp = new DataProvider();
        bool check = false;
        private void LoadData()
        {
            List<Customer> data = new List<Customer>();

            //lay du lieu tu bang customer add vao data
            using (IDataReader dr = dp.executeQuery2("SELECT WordID,Word,EditDate,Meaning,w.TypeName FROM Dictionary d JOIN WordType w on d.ID=w.ID"))
            {
                while (dr.Read())
                {
                    String id = dr.GetInt32(0).ToString();
                    String name = dr.GetString(1).ToString();
                    String gender = dr.GetBoolean(3).ToString();
                    String dob = dr.GetDateTime(2).ToString();
                    String address = dr.GetString(4).ToString();
                    Customer customer = new Customer(id, name, address, gender, dob);
                    data.Add(customer);
                }

            }
            //add data vao data grid
            dataGridView1.DataSource = data;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string sqlInsert = "insert into [Customers] ([CustomerName], [Birthdate], [Gender],[Address]) " +
                "VALUES (@name, @date, @gen,@address);";
            //string sqldelete = "delete from Customers where CustomerId=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@name", txtName.Text),
                new SqlParameter("@date", dateTimePicker1.Value),
                new SqlParameter("@gen", rdmale.Checked?"1" : "0"),
                new SqlParameter("@address", txtAddress.Text)
            };
            if (dp.executeNonQuery(sqlInsert, param))
            {
                //MessageBox.Show("I S");
                LoadData();
            }
            else
            {
                MessageBox.Show("Insert Fail");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("True"))
            {
                rdmale.Checked = true;
                rdfemale.Checked = false;
            }
            else
            {
                rdmale.Checked = false;
                rdfemale.Checked = true;
            }
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDob_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //DataProvider dp = new DataProvider();
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqldelete = "delete from Customers where CustomerId=@id";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id", txtId.Text)
            };
            if (dp.executeNonQuery(sqldelete, param))
            {
                //MessageBox.Show("D S");
                LoadData();
            }
            else
            {
                MessageBox.Show("Delete Fail");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sqlUpdate = "UPDATE Customers SET " +
                "[CustomerName] = @newName, " +
                "[Birthdate] = @newDob , " +
                "[Gender] = @newGen, " +
                "[Address] = @newPlace " +
                "WHERE [CustomerId] = @id;";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id", txtId.Text),
                new SqlParameter("@newName", txtName.Text),
                new SqlParameter("@newDob", dateTimePicker1.Value),
                new SqlParameter("@newGen", rdmale.Checked?"1" : "0"),
                new SqlParameter("@newPlace", txtAddress.Text)

            };
            if (dp.executeNonQuery(sqlUpdate, param))
            {
                //MessageBox.Show("D S");
                LoadData();
            }
            else
            {
                MessageBox.Show("Update Fail");
            }
        }
    }
}
