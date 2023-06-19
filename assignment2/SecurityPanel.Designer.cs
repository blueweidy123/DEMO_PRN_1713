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
            b1.Location = new Point(30, 80);
            b1.Margin = new Padding(3, 4, 3, 4);
            b1.Name = "b1";
            b1.Size = new Size(51, 60);
            b1.TabIndex = 0;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = true;
            b1.Click += b1_Click;
            b1.Enter += b1_Enter;
            // 
            // lvLog
            // 
            lvLog.Alignment = ListViewAlignment.Default;
            lvLog.GridLines = true;
            lvLog.Location = new Point(14, 344);
            lvLog.Margin = new Padding(3, 4, 3, 4);
            lvLog.Name = "lvLog";
            lvLog.Size = new Size(263, 160);
            lvLog.TabIndex = 1;
            lvLog.UseCompatibleStateImageBehavior = false;
            lvLog.View = View.List;
            // 
            // lblSCode
            // 
            lblSCode.AutoSize = true;
            lblSCode.Location = new Point(14, 36);
            lblSCode.Name = "lblSCode";
            lblSCode.Size = new Size(98, 20);
            lblSCode.TabIndex = 2;
            lblSCode.Text = "Security code";
            // 
            // txtSCode
            // 
            txtSCode.Location = new Point(110, 32);
            txtSCode.Margin = new Padding(3, 4, 3, 4);
            txtSCode.Name = "txtSCode";
            txtSCode.PasswordChar = '*';
            txtSCode.ReadOnly = true;
            txtSCode.Size = new Size(167, 27);
            txtSCode.TabIndex = 3;
            txtSCode.TextAlign = HorizontalAlignment.Center;
            // 
            // bclear
            // 
            bclear.BackColor = Color.Gold;
            bclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bclear.ForeColor = Color.FromArgb(128, 255, 255);
            bclear.Location = new Point(205, 80);
            bclear.Margin = new Padding(3, 4, 3, 4);
            bclear.Name = "bclear";
            bclear.Size = new Size(51, 60);
            bclear.TabIndex = 11;
            bclear.Text = "C";
            bclear.UseVisualStyleBackColor = false;
            bclear.Click += bclear_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b3.Location = new Point(146, 80);
            b3.Margin = new Padding(3, 4, 3, 4);
            b3.Name = "b3";
            b3.Size = new Size(51, 60);
            b3.TabIndex = 12;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = true;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b2.Location = new Point(88, 80);
            b2.Margin = new Padding(3, 4, 3, 4);
            b2.Name = "b2";
            b2.Size = new Size(51, 60);
            b2.TabIndex = 13;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = true;
            b2.Click += b2_Click;
            b2.Enter += b2_Enter;
            // 
            // b5
            // 
            b5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b5.Location = new Point(88, 148);
            b5.Margin = new Padding(3, 4, 3, 4);
            b5.Name = "b5";
            b5.Size = new Size(51, 60);
            b5.TabIndex = 17;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = true;
            b5.Click += b5_Click;
            // 
            // b6
            // 
            b6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b6.Location = new Point(146, 148);
            b6.Margin = new Padding(3, 4, 3, 4);
            b6.Name = "b6";
            b6.Size = new Size(51, 60);
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
            bok.Location = new Point(205, 148);
            bok.Margin = new Padding(3, 4, 3, 4);
            bok.Name = "bok";
            bok.Size = new Size(51, 60);
            bok.TabIndex = 15;
            bok.Text = "OK";
            bok.UseVisualStyleBackColor = false;
            bok.Click += bok_Click;
            // 
            // b4
            // 
            b4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b4.Location = new Point(30, 148);
            b4.Margin = new Padding(3, 4, 3, 4);
            b4.Name = "b4";
            b4.Size = new Size(51, 60);
            b4.TabIndex = 14;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = true;
            b4.Click += b4_Click;
            // 
            // b8
            // 
            b8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b8.Location = new Point(88, 216);
            b8.Margin = new Padding(3, 4, 3, 4);
            b8.Name = "b8";
            b8.Size = new Size(51, 60);
            b8.TabIndex = 21;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = true;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b9.Location = new Point(146, 216);
            b9.Margin = new Padding(3, 4, 3, 4);
            b9.Name = "b9";
            b9.Size = new Size(51, 60);
            b9.TabIndex = 20;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = true;
            b9.Click += b9_Click;
            // 
            // b0
            // 
            b0.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b0.Location = new Point(205, 216);
            b0.Margin = new Padding(3, 4, 3, 4);
            b0.Name = "b0";
            b0.Size = new Size(51, 60);
            b0.TabIndex = 19;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = true;
            b0.Click += b0_Click;
            // 
            // b7
            // 
            b7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            b7.Location = new Point(30, 216);
            b7.Margin = new Padding(3, 4, 3, 4);
            b7.Name = "b7";
            b7.Size = new Size(51, 60);
            b7.TabIndex = 18;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = true;
            b7.Click += b7_Click;
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(14, 320);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(79, 20);
            lblLog.TabIndex = 22;
            lblLog.Text = "Access log";
            // 
            // SecurityPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 521);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "SecurityPanel";
            Text = "SecurityPanel";
            Load += SecurityPanel_Load;
            Enter += SecurityPanel_Enter;
            KeyUp += SecurityPanel_KeyUp;
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