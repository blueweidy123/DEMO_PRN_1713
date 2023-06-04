namespace assignment2
{
    partial class SecurityPanel
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
            b1 = new Button();
            lvLog = new ListView();
            lblSCode = new Label();
            txtSCode = new TextBox();
            bclear = new Button();
            b3 = new Button();
            b2 = new Button();
            b5 = new Button();
            b6 = new Button();
            bok = new Button();
            b4 = new Button();
            b8 = new Button();
            b9 = new Button();
            b0 = new Button();
            b7 = new Button();
            lblLog = new Label();
            SuspendLayout();
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b1.Location = new Point(26, 60);
            b1.Name = "b1";
            b1.Size = new Size(45, 45);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            // 
            // lvLog
            // 
            lvLog.Alignment = ListViewAlignment.Default;
            lvLog.GridLines = true;
            lvLog.Location = new Point(12, 258);
            lvLog.Name = "lvLog";
            lvLog.Size = new Size(231, 121);
            lvLog.TabIndex = 1;
            lvLog.UseCompatibleStateImageBehavior = false;
            lvLog.View = View.List;
            // 
            // lblSCode
            // 
            lblSCode.AutoSize = true;
            lblSCode.Location = new Point(12, 27);
            lblSCode.Name = "lblSCode";
            lblSCode.Size = new Size(78, 15);
            lblSCode.TabIndex = 2;
            lblSCode.Text = "Security code";
            // 
            // txtSCode
            // 
            txtSCode.Location = new Point(96, 24);
            txtSCode.Name = "txtSCode";
            txtSCode.PasswordChar = '*';
            txtSCode.ReadOnly = true;
            txtSCode.Size = new Size(147, 23);
            txtSCode.TabIndex = 3;
            txtSCode.TextAlign = HorizontalAlignment.Center;
            // 
            // bclear
            // 
            bclear.BackColor = Color.Gold;
            bclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bclear.ForeColor = Color.FromArgb(128, 255, 255);
            bclear.Location = new Point(179, 60);
            bclear.Name = "bclear";
            bclear.Size = new Size(45, 45);
            bclear.TabIndex = 11;
            bclear.Text = "C";
            bclear.UseVisualStyleBackColor = false;
            bclear.Click += bclear_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(128, 60);
            b3.Name = "b3";
            b3.Size = new Size(45, 45);
            b3.TabIndex = 12;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(77, 60);
            b2.Name = "b2";
            b2.Size = new Size(45, 45);
            b2.TabIndex = 13;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(77, 111);
            b5.Name = "b5";
            b5.Size = new Size(45, 45);
            b5.TabIndex = 17;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(128, 111);
            b6.Name = "b6";
            b6.Size = new Size(45, 45);
            b6.TabIndex = 16;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = true;
            b6.Click += b6_Click;
            // 
            // bok
            // 
            bok.BackColor = SystemColors.ActiveCaption;
            bok.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bok.ForeColor = Color.FromArgb(255, 128, 255);
            bok.Location = new Point(179, 111);
            bok.Name = "bok";
            bok.Size = new Size(45, 45);
            bok.TabIndex = 15;
            bok.Text = "OK";
            bok.UseVisualStyleBackColor = false;
            bok.Click += bok_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(26, 111);
            b4.Name = "b4";
            b4.Size = new Size(45, 45);
            b4.TabIndex = 14;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(77, 162);
            b8.Name = "b8";
            b8.Size = new Size(45, 45);
            b8.TabIndex = 21;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(128, 162);
            b9.Name = "b9";
            b9.Size = new Size(45, 45);
            b9.TabIndex = 20;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b0.Location = new Point(179, 162);
            b0.Name = "b0";
            b0.Size = new Size(45, 45);
            b0.TabIndex = 19;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(26, 162);
            b7.Name = "b7";
            b7.Size = new Size(45, 45);
            b7.TabIndex = 18;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(12, 240);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(63, 15);
            lblLog.TabIndex = 22;
            lblLog.Text = "Access log";
            // 
            // SecurityPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 391);
            Controls.Add(lblLog);
            Controls.Add(b8);
            Controls.Add(b9);
            Controls.Add(b0);
            Controls.Add(b7);
            Controls.Add(b5);
            Controls.Add(b6);
            Controls.Add(bok);
            Controls.Add(b4);
            Controls.Add(b2);
            Controls.Add(b3);
            Controls.Add(bclear);
            Controls.Add(txtSCode);
            Controls.Add(lblSCode);
            Controls.Add(lvLog);
            Controls.Add(b1);
            Name = "SecurityPanel";
            Text = "SecurityPanel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b1;
        private ListView lvLog;
        private Label lblSCode;
        private TextBox txtSCode;
        private Button bclear;
        private Button b3;
        private Button b2;
        private Button b5;
        private Button b6;
        private Button bok;
        private Button b4;
        private Button b8;
        private Button b9;
        private Button b0;
        private Button b7;
        private Label lblLog;
    }
}