namespace WinFormsApp
{
    public partial class FormName : Form
    {
        public FormName()
        {
            InitializeComponent();
        }

        List<Student> data = new List<Student>()
        {
            new Student("01", "antt", "Jap", 100),
            new Student("02", "tta", "En", 10),
            new Student("03", "AnThach", "Subj", 100),
        };

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            foreach (Student student in data)
            {
                lstStudent.Items.Add(student);
                map.Add(student.Code, student.Name);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        Dictionary<string, string> map = new Dictionary<string, string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (map.ContainsKey(txtCode.Text))
            {
                MessageBox.Show(txtCode+" Da ton taoi");
                return;
            }
            Student s = new Student()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Subject = cboSubject.SelectedItem.ToString(),
                Mark = (int)numMark.Value
            };
            data.Add(s);
            lstStudent.Items.Add(s);
            map.Add(txtCode.Text, txtName.Text);
            txtCode.Clear();
            txtName.Clear();
            cboSubject.SelectedIndex= -1;
            numMark.Value = 0;
        }

        private void txtCode_Enter(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.Azure;
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            txtCode.BackColor = Color.White;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            txtName.BackColor = Color.White;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.BackColor = Color.Azure;
        }

        private void FormName_Load(object sender, EventArgs e)
        {
            cboSubject.Items.Add("Japanese");
        }
    }
}