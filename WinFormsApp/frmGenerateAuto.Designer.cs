namespace WinFormsApp
{
    partial class frmGenerateAuto
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
            label1 = new Label();
            numText = new NumericUpDown();
            AddText = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numText).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter number of text";
            label1.Click += label1_Click;
            // 
            // numText
            // 
            numText.Location = new Point(223, 22);
            numText.Name = "numText";
            numText.Size = new Size(150, 27);
            numText.TabIndex = 1;
            numText.ValueChanged += numText_ValueChanged;
            // 
            // AddText
            // 
            AddText.Location = new Point(415, 22);
            AddText.Name = "AddText";
            AddText.Size = new Size(94, 29);
            AddText.TabIndex = 2;
            AddText.Text = "Add text";
            AddText.UseVisualStyleBackColor = true;
            AddText.Click += AddText_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 410);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "addCheck";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmGenerateAuto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(AddText);
            Controls.Add(numText);
            Controls.Add(label1);
            Name = "frmGenerateAuto";
            Text = "frmGenerateAuto";
            FormClosing += frmGenerateAuto_FormClosing;
            ((System.ComponentModel.ISupportInitialize)numText).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numText;
        private Button AddText;
        private Button button1;
    }
}