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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempInstallEnv));
            panel1 = new Panel();
            LogCheckbox = new CheckBox();
            OpenExplorerButton = new Button();
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
            panel1.Controls.Add(LogCheckbox);
            panel1.Controls.Add(OpenExplorerButton);
            panel1.Controls.Add(DisposeButton);
            panel1.Controls.Add(DisposeEnvCheckbox);
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(BrowseButton);
            panel1.Controls.Add(PathTextbox);
            panel1.Controls.Add(MainTextbox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 420);
            panel1.TabIndex = 4;
            // 
            // LogCheckbox
            // 
            LogCheckbox.AutoSize = true;
            LogCheckbox.Location = new Point(230, 398);
            LogCheckbox.Name = "LogCheckbox";
            LogCheckbox.RightToLeft = RightToLeft.Yes;
            LogCheckbox.Size = new Size(161, 19);
            LogCheckbox.TabIndex = 8;
            LogCheckbox.Text = "Log to file (TempENV.log)";
            LogCheckbox.UseVisualStyleBackColor = true;
            // 
            // OpenExplorerButton
            // 
            OpenExplorerButton.FlatStyle = FlatStyle.Flat;
            OpenExplorerButton.Location = new Point(275, 32);
            OpenExplorerButton.Name = "OpenExplorerButton";
            OpenExplorerButton.Size = new Size(116, 23);
            OpenExplorerButton.TabIndex = 7;
            OpenExplorerButton.Text = "Open in explorer";
            OpenExplorerButton.UseVisualStyleBackColor = true;
            OpenExplorerButton.Click += OpenExplorerButton_Click;
            // 
            // DisposeButton
            // 
            DisposeButton.FlatStyle = FlatStyle.Flat;
            DisposeButton.Location = new Point(141, 32);
            DisposeButton.Name = "DisposeButton";
            DisposeButton.Size = new Size(116, 23);
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
            DisposeEnvCheckbox.Location = new Point(3, 398);
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
            StartButton.Size = new Size(116, 23);
            StartButton.TabIndex = 4;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // BrowseButton
            // 
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(316, 3);
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
            PathTextbox.Size = new Size(307, 23);
            PathTextbox.TabIndex = 2;
            // 
            // MainTextbox
            // 
            MainTextbox.BackColor = Color.FromArgb(68, 68, 68);
            MainTextbox.BorderStyle = BorderStyle.FixedSingle;
            MainTextbox.ForeColor = Color.White;
            MainTextbox.Location = new Point(3, 61);
            MainTextbox.Multiline = true;
            MainTextbox.Name = "MainTextbox";
            MainTextbox.ReadOnly = true;
            MainTextbox.ScrollBars = ScrollBars.Vertical;
            MainTextbox.Size = new Size(388, 331);
            MainTextbox.TabIndex = 1;
            // 
            // TempInstallEnv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(418, 444);
            Controls.Add(panel1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
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
        private Button OpenExplorerButton;
        private CheckBox LogCheckbox;
    }
}