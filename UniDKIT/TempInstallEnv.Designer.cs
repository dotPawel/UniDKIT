namespace UniDKIT
{
    partial class TempInstallEnv
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
            AutoCheckEnvCheckbox = new CheckBox();
            DisposeButton = new Button();
            DisposeEnvCheckbox = new CheckBox();
            StartButton = new Button();
            BrowseButton = new Button();
            PathTextbox = new TextBox();
            MainTextbox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(AutoCheckEnvCheckbox);
            panel1.Controls.Add(DisposeButton);
            panel1.Controls.Add(DisposeEnvCheckbox);
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(BrowseButton);
            panel1.Controls.Add(PathTextbox);
            panel1.Controls.Add(MainTextbox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 352);
            panel1.TabIndex = 4;
            // 
            // AutoCheckEnvCheckbox
            // 
            AutoCheckEnvCheckbox.AutoSize = true;
            AutoCheckEnvCheckbox.Checked = true;
            AutoCheckEnvCheckbox.CheckState = CheckState.Checked;
            AutoCheckEnvCheckbox.Location = new Point(3, 308);
            AutoCheckEnvCheckbox.Name = "AutoCheckEnvCheckbox";
            AutoCheckEnvCheckbox.Size = new Size(129, 19);
            AutoCheckEnvCheckbox.TabIndex = 7;
            AutoCheckEnvCheckbox.Text = "Auto check on start";
            AutoCheckEnvCheckbox.UseVisualStyleBackColor = true;
            // 
            // DisposeButton
            // 
            DisposeButton.FlatStyle = FlatStyle.Flat;
            DisposeButton.Location = new Point(84, 32);
            DisposeButton.Name = "DisposeButton";
            DisposeButton.Size = new Size(75, 23);
            DisposeButton.TabIndex = 6;
            DisposeButton.Text = "Dispose";
            DisposeButton.UseVisualStyleBackColor = true;
            DisposeButton.Click += DisposeButton_Click;
            // 
            // DisposeEnvCheckbox
            // 
            DisposeEnvCheckbox.AutoSize = true;
            DisposeEnvCheckbox.Checked = true;
            DisposeEnvCheckbox.CheckState = CheckState.Checked;
            DisposeEnvCheckbox.Location = new Point(3, 330);
            DisposeEnvCheckbox.Name = "DisposeEnvCheckbox";
            DisposeEnvCheckbox.Size = new Size(177, 19);
            DisposeEnvCheckbox.TabIndex = 5;
            DisposeEnvCheckbox.Text = "Dispose environment on exit";
            DisposeEnvCheckbox.UseVisualStyleBackColor = true;
            // 
            // StartButton
            // 
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Location = new Point(3, 32);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // BrowseButton
            // 
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(229, 3);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(75, 23);
            BrowseButton.TabIndex = 3;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // PathTextbox
            // 
            PathTextbox.BackColor = Color.FromArgb(68, 68, 68);
            PathTextbox.BorderStyle = BorderStyle.FixedSingle;
            PathTextbox.Location = new Point(3, 3);
            PathTextbox.Name = "PathTextbox";
            PathTextbox.Size = new Size(220, 23);
            PathTextbox.TabIndex = 2;
            // 
            // MainTextbox
            // 
            MainTextbox.BackColor = Color.FromArgb(68, 68, 68);
            MainTextbox.BorderStyle = BorderStyle.FixedSingle;
            MainTextbox.ForeColor = Color.White;
            MainTextbox.Location = new Point(3, 82);
            MainTextbox.Multiline = true;
            MainTextbox.Name = "MainTextbox";
            MainTextbox.ReadOnly = true;
            MainTextbox.Size = new Size(301, 220);
            MainTextbox.TabIndex = 1;
            // 
            // TempInstallEnv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(331, 376);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "TempInstallEnv";
            Text = "Temporary install environment";
            FormClosing += TempInstallEnv_FormClosing;
            Load += TempInstallEnv_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox MainTextbox;
        private Button BrowseButton;
        private TextBox PathTextbox;
        private Button StartButton;
        private CheckBox DisposeEnvCheckbox;
        private Button DisposeButton;
        private CheckBox AutoCheckEnvCheckbox;
    }
}