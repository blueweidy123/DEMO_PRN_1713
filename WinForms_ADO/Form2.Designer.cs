namespace WinForms_ADO
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            txtName = new TextBox();
            rdmale = new RadioButton();
            rdfemale = new RadioButton();
            label5 = new Label();
            btnInsert = new Button();
            btnExit = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 239);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 199);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(141, 37);
            txtId.Name = "txtId";
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 40);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 3;
            label1.Text = "id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 87);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 5;
            label2.Text = "Dob";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 145);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(141, 142);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(582, 27);
            txtAddress.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(428, 43);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "name";
            // 
            // txtName
            // 
            txtName.Location = new Point(496, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(227, 27);
            txtName.TabIndex = 8;
            // 
            // rdmale
            // 
            rdmale.AutoSize = true;
            rdmale.Location = new Point(496, 90);
            rdmale.Name = "rdmale";
            rdmale.Size = new Size(63, 24);
            rdmale.TabIndex = 10;
            rdmale.TabStop = true;
            rdmale.Text = "male";
            rdmale.UseVisualStyleBackColor = true;
            // 
            // rdfemale
            // 
            rdfemale.AutoSize = true;
            rdfemale.Location = new Point(565, 90);
            rdfemale.Name = "rdfemale";
            rdfemale.Size = new Size(76, 24);
            rdfemale.TabIndex = 11;
            rdfemale.TabStop = true;
            rdfemale.Text = "female";
            rdfemale.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(428, 92);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 12;
            label5.Text = "Gender";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(61, 204);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(629, 204);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 15;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(482, 204);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(338, 204);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(196, 204);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 19;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnInsert);
            Controls.Add(label5);
            Controls.Add(rdfemale);
            Controls.Add(rdmale);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtName;
        private RadioButton rdmale;
        private RadioButton rdfemale;
        private Label label5;
        private Button btnInsert;
        private Button btnExit;
        private Button btnReset;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dateTimePicker1;
    }
}