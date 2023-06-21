using EFPrac2.Models;

namespace EFPrac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                var data = context.Customers.Select(c => new
                {

                    Id = c.CustomerId,
                    Name = c.CustomerName,
                    Dob = c.Birthdate,
                    Gender = (c.Gender ? "Male" : "Female"),
                    Address = c.Address

                }).ToList();

                dataGridView1.DataSource = data;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}