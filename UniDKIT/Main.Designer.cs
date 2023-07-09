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
            unloadDirectoryToolStripMenuItem = new ToolStripMenuItem();
            importFileToDirectoryToolStripMenuItem = new ToolStripMenuItem();
            uniScriptToolStripMenuItem = new ToolStripMenuItem();
            versionToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem = new ToolStripMenuItem();
            rToolStripMenuItem1 = new ToolStripMenuItem();
            uniDKITToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            testingToolStripMenuItem = new ToolStripMenuItem();
            writeHighlightingTestToolStripMenuItem = new ToolStripMenuItem();
            discordRPCToolStripMenuItem = new ToolStripMenuItem();
            disposeClientToolStripMenuItem = new ToolStripMenuItem();
            setClientToolStripMenuItem = new ToolStripMenuItem();
            uniPKGToolStripMenuItem = new ToolStripMenuItem();
            packageVerifierToolStripMenuItem = new ToolStripMenuItem();
            packageInformationParserToolStripMenuItem = new ToolStripMenuItem();
            packagerDepackagerToolStripMenuItem = new ToolStripMenuItem();
            temporaryInstallEnvironmentToolStripMenuItem = new ToolStripMenuItem();
            downloaderToolStripMenuItem = new ToolStripMenuItem();
            UnscVersionText = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            VersionText = new Label();
            Textbox = new FastColoredTextBoxNS.FastColoredTextBox();
            FileTree = new TreeView();
            StatusPanel = new Panel();
            StatusText = new Label();
            MainContainer = new SplitContainer();
            AutocompleteMenu = new AutocompleteMenuNS.AutocompleteMenu();
            clearTextboxStyleToolStripMenuItem = new ToolStripMenuItem();
            TopPanel.SuspendLayout();
            Toolbar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Textbox).BeginInit();
            StatusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
            MainContainer.Panel1.SuspendLayout();
            MainContainer.Panel2.SuspendLayout();
            MainContainer.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TopPanel.BackColor = Color.FromArgb(68, 68, 68);
            TopPanel.Controls.Add(FilePathText);
            TopPanel.Controls.Add(Toolbar);
            TopPanel.Location = new Point(183, 9);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(901, 60);
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
            Toolbar.Size = new Size(901, 24);
            Toolbar.TabIndex = 0;
            Toolbar.Text = "Toolbar";
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
            directoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem1, openInExplorerToolStripMenuItem, reloadFileTreeToolStripMenuItem, unloadDirectoryToolStripMenuItem, importFileToDirectoryToolStripMenuItem });
            directoryToolStripMenuItem.Name = "directoryToolStripMenuItem";
            directoryToolStripMenuItem.Size = new Size(67, 20);
            directoryToolStripMenuItem.Text = "Directory";
            // 
            // openToolStripMenuItem1
            // 
            openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            openToolStripMenuItem1.Size = new Size(193, 22);
            openToolStripMenuItem1.Text = "Open";
            openToolStripMenuItem1.Click += openToolStripMenuItem1_Click;
            // 
            // openInExplorerToolStripMenuItem
            // 
            openInExplorerToolStripMenuItem.Name = "openInExplorerToolStripMenuItem";
            openInExplorerToolStripMenuItem.Size = new Size(193, 22);
            openInExplorerToolStripMenuItem.Text = "Open in explorer";
            openInExplorerToolStripMenuItem.Click += openInExplorerToolStripMenuItem_Click;
            // 
            // reloadFileTreeToolStripMenuItem
            // 
            reloadFileTreeToolStripMenuItem.Name = "reloadFileTreeToolStripMenuItem";
            reloadFileTreeToolStripMenuItem.Size = new Size(193, 22);
            reloadFileTreeToolStripMenuItem.Text = "Reload file tree";
            reloadFileTreeToolStripMenuItem.Click += reloadFileTreeToolStripMenuItem_Click;
            // 
            // unloadDirectoryToolStripMenuItem
            // 
            unloadDirectoryToolStripMenuItem.Name = "unloadDirectoryToolStripMenuItem";
            unloadDirectoryToolStripMenuItem.Size = new Size(193, 22);
            unloadDirectoryToolStripMenuItem.Text = "Unload directory";
            unloadDirectoryToolStripMenuItem.Click += unloadDirectoryToolStripMenuItem_Click;
            // 
            // importFileToDirectoryToolStripMenuItem
            // 
            importFileToDirectoryToolStripMenuItem.Name = "importFileToDirectoryToolStripMenuItem";
            importFileToDirectoryToolStripMenuItem.Size = new Size(193, 22);
            importFileToDirectoryToolStripMenuItem.Text = "Import file to directory";
            importFileToDirectoryToolStripMenuItem.Click += importFileToDirectoryToolStripMenuItem_Click;
            // 
            // uniScriptToolStripMenuItem
            // 
            uniScriptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { versionToolStripMenuItem });
            uniScriptToolStripMenuItem.Name = "uniScriptToolStripMenuItem";
            uniScriptToolStripMenuItem.Size = new Size(67, 20);
            uniScriptToolStripMenuItem.Text = "UniScript";
            // 
            // versionToolStripMenuItem
            // 
            versionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rToolStripMenuItem, rToolStripMenuItem1 });
            versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            versionToolStripMenuItem.Size = new Size(112, 22);
            versionToolStripMenuItem.Text = "Version";
            versionToolStripMenuItem.DropDownItemClicked += versionToolStripMenuItem_DropDownItemClicked;
            // 
            // rToolStripMenuItem
            // 
            rToolStripMenuItem.Name = "rToolStripMenuItem";
            rToolStripMenuItem.Size = new Size(93, 22);
            rToolStripMenuItem.Text = "5.4r";
            // 
            // rToolStripMenuItem1
            // 
            rToolStripMenuItem1.Name = "rToolStripMenuItem1";
            rToolStripMenuItem1.Size = new Size(93, 22);
            rToolStripMenuItem1.Text = "6.0r";
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
            testingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { writeHighlightingTestToolStripMenuItem, discordRPCToolStripMenuItem, clearTextboxStyleToolStripMenuItem });
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
            disposeClientToolStripMenuItem.Size = new Size(147, 22);
            disposeClientToolStripMenuItem.Text = "Dispose client";
            disposeClientToolStripMenuItem.Click += disposeClientToolStripMenuItem_Click;
            // 
            // setClientToolStripMenuItem
            // 
            setClientToolStripMenuItem.Name = "setClientToolStripMenuItem";
            setClientToolStripMenuItem.Size = new Size(147, 22);
            setClientToolStripMenuItem.Text = "Set client";
            setClientToolStripMenuItem.Click += setClientToolStripMenuItem_Click;
            // 
            // uniPKGToolStripMenuItem
            // 
            uniPKGToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { packageVerifierToolStripMenuItem, packageInformationParserToolStripMenuItem, packagerDepackagerToolStripMenuItem, temporaryInstallEnvironmentToolStripMenuItem, downloaderToolStripMenuItem });
            uniPKGToolStripMenuItem.Name = "uniPKGToolStripMenuItem";
            uniPKGToolStripMenuItem.Size = new Size(58, 20);
            uniPKGToolStripMenuItem.Text = "UniPKG";
            // 
            // packageVerifierToolStripMenuItem
            // 
            packageVerifierToolStripMenuItem.Name = "packageVerifierToolStripMenuItem";
            packageVerifierToolStripMenuItem.Size = new Size(235, 22);
            packageVerifierToolStripMenuItem.Text = "Package verifier";
            packageVerifierToolStripMenuItem.Click += packageVerifierToolStripMenuItem_Click;
            // 
            // packageInformationParserToolStripMenuItem
            // 
            packageInformationParserToolStripMenuItem.Name = "packageInformationParserToolStripMenuItem";
            packageInformationParserToolStripMenuItem.Size = new Size(235, 22);
            packageInformationParserToolStripMenuItem.Text = "Package information parser";
            packageInformationParserToolStripMenuItem.Click += packageInformationParserToolStripMenuItem_Click;
            // 
            // packagerDepackagerToolStripMenuItem
            // 
            packagerDepackagerToolStripMenuItem.Name = "packagerDepackagerToolStripMenuItem";
            packagerDepackagerToolStripMenuItem.Size = new Size(235, 22);
            packagerDepackagerToolStripMenuItem.Text = "Packager/Depackager";
            packagerDepackagerToolStripMenuItem.Click += packagerDepackagerToolStripMenuItem_Click;
            // 
            // temporaryInstallEnvironmentToolStripMenuItem
            // 
            temporaryInstallEnvironmentToolStripMenuItem.Name = "temporaryInstallEnvironmentToolStripMenuItem";
            temporaryInstallEnvironmentToolStripMenuItem.Size = new Size(235, 22);
            temporaryInstallEnvironmentToolStripMenuItem.Text = "Temporary install environment";
            temporaryInstallEnvironmentToolStripMenuItem.Click += temporaryInstallEnvironmentToolStripMenuItem_Click;
            // 
            // downloaderToolStripMenuItem
            // 
            downloaderToolStripMenuItem.Name = "downloaderToolStripMenuItem";
            downloaderToolStripMenuItem.Size = new Size(235, 22);
            downloaderToolStripMenuItem.Text = "Downloader";
            downloaderToolStripMenuItem.Click += downloaderToolStripMenuItem_Click;
            // 
            // UnscVersionText
            // 
            UnscVersionText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            UnscVersionText.AutoSize = true;
            UnscVersionText.Location = new Point(1036, 2);
            UnscVersionText.Name = "UnscVersionText";
            UnscVersionText.RightToLeft = RightToLeft.Yes;
            UnscVersionText.Size = new Size(30, 15);
            UnscVersionText.TabIndex = 1;
            UnscVersionText.Text = "X.Xx";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(68, 68, 68);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(VersionText);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 60);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 39);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 3;
            label2.Text = "Pawełcorp©";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.unidkit_icon;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "UniDKIT";
            // 
            // VersionText
            // 
            VersionText.AutoSize = true;
            VersionText.Location = new Point(65, 24);
            VersionText.Name = "VersionText";
            VersionText.Size = new Size(66, 15);
            VersionText.TabIndex = 0;
            VersionText.Text = "VersionText";
            // 
            // Textbox
            // 
            Textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Textbox.AutoCompleteBrackets = true;
            Textbox.AutoCompleteBracketsList = (new char[] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' });
            AutocompleteMenu.SetAutocompleteMenu(Textbox, AutocompleteMenu);
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
            Textbox.Size = new Size(896, 526);
            Textbox.TabIndex = 0;
            Textbox.Zoom = 100;
            Textbox.TextChanged += Textbox_TextChanged;
            // 
            // FileTree
            // 
            FileTree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FileTree.BackColor = Color.FromArgb(40, 40, 40);
            FileTree.BorderStyle = BorderStyle.FixedSingle;
            FileTree.ForeColor = Color.White;
            FileTree.Indent = 19;
            FileTree.ItemHeight = 19;
            FileTree.Location = new Point(3, 3);
            FileTree.Name = "FileTree";
            FileTree.Size = new Size(160, 526);
            FileTree.TabIndex = 0;
            FileTree.NodeMouseDoubleClick += FileTree_NodeMouseDoubleClick;
            // 
            // StatusPanel
            // 
            StatusPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StatusPanel.BackColor = Color.DimGray;
            StatusPanel.Controls.Add(UnscVersionText);
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
            // MainContainer
            // 
            MainContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainContainer.Location = new Point(12, 72);
            MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            MainContainer.Panel1.BackColor = Color.FromArgb(68, 68, 68);
            MainContainer.Panel1.Controls.Add(FileTree);
            // 
            // MainContainer.Panel2
            // 
            MainContainer.Panel2.BackColor = Color.FromArgb(68, 68, 68);
            MainContainer.Panel2.Controls.Add(Textbox);
            MainContainer.Size = new Size(1072, 532);
            MainContainer.SplitterDistance = 166;
            MainContainer.TabIndex = 0;
            // 
            // AutocompleteMenu
            // 
            AutocompleteMenu.AllowsTabKey = true;
            AutocompleteMenu.AppearInterval = 1;
            AutocompleteMenu.Colors = (AutocompleteMenuNS.Colors)resources.GetObject("AutocompleteMenu.Colors");
            AutocompleteMenu.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AutocompleteMenu.ImageList = null;
            AutocompleteMenu.Items = (new string[] { "make" });
            AutocompleteMenu.MinFragmentLength = 1;
            AutocompleteMenu.TargetControlWrapper = null;
            // 
            // clearTextboxStyleToolStripMenuItem
            // 
            clearTextboxStyleToolStripMenuItem.Name = "clearTextboxStyleToolStripMenuItem";
            clearTextboxStyleToolStripMenuItem.Size = new Size(192, 22);
            clearTextboxStyleToolStripMenuItem.Text = "Clear textbox style";
            clearTextboxStyleToolStripMenuItem.Click += clearTextboxStyleToolStripMenuItem_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            ClientSize = new Size(1096, 641);
            Controls.Add(MainContainer);
            Controls.Add(StatusPanel);
            Controls.Add(panel1);
            Controls.Add(TopPanel);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Textbox).EndInit();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            MainContainer.Panel1.ResumeLayout(false);
            MainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
            MainContainer.ResumeLayout(false);
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
        private FastColoredTextBoxNS.FastColoredTextBox Textbox;
        private ToolStripMenuItem testingToolStripMenuItem;
        private ToolStripMenuItem writeHighlightingTestToolStripMenuItem;
        private Label FilePathText;
        private ToolStripMenuItem directoryToolStripMenuItem;
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
        private ToolStripMenuItem versionToolStripMenuItem;
        private ToolStripMenuItem rToolStripMenuItem;
        private Label UnscVersionText;
        private ToolStripMenuItem rToolStripMenuItem1;
        private PictureBox pictureBox1;
        private Label label2;
        private ToolStripMenuItem packageVerifierToolStripMenuItem;
        private ToolStripMenuItem unloadDirectoryToolStripMenuItem;
        private ToolStripMenuItem packageInformationParserToolStripMenuItem;
        private ToolStripMenuItem packagerDepackagerToolStripMenuItem;
        private ToolStripMenuItem temporaryInstallEnvironmentToolStripMenuItem;
        private ToolStripMenuItem downloaderToolStripMenuItem;
        public TreeView FileTree;
        private ToolStripMenuItem importFileToDirectoryToolStripMenuItem;
        private SplitContainer MainContainer;
        private AutocompleteMenuNS.AutocompleteMenu AutocompleteMenu;
        private ToolStripMenuItem clearTextboxStyleToolStripMenuItem;

        /*
            Jebac Mickiewicza
        */
    }
}