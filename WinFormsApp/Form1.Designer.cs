namespace WinFormsApp
{
    partial class FormName
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Input = new GroupBox();
            numMark = new NumericUpDown();
            cboSubject = new ComboBox();
            txtName = new TextBox();
            txtCode = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            Output = new GroupBox();
            lstStudent = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            btnExit = new Button();
            label3 = new Label();
            Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).BeginInit();
            Output.SuspendLayout();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Controls.Add(numMark);
            Input.Controls.Add(cboSubject);
            Input.Controls.Add(txtName);
            Input.Controls.Add(txtCode);
            Input.Controls.Add(label6);
            Input.Controls.Add(label5);
            Input.Controls.Add(label4);
            Input.Controls.Add(label2);
            Input.Location = new Point(47, 141);
            Input.Name = "Input";
            Input.Size = new Size(371, 270);
            Input.TabIndex = 0;
            Input.TabStop = false;
            Input.Text = "Input";
            // 
            // numMark
            // 
            numMark.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            numMark.Location = new Point(108, 220);
            numMark.Name = "numMark";
            numMark.Size = new Size(240, 30);
            numMark.TabIndex = 9;
            // 
            // cboSubject
            // 
            cboSubject.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cboSubject.FormattingEnabled = true;
            cboSubject.Items.AddRange(new object[] { "Math", "Physic", "English", "PE" });
            cboSubject.Location = new Point(108, 158);
            cboSubject.Name = "cboSubject";
            cboSubject.Size = new Size(240, 31);
            cboSubject.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtName.Location = new Point(108, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(240, 30);
            txtName.TabIndex = 5;
            txtName.Enter += txtName_Enter;
            txtName.Leave += txtName_Leave;
            // 
            // txtCode
            // 
            txtCode.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtCode.Location = new Point(108, 43);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(240, 30);
            txtCode.TabIndex = 4;
            txtCode.TextChanged += txtCode_TextChanged;
            txtCode.Enter += txtCode_Enter;
            txtCode.Leave += txtCode_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Control;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(6, 222);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 3;
            label6.Text = "Mark";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(6, 160);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 2;
            label5.Text = "Subject";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 1;
            label4.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 0;
            label2.Text = "Code";
            // 
            // Output
            // 
            Output.Controls.Add(lstStudent);
            Output.Location = new Point(560, 141);
            Output.Name = "Output";
            Output.Size = new Size(379, 270);
            Output.TabIndex = 1;
            Output.TabStop = false;
            Output.Text = "Output";
            // 
            // lstStudent
            // 
            lstStudent.FormattingEnabled = true;
            lstStudent.ItemHeight = 20;
            lstStudent.Location = new Point(21, 26);
            lstStudent.Name = "lstStudent";
            lstStudent.Size = new Size(338, 224);
            lstStudent.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Tomato;
            btnAdd.Location = new Point(442, 202);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = ">>";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.Tomato;
            btnRemove.Location = new Point(442, 237);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(94, 29);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "<<";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.ForeColor = Color.Tomato;
            btnLoad.Location = new Point(442, 272);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Tomato;
            btnSave.Location = new Point(442, 307);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.Tomato;
            btnExit.Location = new Point(442, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 7;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(244, 35);
            label3.Name = "label3";
            label3.Size = new Size(492, 54);
            label3.TabIndex = 2;
            label3.Text = "STUDENT MANAGEMENT";
            // 
            // FormName
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(987, 452);
            Controls.Add(btnExit);
            Controls.Add(btnSave);
            Controls.Add(btnLoad);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(Output);
            Controls.Add(Input);
            Name = "FormName";
            Text = "Student Management";
            Load += FormName_Load;
            Input.ResumeLayout(false);
            Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMark).EndInit();
            Output.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Input;
        private GroupBox Output;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cboSubject;
        private TextBox txtName;
        private TextBox txtCode;
        private NumericUpDown numMark;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnLoad;
        private Button btnSave;
        private Button btnExit;
        private ListBox lstStudent;
        private Label label3;
    }
}