namespace UniDKIT
{
    partial class Packager
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
            StartButton = new Button();
            label2 = new Label();
            OutputBrowseButton = new Button();
            OutputTextbox = new TextBox();
            label1 = new Label();
            InputBrowseButton = new Button();
            InputTextbox = new TextBox();
            PackageRButton = new RadioButton();
            DepackageRButton = new RadioButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OutputBrowseButton);
            panel1.Controls.Add(OutputTextbox);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(InputBrowseButton);
            panel1.Controls.Add(InputTextbox);
            panel1.Location = new Point(12, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 168);
            panel1.TabIndex = 4;
            // 
            // StartButton
            // 
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Location = new Point(3, 120);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(245, 45);
            StartButton.TabIndex = 13;
            StartButton.Text = "Package/Depackage";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 58);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 12;
            label2.Text = "Output";
            // 
            // OutputBrowseButton
            // 
            OutputBrowseButton.FlatStyle = FlatStyle.Flat;
            OutputBrowseButton.Location = new Point(185, 81);
            OutputBrowseButton.Name = "OutputBrowseButton";
            OutputBrowseButton.Size = new Size(63, 23);
            OutputBrowseButton.TabIndex = 11;
            OutputBrowseButton.Text = "Browse";
            OutputBrowseButton.UseVisualStyleBackColor = true;
            OutputBrowseButton.Click += OutputBrowseButton_Click;
            // 
            // OutputTextbox
            // 
            OutputTextbox.BackColor = Color.FromArgb(68, 68, 68);
            OutputTextbox.BorderStyle = BorderStyle.FixedSingle;
            OutputTextbox.Location = new Point(3, 81);
            OutputTextbox.Name = "OutputTextbox";
            OutputTextbox.Size = new Size(176, 23);
            OutputTextbox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 9;
            label1.Text = "Input";
            // 
            // InputBrowseButton
            // 
            InputBrowseButton.FlatStyle = FlatStyle.Flat;
            InputBrowseButton.Location = new Point(185, 25);
            InputBrowseButton.Name = "InputBrowseButton";
            InputBrowseButton.Size = new Size(63, 23);
            InputBrowseButton.TabIndex = 8;
            InputBrowseButton.Text = "Browse";
            InputBrowseButton.UseVisualStyleBackColor = true;
            InputBrowseButton.Click += InputBrowseButton_Click;
            // 
            // InputTextbox
            // 
            InputTextbox.BackColor = Color.FromArgb(68, 68, 68);
            InputTextbox.BorderStyle = BorderStyle.FixedSingle;
            InputTextbox.Location = new Point(3, 25);
            InputTextbox.Name = "InputTextbox";
            InputTextbox.Size = new Size(176, 23);
            InputTextbox.TabIndex = 7;
            // 
            // PackageRButton
            // 
            PackageRButton.AutoSize = true;
            PackageRButton.Checked = true;
            PackageRButton.Location = new Point(12, 12);
            PackageRButton.Name = "PackageRButton";
            PackageRButton.Size = new Size(69, 19);
            PackageRButton.TabIndex = 5;
            PackageRButton.TabStop = true;
            PackageRButton.Text = "Package";
            PackageRButton.UseVisualStyleBackColor = true;
            PackageRButton.CheckedChanged += OnUncheck;
            // 
            // DepackageRButton
            // 
            DepackageRButton.AutoSize = true;
            DepackageRButton.Location = new Point(180, 12);
            DepackageRButton.Name = "DepackageRButton";
            DepackageRButton.RightToLeft = RightToLeft.Yes;
            DepackageRButton.Size = new Size(83, 19);
            DepackageRButton.TabIndex = 6;
            DepackageRButton.Text = "Depackage";
            DepackageRButton.UseVisualStyleBackColor = true;
            DepackageRButton.CheckedChanged += OnUncheck;
            // 
            // Packager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(274, 217);
            Controls.Add(DepackageRButton);
            Controls.Add(PackageRButton);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Packager";
            Text = "Packager/Depackager";
            Load += Packager_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private RadioButton PackageRButton;
        private RadioButton DepackageRButton;
        private TextBox InputTextbox;
        private Button InputBrowseButton;
        private Label label1;
        private Label label2;
        private Button OutputBrowseButton;
        private TextBox OutputTextbox;
        private Button StartButton;
    }
}