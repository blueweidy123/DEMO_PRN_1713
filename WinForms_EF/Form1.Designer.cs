namespace WinForms_EF
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
            label1 = new Label();
            dgProduct = new DataGridView();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPrice = new TextBox();
            label4 = new Label();
            txtImg = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtStock = new TextBox();
            label7 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            btnExit = new Button();
            cbCate = new ComboBox();
            btnSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduct).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(324, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 41);
            label1.TabIndex = 0;
            label1.Text = "Products";
            // 
            // dgProduct
            // 
            dgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduct.Location = new Point(12, 250);
            dgProduct.Name = "dgProduct";
            dgProduct.RowHeadersWidth = 51;
            dgProduct.RowTemplate.Height = 29;
            dgProduct.Size = new Size(776, 188);
            dgProduct.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(99, 66);
            txtId.Name = "txtId";
            txtId.Size = new Size(260, 27);
            txtId.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 69);
            label2.Name = "label2";
            label2.Size = new Size(22, 20);
            label2.TabIndex = 3;
            label2.Text = "Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 108);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 5;
            label3.Text = "Price";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(99, 105);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(260, 27);
            txtPrice.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 151);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 7;
            label4.Text = "Img";
            // 
            // txtImg
            // 
            txtImg.Location = new Point(99, 148);
            txtImg.Name = "txtImg";
            txtImg.Size = new Size(260, 27);
            txtImg.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 151);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 13;
            label5.Text = "Cate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(438, 108);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 11;
            label6.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(494, 105);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(260, 27);
            txtStock.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 69);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 9;
            label7.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(494, 66);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 27);
            txtName.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(104, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(204, 215);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 215);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(404, 215);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 17;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(508, 215);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // cbCate
            // 
            cbCate.FormattingEnabled = true;
            cbCate.Location = new Point(494, 148);
            cbCate.Name = "cbCate";
            cbCate.Size = new Size(260, 28);
            cbCate.TabIndex = 19;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(608, 215);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 20;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(cbCate);
            Controls.Add(btnExit);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label7);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtImg);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(dgProduct);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgProduct;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private TextBox txtPrice;
        private Label label4;
        private TextBox txtImg;
        private Label label5;
        private Label label6;
        private TextBox txtStock;
        private Label label7;
        private TextBox txtName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReset;
        private Button btnExit;
        private ComboBox cbCate;
        private Button btnSearch;
    }
}