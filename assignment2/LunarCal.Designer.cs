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
            label1 = new Label();
            View = new Button();
            txtdl = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtal = new TextBox();
            Exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(423, 25);
            label1.TabIndex = 0;
            label1.Text = "Chuong trinh doi nam duong lich sang am lich";
            // 
            // View
            // 
            View.Image = ResizeImage(Properties.Resources._223930,20,20);
            View.ImageAlign = ContentAlignment.MiddleLeft;
            View.Location = new Point(132, 161);
            View.Name = "View";
            View.Size = new Size(75, 23);
            View.TabIndex = 1;
            View.Text = "View";
            View.UseVisualStyleBackColor = true;
            View.Click += View_Click;
            // 
            // txtdl
            // 
            txtdl.Location = new Point(272, 53);
            txtdl.Name = "txtdl";
            txtdl.Size = new Size(100, 23);
            txtdl.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(132, 53);
            label2.Name = "label2";
            label2.Size = new Size(109, 17);
            label2.TabIndex = 3;
            label2.Text = "nam duong lich:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(132, 97);
            label3.Name = "label3";
            label3.Size = new Size(88, 17);
            label3.TabIndex = 4;
            label3.Text = "nam am lich:";
            // 
            // txtal
            // 
            txtal.Location = new Point(272, 97);
            txtal.Name = "txtal";
            txtal.Size = new Size(100, 23);
            txtal.TabIndex = 5;
            // 
            // Exit
            // 
            Exit.Image = ResizeImage(Properties.Resources.free_exit_logout_icon_2857_thumb, 20, 20);
            Exit.ImageAlign = ContentAlignment.MiddleRight;
            Exit.Location = new Point(297, 161);
            Exit.Name = "Exit";
            Exit.Size = new Size(75, 23);
            Exit.TabIndex = 6;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // LunarCal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 205);
            Controls.Add(Exit);
            Controls.Add(txtal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtdl);
            Controls.Add(View);
            Controls.Add(label1);
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
    }

}