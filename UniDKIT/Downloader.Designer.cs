namespace UniDKIT
{
    partial class Downloader
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
            panel1 = new Panel();
            BrowseButton = new Button();
            OutputTextbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            InputTextbox = new TextBox();
            InfoButton = new RadioButton();
            PackageButton = new RadioButton();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(BrowseButton);
            panel1.Controls.Add(OutputTextbox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(InputTextbox);
            panel1.Controls.Add(InfoButton);
            panel1.Controls.Add(PackageButton);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 201);
            panel1.TabIndex = 5;
            // 
            // BrowseButton
            // 
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(241, 124);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(75, 23);
            BrowseButton.TabIndex = 6;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // OutputTextbox
            // 
            OutputTextbox.BackColor = Color.FromArgb(68, 68, 68);
            OutputTextbox.BorderStyle = BorderStyle.FixedSingle;
            OutputTextbox.ForeColor = SystemColors.Control;
            OutputTextbox.Location = new Point(3, 124);
            OutputTextbox.Name = "OutputTextbox";
            OutputTextbox.Size = new Size(232, 23);
            OutputTextbox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 100);
            label2.Name = "label2";
            label2.Size = new Size(94, 21);
            label2.TabIndex = 4;
            label2.Text = "Output path";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 37);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 3;
            label1.Text = "Package name";
            // 
            // InputTextbox
            // 
            InputTextbox.BackColor = Color.FromArgb(68, 68, 68);
            InputTextbox.BorderStyle = BorderStyle.FixedSingle;
            InputTextbox.ForeColor = SystemColors.Control;
            InputTextbox.Location = new Point(3, 61);
            InputTextbox.Name = "InputTextbox";
            InputTextbox.Size = new Size(313, 23);
            InputTextbox.TabIndex = 2;
            InputTextbox.TextChanged += InputTextbox_TextChanged;
            // 
            // InfoButton
            // 
            InfoButton.AutoSize = true;
            InfoButton.Location = new Point(172, 3);
            InfoButton.Name = "InfoButton";
            InfoButton.RightToLeft = RightToLeft.Yes;
            InfoButton.Size = new Size(148, 19);
            InfoButton.TabIndex = 1;
            InfoButton.TabStop = true;
            InfoButton.Text = "Package info (.pkginfo)";
            InfoButton.UseVisualStyleBackColor = true;
            InfoButton.CheckedChanged += OnUncheck;
            // 
            // PackageButton
            // 
            PackageButton.AutoSize = true;
            PackageButton.Checked = true;
            PackageButton.Location = new Point(3, 3);
            PackageButton.Name = "PackageButton";
            PackageButton.Size = new Size(139, 19);
            PackageButton.TabIndex = 0;
            PackageButton.TabStop = true;
            PackageButton.Text = "Package file (.unipkg)";
            PackageButton.UseVisualStyleBackColor = true;
            PackageButton.CheckedChanged += OnUncheck;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 153);
            button1.Name = "button1";
            button1.Size = new Size(313, 48);
            button1.TabIndex = 7;
            button1.Text = "Pull";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Downloader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(346, 225);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Downloader";
            Text = "Downloader";
            Load += Downloader_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton PackageButton;
        private RadioButton InfoButton;
        private TextBox InputTextbox;
        private Label label1;
        private Label label2;
        private TextBox OutputTextbox;
        private Button BrowseButton;
        private Button button1;
    }
}