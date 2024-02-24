namespace UniDKIT
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            VersionText = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.UniDKIT_png;
            pictureBox1.Location = new Point(4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 5);
            label1.Name = "label1";
            label1.Size = new Size(141, 46);
            label1.TabIndex = 1;
            label1.Text = "UniDKIT";
            // 
            // VersionText
            // 
            VersionText.AutoSize = true;
            VersionText.Location = new Point(232, 29);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(83, 15);
            VersionText.TabIndex = 2;
            VersionText.Text = "// VersionHere";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 118);
            label2.Name = "label2";
            label2.Size = new Size(309, 15);
            label2.TabIndex = 3;
            label2.Text = "Pawełcorp Enterprises 2023, All rights (not really) reserved";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 60);
            label3.Name = "label3";
            label3.Size = new Size(225, 13);
            label3.TabIndex = 4;
            label3.Text = "The officall UniversalCMD development kit\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(110, 82);
            label4.Name = "label4";
            label4.Size = new Size(224, 17);
            label4.TabIndex = 5;
            label4.Text = "https://github.com/dotPawel/UniDKIT";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(VersionText);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 106);
            panel1.TabIndex = 6;
            // 
            // About
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(359, 141);
            Controls.Add(panel1);
            Controls.Add(label2);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "About";
            Text = "About UniDKIT";
            Load += About_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label VersionText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}