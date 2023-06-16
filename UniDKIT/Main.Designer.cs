namespace UniDKIT
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            TopPanel = new Panel();
            FilePathText = new Label();
            Toolbar = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeFileToolStripMenuItem = new ToolStripMenuItem();
            directoryToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem1 = new ToolStripMenuItem();
            openInExplorerToolStripMenuItem = new ToolStripMenuItem();
            reloadFileTreeToolStripMenuItem = new ToolStripMenuItem();
            uniScriptToolStripMenuItem = new ToolStripMenuItem();
            uniDKITToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            testingToolStripMenuItem = new ToolStripMenuItem();
            writeHighlightingTestToolStripMenuItem = new ToolStripMenuItem();
            discordRPCToolStripMenuItem = new ToolStripMenuItem();
            disposeClientToolStripMenuItem = new ToolStripMenuItem();
            uniPKGToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            VersionText = new Label();
            panel2 = new Panel();
            Textbox = new FastColoredTextBoxNS.FastColoredTextBox();
            FileTreePanel = new Panel();
            FileTree = new TreeView();
            StatusPanel = new Panel();
            StatusText = new Label();
            setClientToolStripMenuItem = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            Toolbar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Textbox).BeginInit();
            FileTreePanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TopPanel.BackColor = Color.FromArgb(68, 68, 68);
            TopPanel.Controls.Add(FilePathText);
            TopPanel.Controls.Add(Toolbar);
            TopPanel.Location = new Point(166, 9);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(918, 60);
            TopPanel.TabIndex = 0;
            // 
            // FilePathText
            // 
            FilePathText.AutoSize = true;
            FilePathText.Location = new Point(0, 45);
            FilePathText.Name = "FilePathText";
            FilePathText.Size = new Size(84, 15);
            FilePathText.TabIndex = 1;
            FilePathText.Text = "No file loaded.";
            // 
            // Toolbar
            // 
            Toolbar.BackColor = Color.DimGray;
            Toolbar.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, directoryToolStripMenuItem, uniScriptToolStripMenuItem, uniDKITToolStripMenuItem, testingToolStripMenuItem, uniPKGToolStripMenuItem });
            Toolbar.Location = new Point(0, 0);
            Toolbar.Name = "Toolbar";
            Toolbar.Size = new Size(918, 24);
            Toolbar.TabIndex = 0;
            Toolbar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, closeFileToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(145, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(145, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(145, 22);
            saveToolStripMenuItem.Text = "Save changes";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // closeFileToolStripMenuItem
            // 
            closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            closeFileToolStripMenuItem.Size = new Size(145, 22);
            closeFileToolStripMenuItem.Text = "Close file";
            closeFileToolStripMenuItem.Click += closeFileToolStripMenuItem_Click;
            // 
            // directoryToolStripMenuItem
            // 
            directoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, openInExplorerToolStripMenuItem, reloadFileTreeToolStripMenuItem });
            directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            directoryToolStripMenuItem.Size = new Size(67, 20);
            directoryToolStripMenuItem.Text = "Directory";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(162, 22);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // openInExplorerToolStripMenuItem
            // 
            openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            openInExplorerToolStripMenuItem.Size = new Size(162, 22);
            openInExplorerToolStripMenuItem.Text = "Open in explorer";
            openInExplorerToolStripMenuItem.Click += openInExplorerToolStripMenuItem_Click;
            // 
            // reloadFileTreeToolStripMenuItem
            // 
            reloadFileTreeToolStripMenuItem.Name = "reloadFileTreeToolStripMenuItem";
            reloadFileTreeToolStripMenuItem.Size = new Size(162, 22);
            reloadFileTreeToolStripMenuItem.Text = "Reload file tree";
            reloadFileTreeToolStripMenuItem.Click += reloadFileTreeToolStripMenuItem_Click;
            // 
            // uniScriptToolStripMenuItem
            // 
            uniScriptToolStripMenuItem.Name = "uniScriptToolStripMenuItem";
            uniScriptToolStripMenuItem.Size = new Size(67, 20);
            uniScriptToolStripMenuItem.Text = "UniScript";
            // 
            // uniDKITToolStripMenuItem
            // 
            uniDKITToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            uniDKITToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, aboutToolStripMenuItem });
            uniDKITToolStripMenuItem.Name = "uniDKITToolStripMenuItem";
            uniDKITToolStripMenuItem.RightToLeft = RightToLeft.No;
            uniDKITToolStripMenuItem.Size = new Size(61, 20);
            uniDKITToolStripMenuItem.Text = "UniDKIT";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // testingToolStripMenuItem
            // 
            testingToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            testingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { writeHighlightingTestToolStripMenuItem, discordRPCToolStripMenuItem });
            testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            testingToolStripMenuItem.Size = new Size(62, 20);
            testingToolStripMenuItem.Text = "[Debug]";
            // 
            // writeHighlightingTestToolStripMenuItem
            // 
            writeHighlightingTestToolStripMenuItem.Name = "writeHighlightingTestToolStripMenuItem";
            writeHighlightingTestToolStripMenuItem.Size = new Size(192, 22);
            writeHighlightingTestToolStripMenuItem.Text = "Write highlighting test";
            writeHighlightingTestToolStripMenuItem.Click += writeHighlightingTestToolStripMenuItem_Click;
            // 
            // discordRPCToolStripMenuItem
            // 
            discordRPCToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disposeClientToolStripMenuItem, setClientToolStripMenuItem });
            discordRPCToolStripMenuItem.Name = "discordRPCToolStripMenuItem";
            discordRPCToolStripMenuItem.Size = new Size(192, 22);
            discordRPCToolStripMenuItem.Text = "DiscordRPC";
            // 
            // disposeClientToolStripMenuItem
            // 
            disposeClientToolStripMenuItem.Name = "disposeClientToolStripMenuItem";
            disposeClientToolStripMenuItem.Size = new Size(180, 22);
            disposeClientToolStripMenuItem.Text = "Dispose client";
            disposeClientToolStripMenuItem.Click += disposeClientToolStripMenuItem_Click;
            // 
            // uniPKGToolStripMenuItem
            // 
            uniPKGToolStripMenuItem.Name = "uniPKGToolStripMenuItem";
            uniPKGToolStripMenuItem.Size = new Size(58, 20);
            uniPKGToolStripMenuItem.Text = "UniPKG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(124, 15);
            label2.TabIndex = 2;
            label2.Text = "Property of Pawełcorp";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(VersionText);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(148, 60);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Project Chicago";
            // 
            // VersionText
            // 
            VersionText.AutoSize = true;
            VersionText.Location = new Point(3, 19);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(66, 15);
            VersionText.TabIndex = 0;
            VersionText.Text = "VersionText";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(68, 68, 68);
            panel2.Controls.Add(Textbox);
            panel2.Location = new Point(166, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 529);
            panel2.TabIndex = 2;
            // 
            // Textbox
            // 
            Textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Textbox.AutoCompleteBrackets = true;
            Textbox.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            Textbox.AutoScrollMinSize = new Size(27, 15);
            Textbox.BackBrush = null;
            Textbox.BackColor = Color.FromArgb(40, 40, 40);
            Textbox.CharHeight = 15;
            Textbox.CharWidth = 8;
            Textbox.Cursor = Cursors.IBeam;
            Textbox.DisabledColor = Color.FromArgb(100, 180, 180, 180);
            Textbox.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Textbox.IndentBackColor = Color.DimGray;
            Textbox.IsReplaceMode = false;
            Textbox.LineNumberColor = Color.Silver;
            Textbox.Location = new Point(3, 3);
            Textbox.Name = "Textbox";
            Textbox.Paddings = new Padding(0);
            Textbox.SelectionColor = Color.FromArgb(80, 0, 0, 255);
            Textbox.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("Textbox.ServiceColors");
            Textbox.Size = new Size(912, 523);
            Textbox.TabIndex = 0;
            Textbox.Zoom = 100;
            Textbox.TextChanged += Textbox_TextChanged;
            // 
            // FileTreePanel
            // 
            FileTreePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FileTreePanel.BackColor = Color.FromArgb(68, 68, 68);
            FileTreePanel.Controls.Add(FileTree);
            FileTreePanel.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FileTreePanel.Location = new Point(12, 75);
            FileTreePanel.Name = "FileTreePanel";
            FileTreePanel.Size = new Size(148, 529);
            FileTreePanel.TabIndex = 3;
            // 
            // FileTree
            // 
            FileTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FileTree.BackColor = Color.FromArgb(40, 40, 40);
            FileTree.BorderStyle = BorderStyle.FixedSingle;
            FileTree.ForeColor = Color.White;
            FileTree.Indent = 19;
            FileTree.ItemHeight = 19;
            FileTree.Location = new Point(3, 3);
            FileTree.Name = "FileTree";
            FileTree.Size = new Size(142, 523);
            FileTree.TabIndex = 0;
            FileTree.NodeMouseDoubleClick += FileTree_NodeMouseDoubleClick;
            // 
            // StatusPanel
            // 
            StatusPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusPanel.BackColor = Color.DimGray;
            StatusPanel.Controls.Add(StatusText);
            StatusPanel.Location = new Point(15, 610);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(1069, 19);
            StatusPanel.TabIndex = 4;
            // 
            // StatusText
            // 
            StatusText.AutoSize = true;
            StatusText.BackColor = Color.Transparent;
            StatusText.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StatusText.Location = new Point(0, 0);
            StatusText.Name = "StatusText";
            StatusText.Size = new Size(71, 19);
            StatusText.TabIndex = 0;
            StatusText.Text = "StatusText";
            // 
            // setClientToolStripMenuItem
            // 
            setClientToolStripMenuItem.Name = "setClientToolStripMenuItem";
            setClientToolStripMenuItem.Size = new Size(180, 22);
            setClientToolStripMenuItem.Text = "Set client";
            setClientToolStripMenuItem.Click += setClientToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(1096, 641);
            Controls.Add(StatusPanel);
            Controls.Add(FileTreePanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            ForeColor = SystemColors.Control;
            MainMenuStrip = Toolbar;
            Name = "Main";
            Text = "UniDKIT";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            Toolbar.ResumeLayout(false);
            Toolbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Textbox).EndInit();
            FileTreePanel.ResumeLayout(false);
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private Panel panel1;
        private MenuStrip Toolbar;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label VersionText;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private FastColoredTextBoxNS.FastColoredTextBox Textbox;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripMenuItem writeHighlightingTestToolStripMenuItem;
        private Label FilePathText;
        private ToolStripMenuItem directoryToolStripMenuItem;
        private Panel FileTreePanel;
        private TreeView FileTree;
        private ToolStripMenuItem openToolStripMenuItem1;
        private Panel StatusPanel;
        private Label StatusText;
        private ToolStripMenuItem openInExplorerToolStripMenuItem;
        private ToolStripMenuItem reloadFileTreeToolStripMenuItem;
        private ToolStripMenuItem uniScriptToolStripMenuItem;
        private ToolStripMenuItem uniDKITToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem closeFileToolStripMenuItem;
        private ToolStripMenuItem uniPKGToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem discordRPCToolStripMenuItem;
        private ToolStripMenuItem disposeClientToolStripMenuItem;
        private ToolStripMenuItem setClientToolStripMenuItem;

        /*
            Jebac Mickiewicza
        */
    }
}