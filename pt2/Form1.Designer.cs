namespace pt2
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            Dictionary = new Label();
            txtword = new TextBox();
            btnSeach = new Button();
            label1 = new Label();
            label2 = new Label();
            txtMeaning = new TextBox();
            label3 = new Label();
            btnLoad = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 250);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Dictionary
            // 
            Dictionary.AutoSize = true;
            Dictionary.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Dictionary.Location = new Point(323, 9);
            Dictionary.Name = "Dictionary";
            Dictionary.Size = new Size(165, 41);
            Dictionary.TabIndex = 1;
            Dictionary.Text = "Dictionary";
            // 
            // txtword
            // 
            txtword.Location = new Point(203, 109);
            txtword.Name = "txtword";
            txtword.Size = new Size(151, 27);
            txtword.TabIndex = 2;
            // 
            // btnSeach
            // 
            btnSeach.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeach.Location = new Point(504, 165);
            btnSeach.Name = "btnSeach";
            btnSeach.Size = new Size(124, 38);
            btnSeach.TabIndex = 3;
            btnSeach.Text = "SEARCH";
            btnSeach.UseVisualStyleBackColor = true;
            btnSeach.Click += btnSeach_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(120, 112);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 4;
            label1.Text = "Word";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(408, 113);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 5;
            label2.Text = "Meaning";
            label2.Click += label2_Click;
            // 
            // txtMeaning
            // 
            txtMeaning.Location = new Point(504, 111);
            txtMeaning.Name = "txtMeaning";
            txtMeaning.Size = new Size(169, 27);
            txtMeaning.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(120, 175);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 7;
            label3.Text = "Type";
            label3.Click += label3_Click;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(12, 444);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(133, 29);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "LOAD DATA";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(203, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 481);
            Controls.Add(comboBox1);
            Controls.Add(btnLoad);
            Controls.Add(label3);
            Controls.Add(txtMeaning);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSeach);
            Controls.Add(txtword);
            Controls.Add(Dictionary);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Dictionary;
        private TextBox txtword;
        private Button btnSeach;
        private Label label1;
        private Label label2;
        private TextBox txtMeaning;
        private Label label3;
        private Button btnLoad;
        private ComboBox comboBox1;
    }
}