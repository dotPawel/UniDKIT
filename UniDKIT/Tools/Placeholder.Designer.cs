namespace UniDKIT.Tools
{
    partial class Placeholder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Placeholder));
            Mydlo = new PictureBox();
            Cyberlitery = new Label();
            ((System.ComponentModel.ISupportInitialize)Mydlo).BeginInit();
            SuspendLayout();
            // 
            // Mydlo
            // 
            Mydlo.BorderStyle = BorderStyle.Fixed3D;
            Mydlo.Location = new Point(12, 12);
            Mydlo.Name = "Mydlo";
            Mydlo.Size = new Size(247, 216);
            Mydlo.SizeMode = PictureBoxSizeMode.StretchImage;
            Mydlo.TabIndex = 0;
            Mydlo.TabStop = false;
            // 
            // Cyberlitery
            // 
            Cyberlitery.AutoSize = true;
            Cyberlitery.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Cyberlitery.Location = new Point(12, 236);
            Cyberlitery.Name = "Cyberlitery";
            Cyberlitery.Size = new Size(0, 12);
            Cyberlitery.TabIndex = 1;
            // 
            // Placeholder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(271, 281);
            Controls.Add(Cyberlitery);
            Controls.Add(Mydlo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Placeholder";
            Text = "CONGRATULATIONS";
            Load += Placeholder_Load;
            ((System.ComponentModel.ISupportInitialize)Mydlo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Mydlo;
        private Label Cyberlitery;
    }
}