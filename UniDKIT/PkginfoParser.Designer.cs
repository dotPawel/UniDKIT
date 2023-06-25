namespace UniDKIT
{
    partial class PkginfoParser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PkginfoParser));
            PathTextbox = new TextBox();
            BrowseButton = new Button();
            panel1 = new Panel();
            OutputTextbox = new TextBox();
            ParseButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PathTextbox
            // 
            PathTextbox.BackColor = Color.FromArgb(68, 68, 68);
            PathTextbox.BorderStyle = BorderStyle.FixedSingle;
            PathTextbox.ForeColor = SystemColors.Control;
            PathTextbox.Location = new Point(12, 12);
            PathTextbox.Name = "PathTextbox";
            PathTextbox.Size = new Size(188, 23);
            PathTextbox.TabIndex = 8;
            // 
            // BrowseButton
            // 
            BrowseButton.FlatStyle = FlatStyle.Flat;
            BrowseButton.Location = new Point(206, 12);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(58, 23);
            BrowseButton.TabIndex = 7;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = true;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(ParseButton);
            panel1.Controls.Add(OutputTextbox);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(251, 206);
            panel1.TabIndex = 9;
            // 
            // OutputTextbox
            // 
            OutputTextbox.BackColor = Color.FromArgb(40, 40, 40);
            OutputTextbox.BorderStyle = BorderStyle.FixedSingle;
            OutputTextbox.ForeColor = SystemColors.Control;
            OutputTextbox.Location = new Point(3, 44);
            OutputTextbox.Multiline = true;
            OutputTextbox.Name = "OutputTextbox";
            OutputTextbox.Size = new Size(245, 159);
            OutputTextbox.TabIndex = 0;
            // 
            // ParseButton
            // 
            ParseButton.FlatStyle = FlatStyle.Flat;
            ParseButton.Location = new Point(0, 3);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(245, 35);
            ParseButton.TabIndex = 1;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            // 
            // PkginfoParser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(275, 259);
            Controls.Add(panel1);
            Controls.Add(PathTextbox);
            Controls.Add(BrowseButton);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PkginfoParser";
            Text = "Package Information Parser";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PathTextbox;
        private Button BrowseButton;
        private Panel panel1;
        private TextBox OutputTextbox;
        private Button ParseButton;
    }
}