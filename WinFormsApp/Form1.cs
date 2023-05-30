namespace WinFormsApp
{
    public partial class FormName : Form
    {
        public FormName()
        {
            InitializeComponent();
        }

        List<Student> data = new List<Student>();

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = "..\\..\\..\\data.txt";

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (Student s in data)
                    {
                            sw.WriteLine(s.ToString());
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            data.Clear();

            try
            {
                string fileName = "..\\..\\..\\data.txt";
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        line = line.Trim();
                        if (!string.IsNullOrEmpty(line))
                        {

                            string[] s = line.Split("\t");
                            if (s.Length == 4)
                            {
                                string code = s[0];
                                if (map.ContainsKey(code))
                                {
                                    line = sr.ReadLine();
                                    continue;
                                }
                                string name = s[1];
                                string js = s[2];
                                int mark = Convert.ToInt32(s[3]);
                                Student st = new Student(code, name, js, mark);
                                data.Add(st);
                                map.Add(st.Code, st.Name);
                                lstStudent.Items.Add(st);
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine("Load failded:" + err.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Student s = (Student)lstStudent.SelectedItem;
            if (s == null)
            {
                return;
            }
            if (MessageBox.Show($"Remove student {s.ToString()}?", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                map.Remove(s.Code);
                lstStudent.Items.Remove(s);
                data.Remove(s);
            }
        }

        Dictionary<string, string> map = new Dictionary<string, string>();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Trim().Equals("") || txtName.Text.Trim().Equals(""))
            {
                return;
            }
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