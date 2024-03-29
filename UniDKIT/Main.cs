using DiscordRPC;
using FastColoredTextBoxNS;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UniDKIT
{
    public partial class Main : Form
    {
        public static string Version = "5.0r";
        private DiscordRpcClient client;

        // whar
        static Style BlueStyle = new TextStyle(Brushes.SteelBlue, null, FontStyle.Regular);
        static Style AzureStyle = new TextStyle(Brushes.Aquamarine, null, FontStyle.Regular);
        static Style YellowStyle = new TextStyle(Brushes.Wheat, null, FontStyle.Regular);
        static Style PurpleStyle = new TextStyle(Brushes.MediumPurple, null, FontStyle.Regular);
        static Style BlueVioletStyle = new TextStyle(Brushes.BlueViolet, null, FontStyle.Regular);
        static Style DarkOliveStyle = new TextStyle(Brushes.DarkOliveGreen, null, FontStyle.Regular);
        static Style TealStyle = new TextStyle(Brushes.Teal, null, FontStyle.Regular);
        static Style ChartStyle = new TextStyle(Brushes.DarkTurquoise, null, FontStyle.Regular);
        static Style GreenStyle = new TextStyle(Brushes.SpringGreen, null, FontStyle.Regular);
        static Style CoralStyle = new TextStyle(Brushes.Coral, null, FontStyle.Regular);

        public static string FilePath;
        public static string DirPath;

        public static string OldFileContents;

        public static string UnscVersion = "10.0r";
        public static int counter2;

        public string[] Autocomplete54 =
        {
            // filesys
            "file", "dir", "sd",

            "make", "del", "rd", "wrt", "cln", "rnm", "lst", "zip", "unzip",

            // uniscript/pkg
            "uniscript", "unipkg",

            "/inst", "/foinfo", "/finfo", "/dpkg", "/uinst", "/list",
            
            // networx
            "net", "ping",

            // process
            "proc", "run", "end",

            // customization and ironpython
            "ironpython", "starttext", "prompttext", "textmodules", "config",

            "create", "write-template", "rewrite", "write", "print",
            "open", "example", "parse",

            // acl backbridge
            "acl_bb", "start",

            // misc.
            "clr", "about", "echo", "sleep", "exit", "ptm-cmd", "pause",

            // other slash commands
            "/p", "/all", "/ptm"
        };
        public string[] Autocomplete60 =
        {
            // filesys
            "file", "dir", "sd",

            "make", "del", "rd", "wrt", "cln", "rnm", "lst", "zip", "unzip",

            // uniscript/pkg
            "uniscript", "unipkg",

            "/inst", "/foinfo", "/finfo", "/dpkg", "/uinst", "/list",
            
            // networx
            "net", "ping", 

            // process
            "proc", "run", "end",

            // customization and ironpython
            "irpy", "stxt", "ptxt", "tmdl", "cfg",

            "wrt-template", "open", "example", "parse",

            // acl backbridge
            "acl_bb", "start",

            // misc.
            "clr", "about", "echo", "sleep", "exit", "ptm-cmd", "help", "pause",

            // other slash commands
            "/p", "/all", "/ptm", "/name", "/frc", "/args"
        };
        public string[] Autocomplete70 =
        {
            // filesys
            "file", "dir", "sd",

            "make", "del", "rd", "wrt", "cln", "rnm", "lst", "zip", "unzip",

            // uniscript/pkg
            "uniscript", "unipkg",

            "/inst", "/foinfo", "/finfo", "/dpkg", "/uinst", "/list",
            
            // networx
            "net", "ping", "dload", "fc",

            // process
            "proc", "run", "end",

            // customization and ironpython
            "irpy", "stxt", "ptxt", "tmdl", "cfg",

            "wrt-template", "open", "example", "parse",

            // acl backbridge
            "acl_bb", "start",

            // misc.
            "clr", "about", "echo", "sleep", "exit", "ptm-cmd", "help", "pause",

            // other slash commands
            "/p", "/all", "/ptm", "/name", "/frc", "/args", "/in"
        };
        public string[] Autocomplete80 =
        {
            // filesys
            "file", "dir", "sd",

            "make", "del", "rd", "wrt", "wrtln", "cln", "rnm", "lst", "zip", "unzip",

            // uniscript/pkg
            "uniscript", "unipkg",

            "/inst", "/foinfo", "/finfo", "/dpkg", "/uinst", "/list",

            // uniscript user input utils (usrin)
            "usrin", "set", "rdf", "repl", "toupp", "tolwr",
            
            // networx
            "net", "ping", "dload", "fc",

            // process
            "proc", "run", "end",

            // customization and ironpython
            "irpy", "stxt", "ptxt", "tmdl", "cfg",

            "wrt-template", "open", "example", "parse",

            // version manager (vm)
            "vm", "pull", "comp",

            // acl backbridge
            "acl_bb", "start",

            // misc.
            "clr", "about", "echo", "sleep", "exit", "ptm-cmd", "help", "pause",

            // other slash commands
            "/p", "/all", "/ptm", "/name", "/frc", "/args", "/in", "/s"
        };
        public string[] Autocomplete90 =
        {
            // filesys
            "file", "dir", "sd",

            "make", "del", "rd", "wrt", "wrtln", "cln", "rnm", "lst", "zip", "unzip",

            // uniscript/pkg
            "uniscript", "unipkg",

            "/inst", "/foinfo", "/finfo", "/dpkg", "/uinst", "/list",

            // uniscript user input utils (usrin)
            "usrin", "set", "rdf", "repl", "toupp", "tolwr",

            // dictionary
            "dict", "add", "rem",
            
            // networx
            "net", "ping", "dload", "fc",

            // process
            "proc", "run", "end",

            // customization and ironpython
            "irpy", "stxt", "ptxt", "tmdl", "cfg",

            "wrt-template", "open", "example", "parse",

            // version manager (vm)
            "vm", "pull", "comp",

            // acl backbridge
            "acl_bb", "start",

            // misc.
            "clr", "about", "echo", "sleep", "exit", "ptm-cmd", "help", "pause",

            // other slash commands
            "/p", "/all", "/ptm", "/name", "/frc", "/args", "/in", "/s"
        };
        public string[] Autocomplete100 =
        {
            // filesys
            "file", "dir", "sd",

            "make", "del", "rd", "wrt", "wrtln", "cln", "rnm", "lst", "zip", "unzip",

            // uniscript/pkg
            "uniscript", "unipkg",

            "/inst", "/foinfo", "/finfo", "/dpkg", "/uinst", "/list", "/upd", "/cupd",

            // uniscript user input utils (usrin)
            "usrin", "set", "rdf", "repl", "toupp", "tolwr",

            // dictionary
            "dict", "add", "rem",
            
            // networx
            "net", "ping", "dload", "fc",

            // process
            "proc", "run", "end",

            // cdll
            "cdll", "load", "inv",

            // customization and ironpython
            "irpy", "stxt", "ptxt", "tmdl", "cfg",

            "wrt-template", "open", "example", "parse",

            // version manager (vm)
            "vm", "pull", "comp",

            // acl backbridge
            "acl_bb", "start",

            // misc.
            "clr", "about", "echo", "sleep", "exit", "ptm-cmd", "help", "pause",

            // other slash commands
            "/p", "/all", "/ptm", "/name", "/frc", "/args", "/in", "/s"
        };

        public static Dictionary<string, Style> CurrentHighlighting = new Dictionary<string, Style>();

        public static Dictionary<string, Style> Highlighting54 = new Dictionary<string, Style>()
        {
            {"file", BlueStyle},
            {"dir", BlueStyle},
            {"sd", BlueStyle},
            {"make", YellowStyle},
            {"del", YellowStyle},
            {"rd", YellowStyle},
            {"wrt", YellowStyle},
            {"cln", YellowStyle},
            {"rnm", YellowStyle},
            {"lst", YellowStyle},
            {"zip", YellowStyle},
            {"unzip", YellowStyle},

            {"unipkg", YellowStyle},
            {"uniscript", YellowStyle},
            {"/foinfo", GreenStyle},
            {"/finfo", GreenStyle},
            {"/dpkg", GreenStyle},
            {"/uinst", GreenStyle},
            {"/inst", GreenStyle},
            {"/list", GreenStyle},

            {"net", TealStyle},
            {"ping", CoralStyle},

            {"proc", AzureStyle},
            {"run", CoralStyle},
            {"end", CoralStyle},

            {"ironpython", AzureStyle},

            {"starttext", BlueVioletStyle},
            {"prompttext", BlueVioletStyle},
            {"textmodules", BlueVioletStyle},
            {"config", DarkOliveStyle},

            {"create", CoralStyle},
            {"write-template", CoralStyle},
            {"rewrite", CoralStyle},
            {"write", CoralStyle},
            {"print", CoralStyle},
            {"open", CoralStyle},
            {"example", CoralStyle},
            {"parse", CoralStyle},

            {"acl_bb", DarkOliveStyle},
            {"start", CoralStyle},

            {"help", ChartStyle},
            {"clr", ChartStyle},
            {"about", ChartStyle},
            {"echo", ChartStyle},
            {"sleep", ChartStyle},
            {"exit", ChartStyle},
            {"ptm-cmd", ChartStyle},
            {"pause", ChartStyle},

            {"/p", GreenStyle},
            {"/all", GreenStyle},
            {"/ptm", GreenStyle},
        };
        public static Dictionary<string, Style> Highlighting60 = new Dictionary<string, Style>()
        {
            {"file", BlueStyle},
            {"dir", BlueStyle},
            {"sd", BlueStyle},
            {"make", YellowStyle},
            {"del", YellowStyle},
            {"rd", YellowStyle},
            {"wrt", YellowStyle},
            {"cln", YellowStyle},
            {"rnm", YellowStyle},
            {"lst", YellowStyle},
            {"zip", YellowStyle},
            {"unzip", YellowStyle},

            {"unipkg", YellowStyle},
            {"uniscript", YellowStyle},
            {"/foinfo", GreenStyle},
            {"/finfo", GreenStyle},
            {"/dpkg", GreenStyle},
            {"/uinst", GreenStyle},
            {"/inst", GreenStyle},
            {"/list", GreenStyle},

            {"net", TealStyle},
            {"ping", CoralStyle},

            {"proc", AzureStyle},
            {"run", CoralStyle},
            {"end", CoralStyle},

            {"irpy", AzureStyle},

            {"stxt", BlueVioletStyle},
            {"ptxt", BlueVioletStyle},
            {"tmdl", BlueVioletStyle},
            {"cfg", DarkOliveStyle},

            {"create", CoralStyle},
            {"wrt-template", CoralStyle},
            {"rewrite", CoralStyle},
            {"write", CoralStyle},
            {"print", CoralStyle},
            {"open", CoralStyle},
            {"example", CoralStyle},
            {"parse", CoralStyle},

            {"acl_bb", DarkOliveStyle},
            {"start", CoralStyle},

            {"help", ChartStyle},
            {"clr", ChartStyle},
            {"about", ChartStyle},
            {"echo", ChartStyle},
            {"sleep", ChartStyle},
            {"exit", ChartStyle},
            {"ptm-cmd", ChartStyle},
            {"pause", ChartStyle},

            {"/p", GreenStyle},
            {"/all", GreenStyle},
            {"/ptm", GreenStyle},
            {"/frc", GreenStyle},
            {"/name", GreenStyle},
            {"/args", GreenStyle},
        };
        public static Dictionary<string, Style> Highlighting70 = new Dictionary<string, Style>()
        {
            {"file", BlueStyle},
            {"dir", BlueStyle},
            {"sd", BlueStyle},
            {"make", YellowStyle},
            {"del", YellowStyle},
            {"rd", YellowStyle},
            {"wrt", YellowStyle},
            {"cln", YellowStyle},
            {"rnm", YellowStyle},
            {"lst", YellowStyle},
            {"zip", YellowStyle},
            {"unzip", YellowStyle},

            {"unipkg", YellowStyle},
            {"uniscript", YellowStyle},
            {"/foinfo", GreenStyle},
            {"/finfo", GreenStyle},
            {"/dpkg", GreenStyle},
            {"/uinst", GreenStyle},
            {"/inst", GreenStyle},
            {"/list", GreenStyle},

            {"net", TealStyle},
            {"ping", CoralStyle},
            {"dload", CoralStyle},
            {"fc", CoralStyle},

            {"proc", AzureStyle},
            {"run", CoralStyle},
            {"end", CoralStyle},

            {"irpy", AzureStyle},

            {"stxt", BlueVioletStyle},
            {"ptxt", BlueVioletStyle},
            {"tmdl", BlueVioletStyle},
            {"cfg", DarkOliveStyle},

            {"create", CoralStyle},
            {"wrt-template", CoralStyle},
            {"rewrite", CoralStyle},
            {"write", CoralStyle},
            {"print", CoralStyle},
            {"open", CoralStyle},
            {"example", CoralStyle},
            {"parse", CoralStyle},

            {"acl_bb", DarkOliveStyle},
            {"start", CoralStyle},

            {"help", ChartStyle},
            {"clr", ChartStyle},
            {"about", ChartStyle},
            {"echo", ChartStyle},
            {"sleep", ChartStyle},
            {"exit", ChartStyle},
            {"ptm-cmd", ChartStyle},
            {"pause", ChartStyle},

            {"/p", GreenStyle},
            {"/all", GreenStyle},
            {"/ptm", GreenStyle},
            {"/frc", GreenStyle},
            {"/name", GreenStyle},
            {"/args", GreenStyle},
            {"/in", GreenStyle},
            {"/s", GreenStyle},
        };
        public static Dictionary<string, Style> Highlighting80 = new Dictionary<string, Style>()
        {
            {"file", BlueStyle},
            {"dir", BlueStyle},
            {"sd", BlueStyle},
            {"make", YellowStyle},
            {"del", YellowStyle},
            {"rd", YellowStyle},
            {"wrt", YellowStyle},
            {"wrtln", YellowStyle},
            {"cln", YellowStyle},
            {"rnm", YellowStyle},
            {"lst", YellowStyle},
            {"zip", YellowStyle},
            {"unzip", YellowStyle},

            {"unipkg", YellowStyle},
            {"uniscript", YellowStyle},
            {"/foinfo", GreenStyle},
            {"/finfo", GreenStyle},
            {"/dpkg", GreenStyle},
            {"/uinst", GreenStyle},
            {"/inst", GreenStyle},
            {"/list", GreenStyle},

            {"vm", PurpleStyle},
            {"pull", CoralStyle},
            {"comp", CoralStyle},

            {"usrin", PurpleStyle},
            {"set", CoralStyle},
            {"rdf", CoralStyle},
            {"repl", CoralStyle},
            {"toupp", CoralStyle},
            {"tolwr", CoralStyle},

            {"net", TealStyle},
            {"ping", CoralStyle},
            {"dload", CoralStyle},
            {"fc", CoralStyle},

            {"proc", AzureStyle},
            {"run", CoralStyle},
            {"end", CoralStyle},

            {"irpy", AzureStyle},

            {"stxt", BlueVioletStyle},
            {"ptxt", BlueVioletStyle},
            {"tmdl", BlueVioletStyle},
            {"cfg", DarkOliveStyle},

            {"create", CoralStyle},
            {"wrt-template", CoralStyle},
            {"rewrite", CoralStyle},
            {"write", CoralStyle},
            {"print", CoralStyle},
            {"open", CoralStyle},
            {"example", CoralStyle},
            {"parse", CoralStyle},

            {"acl_bb", DarkOliveStyle},
            {"start", CoralStyle},

            {"help", ChartStyle},
            {"clr", ChartStyle},
            {"about", ChartStyle},
            {"echo", ChartStyle},
            {"sleep", ChartStyle},
            {"exit", ChartStyle},
            {"ptm-cmd", ChartStyle},
            {"pause", ChartStyle},

            {"/p", GreenStyle},
            {"/all", GreenStyle},
            {"/ptm", GreenStyle},
            {"/frc", GreenStyle},
            {"/name", GreenStyle},
            {"/args", GreenStyle},
            {"/in", GreenStyle},
            {"/s", GreenStyle},
        };
        public static Dictionary<string, Style> Highlighting90 = new Dictionary<string, Style>()
        {
            {"file", BlueStyle},
            {"dir", BlueStyle},
            {"sd", BlueStyle},
            {"make", YellowStyle},
            {"del", YellowStyle},
            {"rd", YellowStyle},
            {"wrt", YellowStyle},
            {"wrtln", YellowStyle},
            {"cln", YellowStyle},
            {"rnm", YellowStyle},
            {"lst", YellowStyle},
            {"zip", YellowStyle},
            {"unzip", YellowStyle},

            {"unipkg", YellowStyle},
            {"uniscript", YellowStyle},
            {"/foinfo", GreenStyle},
            {"/finfo", GreenStyle},
            {"/dpkg", GreenStyle},
            {"/uinst", GreenStyle},
            {"/inst", GreenStyle},
            {"/list", GreenStyle},

            {"vm", PurpleStyle},
            {"pull", CoralStyle},
            {"comp", CoralStyle},

            {"usrin", PurpleStyle},
            {"set", CoralStyle},
            {"rdf", CoralStyle},
            {"repl", CoralStyle},
            {"toupp", CoralStyle},
            {"tolwr", CoralStyle},

            {"dict", PurpleStyle},
            {"add", CoralStyle},
            {"rem", CoralStyle},

            {"net", TealStyle},
            {"ping", CoralStyle},
            {"dload", CoralStyle},
            {"fc", CoralStyle},

            {"proc", AzureStyle},
            {"run", CoralStyle},
            {"end", CoralStyle},

            {"irpy", AzureStyle},

            {"stxt", BlueVioletStyle},
            {"ptxt", BlueVioletStyle},
            {"tmdl", BlueVioletStyle},
            {"cfg", DarkOliveStyle},

            {"create", CoralStyle},
            {"wrt-template", CoralStyle},
            {"rewrite", CoralStyle},
            {"write", CoralStyle},
            {"print", CoralStyle},
            {"open", CoralStyle},
            {"example", CoralStyle},
            {"parse", CoralStyle},

            {"acl_bb", DarkOliveStyle},
            {"start", CoralStyle},

            {"help", ChartStyle},
            {"clr", ChartStyle},
            {"about", ChartStyle},
            {"echo", ChartStyle},
            {"sleep", ChartStyle},
            {"exit", ChartStyle},
            {"ptm-cmd", ChartStyle},
            {"pause", ChartStyle},

            {"/p", GreenStyle},
            {"/all", GreenStyle},
            {"/ptm", GreenStyle},
            {"/frc", GreenStyle},
            {"/name", GreenStyle},
            {"/args", GreenStyle},
            {"/in", GreenStyle},
            {"/s", GreenStyle},
        };
        public static Dictionary<string, Style> Highlighting100 = new Dictionary<string, Style>()
        {
            {"file", BlueStyle},
            {"dir", BlueStyle},
            {"sd", BlueStyle},
            {"make", YellowStyle},
            {"del", YellowStyle},
            {"rd", YellowStyle},
            {"wrt", YellowStyle},
            {"wrtln", YellowStyle},
            {"cln", YellowStyle},
            {"rnm", YellowStyle},
            {"lst", YellowStyle},
            {"zip", YellowStyle},
            {"unzip", YellowStyle},

            {"unipkg", YellowStyle},
            {"uniscript", YellowStyle},
            {"/foinfo", GreenStyle},
            {"/finfo", GreenStyle},
            {"/dpkg", GreenStyle},
            {"/uinst", GreenStyle},
            {"/inst", GreenStyle},
            {"/list", GreenStyle},
            {"/upd", GreenStyle},
            {"/cupd", GreenStyle},

            {"vm", PurpleStyle},
            {"pull", CoralStyle},
            {"comp", CoralStyle},

            {"usrin", PurpleStyle},
            {"set", CoralStyle},
            {"rdf", CoralStyle},
            {"repl", CoralStyle},
            {"toupp", CoralStyle},
            {"tolwr", CoralStyle},

            {"dict", PurpleStyle},
            {"add", CoralStyle},
            {"rem", CoralStyle},

            {"cdll", PurpleStyle},
            {"load", CoralStyle},
            {"inv", CoralStyle},

            {"net", TealStyle},
            {"ping", CoralStyle},
            {"dload", CoralStyle},
            {"fc", CoralStyle},

            {"proc", AzureStyle},
            {"run", CoralStyle},
            {"end", CoralStyle},

            {"irpy", AzureStyle},

            {"stxt", BlueVioletStyle},
            {"ptxt", BlueVioletStyle},
            {"tmdl", BlueVioletStyle},
            {"cfg", DarkOliveStyle},

            {"create", CoralStyle},
            {"wrt-template", CoralStyle},
            {"rewrite", CoralStyle},
            {"write", CoralStyle},
            {"print", CoralStyle},
            {"open", CoralStyle},
            {"example", CoralStyle},
            {"parse", CoralStyle},

            {"acl_bb", DarkOliveStyle},
            {"start", CoralStyle},

            {"help", ChartStyle},
            {"clr", ChartStyle},
            {"about", ChartStyle},
            {"echo", ChartStyle},
            {"sleep", ChartStyle},
            {"exit", ChartStyle},
            {"ptm-cmd", ChartStyle},
            {"pause", ChartStyle},

            {"/p", GreenStyle},
            {"/all", GreenStyle},
            {"/ptm", GreenStyle},
            {"/frc", GreenStyle},
            {"/name", GreenStyle},
            {"/args", GreenStyle},
            {"/in", GreenStyle},
            {"/s", GreenStyle},
        };

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            AutocompleteMenu.Items = Autocomplete100;
            UnscVersionText.Text = UnscVersion;
            CurrentHighlighting = Highlighting100;

            this.Text = "UniDKIT // " + Version;

            VersionText.Text = "Version // " + Version;
            StatusText.Text = "Ready";

            if (Version.EndsWith("d"))
            {
                testingToolStripMenuItem.Visible = true;
            }
            else
            {
                testingToolStripMenuItem.Visible = false;
            }

            client = new DiscordRpcClient("1118613368866099200");
            client.Initialize();
            SetDiscordRPC();
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FilePath != null && OldFileContents != Textbox.Text)
            {
                StatusText.Text = "File changes detected";
                DialogResult dialogResult = MessageBox.Show("Save changes to file?", "File changes detected", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    File.WriteAllText(FilePath, Textbox.Text);
                    StatusText.Text = "Saved changes";
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            client.Dispose();
        }
        public void SetDiscordRPC()
        {
            string details = "";
            string state = "";
            if (FilePath == null)
            {
                details = "Idling..";
                state = "No file loaded";
            }
            else
            {
                details = "Editing a " + Path.GetExtension(FilePath) + " file";
                state = "File name : " + Path.GetFileName(FilePath);
            }
            client.ClearPresence();
            client.SetPresence(new RichPresence()
            {
                Details = details,
                State = state,

                Assets = new Assets()
                {
                    LargeImageKey = "unidkit",
                    LargeImageText = "UniDKIT // " + Version,
                    SmallImageKey = "uniscript",
                    SmallImageText = "UniScript " + UnscVersion,
                }
            });
        }
        public void LoadFile(string FileP)
        {
            try
            {
                FilePath = FileP;

                Textbox.Text = File.ReadAllText(FileP);
                OldFileContents = File.ReadAllText(FileP);

                StatusText.Text = "Wrote file into Textbox";

                FilePathText.Text = FilePath;

                StatusText.Text = "Loaded file";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading file failed\n\n Exception : " + ex.Message);
            }
        }
        public void LoadFileTree()
        {
            try
            {
                FileTree.Nodes.Clear();
                StatusText.Text = "Cleared file tree";

                var stack = new Stack<TreeNode>();
                var rootDirectory = new DirectoryInfo(DirPath);
                var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
                stack.Push(node);
                StatusText.Text = "Pushed TreeNode stack";

                while (stack.Count > 0)
                {
                    var currentNode = stack.Pop();
                    var directoryInfo = (DirectoryInfo)currentNode.Tag;
                    foreach (var directory in directoryInfo.GetDirectories())
                    {
                        var childDirectoryNode = new TreeNode(directory.Name + @"\") { Tag = directory };
                        currentNode.Nodes.Add(childDirectoryNode);
                        stack.Push(childDirectoryNode);
                    }
                    foreach (var file in directoryInfo.GetFiles())
                        currentNode.Nodes.Add(new TreeNode(file.Name));
                }

                FileTree.Nodes.Add(node);
                StatusText.Text = "Added nodes to FileTree";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading FileTree failed\n\n Exception : " + ex.Message);
                StatusText.Text = "Loading FileTree failed";
            }
        }

        // file
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Stream myStream;
                SaveFileDialog NewDialog = new SaveFileDialog();

                NewDialog.Filter = "All files (*.*)|*.*|UniScript files (*.unsc)|*.unsc";
                NewDialog.FilterIndex = 2;
                NewDialog.RestoreDirectory = true;

                if (NewDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = NewDialog.OpenFile()) != null)
                    {
                        myStream.Close();
                        File.Create(NewDialog.FileName).Close();

                        if (Textbox.Text.Length > 1 && FilePath == null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Save current editor contents to created file?", "Editor contents detected", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                File.WriteAllText(NewDialog.FileName, Textbox.Text);
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                return;
                            }
                        }
                        FilePath = NewDialog.FileName;
                        FilePathText.Text = FilePath;
                        LoadFile(FilePath);
                    }
                    if (DirPath != null)
                    {
                        LoadFileTree();
                    }
                    SetDiscordRPC();
                }
                else
                {
                    StatusText.Text = "Creating file aborted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opening file failed! \n\n Exception : " + ex.Message);
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StatusText.Text = "Opening file dialog";
                using (OpenFileDialog OpenDialog = new OpenFileDialog())
                {
                    OpenDialog.Filter = "All files (*.*)|*.*|UniScript files (*.unsc)|*.unsc";
                    OpenDialog.FilterIndex = 2;
                    OpenDialog.RestoreDirectory = true;

                    if (OpenDialog.ShowDialog() == DialogResult.OK)
                    {
                        LoadFile(OpenDialog.FileName);
                        SetDiscordRPC();
                    }
                    else
                    {
                        StatusText.Text = "Opening file aborted";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opening file failed\n\n Exception : " + ex.Message);
                StatusText.Text = "Opening file failed";
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                MessageBox.Show("No file loaded.");
                return;
            }

            try
            {
                File.WriteAllText(FilePath, Textbox.Text);
                OldFileContents = Textbox.Text;
                StatusText.Text = "Saved file";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving file failed\n\n Exception : " + ex.Message);
                StatusText.Text = "Saving file failed";
            }

        }
        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FilePath == null)
            {
                MessageBox.Show("No file loaded");
            }
            else
            {
                Textbox.Text = "";
                FilePath = null;
                FilePathText.Text = "Closed file";
                SetDiscordRPC();
            }
        }

        // directory
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var OpenDialog = new FolderBrowserDialog();
            if (OpenDialog.ShowDialog() == DialogResult.OK)
            {
                DirPath = OpenDialog.SelectedPath;

                LoadFileTree();
            }
            else
            {
                StatusText.Text = "Opening directory aborted";
            }
        }
        private void openInExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DirPath == null)
            {
                MessageBox.Show("No directory loaded");
                return;
            }

            try
            {
                Process.Start("explorer.exe", DirPath);
                StatusText.Text = "Started explorer";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Opening explorer failed\n\n Exception : " + ex.Message);
                StatusText.Text = "Opening explorer failed";
            }
        }
        private void reloadFileTreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DirPath != null)
            {
                LoadFileTree();
            }
            else
            {
                MessageBox.Show("No directory loaded");
            }
        }
        private void unloadDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirPath = null;
            FileTree.Nodes.Clear();
        }
        private void importFileToDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DirPath == null)
            {
                MessageBox.Show("No directory loaded");
                return;
            }

            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(ofd.FileName, DirPath + "\\" + Path.GetFileName(ofd.FileName));
                    StatusText.Text = "Imported file to current directory";
                    LoadFileTree();
                }
                else
                {
                    StatusText.Text = "Importing file aborted";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed importing file\n\n Exception : " + ex.Message);
                return;
            }
        }

        private void FileTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null || e.Node.Text.EndsWith(@"\"))
            {
                return;
            }
            try
            {
                if (OldFileContents != Textbox.Text && FilePath != null)
                {
                    StatusText.Text = "File changes detected";
                    DialogResult dialogResult = MessageBox.Show("Save changes to file?", "File changes detected", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        File.WriteAllText(FilePath, Textbox.Text);
                        StatusText.Text = "Saved changes";
                    }
                    else
                    {

                    }
                }
                LoadFile(Path.GetDirectoryName(DirPath) + @"\" + e.Node.FullPath);
                StatusText.Text = "Loaded file from tree (" + e.Node.Text + ")";
                SetDiscordRPC();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loading file failed\n\n Exception : " + ex.Message);
                LoadFileTree();
            }
        }

        // uniscript
        private void versionToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            UnscVersion = e.ClickedItem.Text;
            switch (e.ClickedItem.Text)
            {
                case "5.4r":
                    CurrentHighlighting = Highlighting54;
                    AutocompleteMenu.Items = Autocomplete54;
                    break;
                case "6.0r":
                    CurrentHighlighting = Highlighting60;
                    AutocompleteMenu.Items = Autocomplete60;
                    break;
                case "7.0r":
                    CurrentHighlighting = Highlighting70;
                    AutocompleteMenu.Items = Autocomplete70;
                    break;
                case "8.0r":
                    CurrentHighlighting = Highlighting80;
                    AutocompleteMenu.Items = Autocomplete80;
                    break;
                case "9.0r":
                    CurrentHighlighting = Highlighting90;
                    AutocompleteMenu.Items = Autocomplete90;
                    break;
                case "10.0r":
                    CurrentHighlighting = Highlighting100;
                    AutocompleteMenu.Items = Autocomplete100;
                    break;
            }
            UnscVersionText.Text = e.ClickedItem.Text;
            Textbox.OnTextChanged();
        }

        // unipkg
        private void packageVerifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PackageVerifier = new PackageVerifier();
            PackageVerifier.Show();
        }
        private void packageInformationParserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var PkginfoParser = new PkginfoParser();
            PkginfoParser.Show();
        }
        private void packagerDepackagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Packager = new Packager();
            Packager.Show();
        }
        private void temporaryInstallEnvironmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tienv = new TempInstallEnv();
            tienv.Show();
        }
        private void downloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var downloader = new Downloader();
            downloader.Show();
        }

        // unidkit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.Show();
        }

        // super secret special debug stuff
        private void clearTextboxStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textbox.ClearStylesBuffer();
            StatusText.Text = "[Debug] Cleared style buffer";
        }
        private void writeHighlightingTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Textbox.Text = "-- Syntax testing --\r\n\r\n= FileSystem =\r\nfile\r\ndir\r\nsd\r\n= Misc. =\r\nproc\r\nironpython\r\nconfig\r\nacl_bb\r\n[ptm-cmd]\r\nnet\r\n= UniPKG/Script =\r\nuniscript\r\nunipkg\r\n= Customization =\r\nstarttext\r\nprompttext\r\ntextmodules\r\n= Controls =\r\nclr\r\nabout\r\necho\r\nsleep\r\nexit\r\n= Extensions =\r\nmake del rd wrt cln rnm zip unzip\r\nrun end ping\r\nopen write parse write-template create\r\n= Slash extensions =\r\n/inst /foinfo /dpkg /finfo /uinst /list /all\r\n";
            StatusText.Text = "[Debug] Wrote highlighting text to textbox";
        }
        private void disposeClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            client.Dispose();
            StatusText.Text = "[Debug] Disposed discord client";
        }
        private void setClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetDiscordRPC();
            StatusText.Text = "[Debug] Set DiscordRPC";
        }

        // misc
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter2 += 1;
        }
        private void Textbox_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            // no idea if this is a better solution than what was here before
            e.ChangedRange.ClearStyle(BlueStyle, AzureStyle, YellowStyle, PurpleStyle, BlueVioletStyle, DarkOliveStyle, TealStyle, ChartStyle, GreenStyle, CoralStyle);
            foreach (var entry in CurrentHighlighting)
            {
                e.ChangedRange.SetStyle(entry.Value, entry.Key, RegexOptions.IgnoreCase);
            }
        }
    }
}