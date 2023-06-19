using WinForms_EF.Models;

namespace WinForms_EF
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
            //LoadDataComboBox();
        }

        private void LoadDataComboBox()
        {
            
        }

        MySaleDBContext context = new MySaleDBContext();
        private void LoadData()
        {
            List<Product> products = new List<Product>();
            //get du lieu tu database, su dung EF
            products = context.Products.ToList();

            dgProduct.DataSource = products;

            //Load to combobox
            List<Category> categories = new List<Category>();
            categories = context.Categories.ToList();
            cbCate.DataSource = categories;
            cbCate.DisplayMember = "CategoryName";
            cbCate.ValueMember = "CategoryId";

            //Load du lieu len txtbox
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtStock.DataBindings.Clear();
            txtImg.DataBindings.Clear();

            txtId.DataBindings.Add("Text", products, "ProductId");
            txtName.DataBindings.Add("Text", products, "ProductName");
            txtPrice.DataBindings.Add("Text", products, "UnitPrice");
            txtStock.DataBindings.Add("Text", products, "UnitsInStock");
            txtImg.DataBindings.Add("Text", products, "Image");
        }
    }
}