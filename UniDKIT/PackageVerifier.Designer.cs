namespace UniDKIT
{
    partial class PackageVerifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageVerifier));
            panel1 = new Panel();
            DetailTextUninst = new Label();
            DetailTextInst = new Label();
            DetailTextPkgInfo = new Label();
            UninstOkText = new Label();
            InstOkText = new Label();
            PkginfoOkText = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            BrowseButton = new Button();
            PathTextbox = new TextBox();
            CheckPackageButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(DetailTextUninst);
            panel1.Controls.Add(DetailTextInst);
            panel1.Controls.Add(DetailTextPkgInfo);
            panel1.Controls.Add(UninstOkText);
            panel1.Controls.Add(InstOkText);
            panel1.Controls.Add(PkginfoOkText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 192);
            panel1.TabIndex = 3;
            // 
            // DetailTextUninst
            // 
            DetailTextUninst.AutoSize = true;
            DetailTextUninst.Location = new Point(17, 156);
            DetailTextUninst.Name = "DetailTextUninst";
            DetailTextUninst.Size = new Size(92, 15);
            DetailTextUninst.TabIndex = 8;
            DetailTextUninst.Text = "DetailTextUninst";
            // 
            // DetailTextInst
            // 
            DetailTextInst.AutoSize = true;
            DetailTextInst.Location = new Point(17, 102);
            DetailTextInst.Name = "DetailTextInst";
            DetailTextInst.Size = new Size(77, 15);
            DetailTextInst.TabIndex = 7;
            DetailTextInst.Text = "DetailTextInst";
            // 
            // DetailTextPkgInfo
            // 
            DetailTextPkgInfo.AutoSize = true;
            DetailTextPkgInfo.Location = new Point(17, 47);
            DetailTextPkgInfo.Name = "DetailTextPkgInfo";
            DetailTextPkgInfo.Size = new Size(99, 15);
            DetailTextPkgInfo.TabIndex = 6;
            DetailTextPkgInfo.Text = "DetailTextPkgInfo";
            // 
            // UninstOkText
            // 
            UninstOkText.AutoSize = true;
            UninstOkText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            UninstOkText.Location = new Point(122, 128);
            UninstOkText.Name = "UninstOkText";
            UninstOkText.Size = new Size(104, 30);
            UninstOkText.TabIndex = 5;
            UninstOkText.Text = "Unknown";
            // 
            // InstOkText
            // 
            InstOkText.AutoSize = true;
            InstOkText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            InstOkText.Location = new Point(122, 74);
            InstOkText.Name = "InstOkText";
            InstOkText.Size = new Size(104, 30);
            InstOkText.TabIndex = 4;
            InstOkText.Text = "Unknown";
            // 
            // PkginfoOkText
            // 
            PkginfoOkText.AutoSize = true;
            PkginfoOkText.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            PkginfoOkText.ForeColor = Color.White;
            PkginfoOkText.Location = new Point(122, 19);
            PkginfoOkText.Name = "PkginfoOkText";
            PkginfoOkText.Size = new Size(104, 30);
            PkginfoOkText.TabIndex = 3;
            PkginfoOkText.Text = "Unknown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 128);
            label3.Name = "label3";
            label3.Size = new Size(69, 28);
            label3.TabIndex = 2;
            label3.Text = ".uninst";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 1;
            label2.Text = ".inst";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 0;
            label1.Text = ".pkginfo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 281);
            label4.Name = "label4";
            label4.Size = new Size(235, 12);
            label4.TabIndex = 8;
            label4.Text = "*This tool does not check if your package will actually install";
            // 
            // BrowseButton
            // 
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(206, 12);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(58, 23);
            BrowseButton.TabIndex = 5;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // PathTextbox
            // 
            PathTextbox.BackColor = Color.FromArgb(68, 68, 68);
            PathTextbox.BorderStyle = BorderStyle.FixedSingle;
            PathTextbox.ForeColor = SystemColors.Control;
            PathTextbox.Location = new Point(12, 12);
            PathTextbox.Name = "PathTextbox";
            PathTextbox.Size = new Size(188, 23);
            PathTextbox.TabIndex = 6;
            PathTextbox.TextChanged += PathTextbox_TextChanged;
            // 
            // CheckPackageButton
            // 
            CheckPackageButton.FlatStyle = FlatStyle.Flat;
            CheckPackageButton.Location = new Point(29, 51);
            CheckPackageButton.Name = "CheckPackageButton";
            CheckPackageButton.Size = new Size(219, 29);
            CheckPackageButton.TabIndex = 7;
            CheckPackageButton.Text = "Check package data";
            CheckPackageButton.UseVisualStyleBackColor = true;
            CheckPackageButton.Click += CheckPackageButton_Click;
            // 
            // PackageVerifier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(276, 301);
            Controls.Add(label4);
            Controls.Add(CheckPackageButton);
            Controls.Add(PathTextbox);
            Controls.Add(BrowseButton);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PackageVerifier";
            Text = "Package Verifier";
            Load += PackageVerifier_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label PkginfoOkText;
        private Label UninstOkText;
        private Label InstOkText;
        private Button BrowseButton;
        private TextBox PathTextbox;
        private Button CheckPackageButton;
        private Label DetailTextPkgInfo;
        private Label DetailTextInst;
        private Label DetailTextUninst;
        private Label label4;
    }
}