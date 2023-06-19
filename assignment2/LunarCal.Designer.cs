namespace assignment2
{
    partial class LunarCal
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
            label1 = new Label();
            View = new Button();
            txtdl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtal = new TextBox();
            Exit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            dea = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 12);
            label1.Name = "label1";
            label1.Size = new Size(545, 32);
            label1.TabIndex = 0;
            label1.Text = "Chuong trinh doi nam duong lich sang am lich";
            // 
            // View
            // 
            View.ImageAlign = ContentAlignment.MiddleLeft;
            View.Location = new Point(151, 215);
            View.Margin = new Padding(3, 4, 3, 4);
            View.Name = "View";
            View.Size = new Size(86, 31);
            View.TabIndex = 1;
            View.Text = "View";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // txtdl
            // 
            txtdl.Location = new Point(311, 71);
            txtdl.Margin = new Padding(3, 4, 3, 4);
            txtdl.Name = "txtdl";
            txtdl.Size = new Size(114, 27);
            txtdl.TabIndex = 2;
            txtdl.TextChanged += txtdl_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(151, 71);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 3;
            label2.Text = "nam duong lich:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(151, 129);
            label3.Name = "label3";
            label3.Size = new Size(113, 23);
            label3.TabIndex = 4;
            label3.Text = "nam am lich:";
            // 
            // txtal
            // 
            txtal.Enabled = false;
            txtal.Location = new Point(311, 129);
            txtal.Margin = new Padding(3, 4, 3, 4);
            txtal.Name = "txtal";
            txtal.Size = new Size(114, 27);
            txtal.TabIndex = 5;
            txtal.TabStop = false;
            txtal.TextChanged += txtal_TextChanged;
            // 
            // Exit
            // 
            Exit.ImageAlign = ContentAlignment.MiddleRight;
            Exit.Location = new Point(339, 215);
            Exit.Margin = new Padding(3, 4, 3, 4);
            Exit.Name = "Exit";
            Exit.Size = new Size(86, 31);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dea
            // 
            dea.AutoSize = true;
            dea.Location = new Point(50, 94);
            dea.Name = "dea";
            dea.Size = new Size(33, 20);
            dea.TabIndex = 7;
            dea.Text = "test";
            // 
            // LunarCal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 273);
            Controls.Add(dea);
            Controls.Add(Exit);
            Controls.Add(txtal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtdl);
            Controls.Add(View);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LunarCal";
            Text = "LunarCal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button View;
        private TextBox txtdl;
        private Label label2;
        private Label label3;
        private TextBox txtal;
        private Button Exit;
        private Bitmap ResizeImage(Image originalImage, int desiredWidth, int desiredHeight)
        {
            Bitmap resizedImage = new Bitmap(desiredWidth, desiredHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.DrawImage(originalImage, 0, 0, desiredWidth, desiredHeight);
            }
            return resizedImage;
        }

        private System.Windows.Forms.Timer timer1;
        private Label dea;
    }

}