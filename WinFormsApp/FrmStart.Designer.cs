namespace WinFormsApp
{
    partial class FrmStart
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            lblCount = new Label();
            timer = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            txtName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(303, 253);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.Location = new Point(288, 35);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(111, 86);
            lblCount.TabIndex = 1;
            lblCount.Text = "10";
            lblCount.Click += label1_Click;
            // 
            // timer
            // 
            timer.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(257, 182);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(351, 180);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 23);
            txtName.TabIndex = 3;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblCount);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmStart";
            Text = "FrmStart";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblCount;
        private System.Windows.Forms.Timer timer;
        private Label label1;
        private TextBox txtName;
    }
}