namespace assignment2
{
    partial class DentlPayment
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
            lblTitle = new Label();
            lblName = new Label();
            lblCleanCost = new Label();
            lblWhiteningCost = new Label();
            chkXRayCost = new Label();
            openFileDialog1 = new OpenFileDialog();
            lblFillingCost = new Label();
            txtName = new TextBox();
            numFilling = new NumericUpDown();
            chkClean = new CheckBox();
            chkWhitening = new CheckBox();
            chkXRay = new CheckBox();
            lblFilling = new Label();
            txtTotal = new TextBox();
            lblTotal = new Label();
            btnExit = new Button();
            btnCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)numFilling).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Impact", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Blue;
            lblTitle.Location = new Point(68, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(261, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dental Payment Form";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(31, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(92, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Customer name";
            // 
            // lblCleanCost
            // 
            lblCleanCost.AutoSize = true;
            lblCleanCost.Location = new Point(291, 149);
            lblCleanCost.Name = "lblCleanCost";
            lblCleanCost.Size = new Size(52, 15);
            lblCleanCost.TabIndex = 2;
            lblCleanCost.Text = "$100.000";
            // 
            // lblWhiteningCost
            // 
            lblWhiteningCost.AutoSize = true;
            lblWhiteningCost.Location = new Point(282, 194);
            lblWhiteningCost.Name = "lblWhiteningCost";
            lblWhiteningCost.Size = new Size(61, 15);
            lblWhiteningCost.TabIndex = 3;
            lblWhiteningCost.Text = "$1.200.000";
            // 
            // chkXRayCost
            // 
            chkXRayCost.AutoSize = true;
            chkXRayCost.Location = new Point(291, 236);
            chkXRayCost.Name = "chkXRayCost";
            chkXRayCost.Size = new Size(52, 15);
            chkXRayCost.TabIndex = 4;
            chkXRayCost.Text = "$200.000";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblFillingCost
            // 
            lblFillingCost.AutoSize = true;
            lblFillingCost.Location = new Point(267, 278);
            lblFillingCost.Name = "lblFillingCost";
            lblFillingCost.Size = new Size(76, 15);
            lblFillingCost.TabIndex = 5;
            lblFillingCost.Text = "$80.000/each";
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(159, 23);
            txtName.TabIndex = 6;
            // 
            // numFilling
            // 
            numFilling.Location = new Point(97, 276);
            numFilling.Name = "numFilling";
            numFilling.Size = new Size(65, 23);
            numFilling.TabIndex = 7;
            // 
            // chkClean
            // 
            chkClean.AutoSize = true;
            chkClean.Location = new Point(31, 145);
            chkClean.Name = "chkClean";
            chkClean.Size = new Size(66, 19);
            chkClean.TabIndex = 8;
            chkClean.Text = "Cạo vôi";
            chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            chkWhitening.AutoSize = true;
            chkWhitening.Location = new Point(31, 190);
            chkWhitening.Name = "chkWhitening";
            chkWhitening.Size = new Size(75, 19);
            chkWhitening.TabIndex = 9;
            chkWhitening.Text = "Tẩy trắng";
            chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            chkXRay.AutoSize = true;
            chkXRay.Location = new Point(31, 232);
            chkXRay.Name = "chkXRay";
            chkXRay.Size = new Size(109, 19);
            chkXRay.TabIndex = 10;
            chkXRay.Text = "Chụp hình răng";
            chkXRay.UseVisualStyleBackColor = true;
            // 
            // lblFilling
            // 
            lblFilling.AutoSize = true;
            lblFilling.Location = new Point(31, 278);
            lblFilling.Name = "lblFilling";
            lblFilling.Size = new Size(60, 15);
            lblFilling.TabIndex = 11;
            lblFilling.Text = "Trám răng";
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(184, 345);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(159, 23);
            txtTotal.TabIndex = 12;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(130, 348);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(31, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 14;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(267, 406);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 15;
            btnCalc.Text = "Tính tiền";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click_1;
            // 
            // DentlPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 450);
            Controls.Add(btnCalc);
            Controls.Add(btnExit);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(lblFilling);
            Controls.Add(chkXRay);
            Controls.Add(chkWhitening);
            Controls.Add(chkClean);
            Controls.Add(numFilling);
            Controls.Add(txtName);
            Controls.Add(lblFillingCost);
            Controls.Add(chkXRayCost);
            Controls.Add(lblWhiteningCost);
            Controls.Add(lblCleanCost);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            Name = "DentlPayment";
            Text = "DentalPayment";
            ((System.ComponentModel.ISupportInitialize)numFilling).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblCleanCost;
        private Label lblWhiteningCost;
        private Label chkXRayCost;
        private OpenFileDialog openFileDialog1;
        private Label lblFillingCost;
        private TextBox txtName;
        private NumericUpDown numFilling;
        private CheckBox chkClean;
        private CheckBox chkWhitening;
        private CheckBox chkXRay;
        private Label lblFilling;
        private TextBox txtTotal;
        private Label lblTotal;
        private Button btnExit;
        private Button btnCalc;
    }
}