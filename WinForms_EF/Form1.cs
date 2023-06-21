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

        //MySaleDBContext context = new MySaleDBContext();
        private void LoadData()
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //List<Product> products = new List<Product>();
                //get du lieu tu database, su dung EF
                var products = context.Products.Select(p => new
                {
                    Code = p.ProductId,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice,
                    UnitsInStock = p.UnitsInStock,
                    Image = p.Image,
                    Category = p.Category.CategoryName
                })
                    .OrderBy(p => p.UnitPrice)
                    .ThenByDescending(p => p.UnitsInStock)
                    .ToList();

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
                cbCate.DataBindings.Clear();

                txtId.DataBindings.Add("Text", products, "Code");
                txtName.DataBindings.Add("Text", products, "ProductName");
                txtPrice.DataBindings.Add("Text", products, "UnitPrice");
                txtStock.DataBindings.Add("Text", products, "UnitsInStock");
                txtImg.DataBindings.Add("Text", products, "Image");

                cbCate.DataBindings.Add("Text", products, "Category");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //Tao 1 doi tuong product de add du lieu
                Product p = new Product()
                {
                    ProductName = txtName.Text,
                    UnitPrice = Decimal.Parse(txtPrice.Text),
                    UnitsInStock = Int32.Parse(txtStock.Text),
                    Image = txtImg.Text,
                    CategoryId = (int)cbCate.SelectedValue

                };

                //Add vao db su dung EF
                context.Products.Add(p);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Added successfully!!!");
                }
                else
                {
                    MessageBox.Show("Added fail@@");
                }
                LoadData();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tim doi tuong can update
                Product p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("Product k ton tai");
                    return;
                }

                //update 
                p.ProductName = txtName.Text;
                p.UnitPrice = Decimal.Parse(txtPrice.Text);
                p.UnitsInStock = Int32.Parse(txtStock.Text);
                p.Image = txtImg.Text;
                p.CategoryId = (int)cbCate.SelectedValue;

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Updated successfully!!!");
                }
                else
                {
                    MessageBox.Show("Updated fail@@");
                }
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //tim doi tuong can delete
                Product p = context.Products.FirstOrDefault(p => p.ProductId == Int32.Parse(txtId.Text));
                if (p == null)
                {
                    MessageBox.Show("Product k ton tai");
                    return;
                }

                context.Products.Remove(p);

                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Deleted successfully!!!");
                }
                else
                {
                    MessageBox.Show("Deleted fail@@");
                }
                LoadData();
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtImg.Text = string.Empty;
            cbCate.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (MySaleDBContext context = new MySaleDBContext())
            {
                //List<Product> products = new List<Product>();
                //get du lieu tu database, su dung EF

                //cach viet linq
                //var products = context.Products.Where(p => p.ProductName.Contains(txtName.Text)).ToList();

                //linq cach 1
                //var products = (from p in context.Products 
                //                where p.ProductName.Contains(txtName.Text) 
                //                select p).ToList();

                var products = (from p in context.Products
                                where p.ProductName.Contains(txtName.Text)
                                select new
                                {
                                    Code = p.ProductId,
                                    ProductName = p.ProductName,
                                    UnitPrice = p.UnitPrice,
                                    UnitsInStock = p.UnitsInStock,
                                    Image = p.Image,
                                    Category = p.Category.CategoryName
                                }).ToList();

                dgProduct.DataSource = products;
            }
        }
    }
}