﻿namespace WinFormsApp
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
            gb1 = new GroupBox();
            output = new GroupBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)numText).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 20);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter number of text";
            label1.Click += label1_Click;
            // 
            // numText
            // 
            numText.Location = new Point(195, 16);
            numText.Margin = new Padding(3, 2, 3, 2);
            numText.Name = "numText";
            numText.Size = new Size(131, 23);
            numText.TabIndex = 1;
            // 
            // AddText
            // 
            AddText.Location = new Point(363, 16);
            AddText.Margin = new Padding(3, 2, 3, 2);
            AddText.Name = "AddText";
            AddText.Size = new Size(82, 22);
            AddText.TabIndex = 2;
            AddText.Text = "Add text";
            AddText.UseVisualStyleBackColor = true;
            AddText.Click += AddText_Click;
            // 
            // button1
            // 
            button1.Location = new Point(106, 308);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "addCheck";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // gb1
            // 
            gb1.Location = new Point(22, 61);
            gb1.Name = "gb1";
            gb1.Size = new Size(304, 242);
            gb1.TabIndex = 4;
            gb1.TabStop = false;
            gb1.Text = "input";
            // 
            // output
            // 
            output.Location = new Point(363, 61);
            output.Name = "output";
            output.Size = new Size(316, 242);
            output.TabIndex = 5;
            output.TabStop = false;
            output.Text = "output";
            // 
            // button2
            // 
            button2.Location = new Point(487, 308);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 6;
            button2.Text = "print checked";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmGenerateAuto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button2);
            Controls.Add(output);
            Controls.Add(gb1);
            Controls.Add(button1);
            Controls.Add(AddText);
            Controls.Add(numText);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
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
        private GroupBox gb1;
        private GroupBox output;
        private Button button2;
    }
}