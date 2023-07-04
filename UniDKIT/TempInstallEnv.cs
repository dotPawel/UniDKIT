using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UniDKIT
{
    public partial class TempInstallEnv : Form
    {
        public TempInstallEnv()
        {
            InitializeComponent();
        }

        private void TempInstallEnv_Load(object sender, EventArgs e)
        {

        }

        public void Print(string msg)
        {
            MainTextbox.Text += msg + Environment.NewLine;
            MainTextbox.DeselectAll();
            
            if (LogCheckbox.Checked)
            {
                try
                {
                    if (!Directory.Exists("TempENV"))
                    {
                        Directory.CreateDirectory("TempENV");
                    }
                    if (!File.Exists("TempENV\\TempENV.log"))
                    {
                        File.Create("TempENV\\TempENV.log").Close();
                    }
                    File.AppendAllText(@"TempENV\TempENV.log", msg + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Disabling logging due to error\n\n Exception : " + ex.Message);
                    LogCheckbox.Checked = false;
                }
            }
        }
        public async void PrepareEnv()
        {
            try
            {
                if (Directory.Exists("TempENV"))
                {
                    DialogResult dialogResult = MessageBox.Show("Already existing TempENV detected, delete?", "TempENV", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Directory.Delete("TempENV", true);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete TempENV\n\n Exception : " + ex.Message);
            }

            try
            {
                Print("Preparing environment..");

                if (!Directory.Exists(@"TempENV"))
                {
                    Directory.CreateDirectory("TempENV");
                    Print("[CR] TempENV");
                }
                if (!Directory.Exists("TempENV\\UniCMD.data"))
                {
                    Directory.CreateDirectory("TempENV\\UniCMD.data");
                    Print("[CR] TempENV\\UniCMD.data");
                }
                if (!Directory.Exists("TempENV\\UniCMD.data\\Marcos"))
                {
                    Directory.CreateDirectory("TempENV\\UniCMD.data\\Macros");
                    Print("[CR] TempENV\\UniCMD.data\\Macros");
                }
                if (!Directory.Exists("TempENV\\UniCMD.data\\Marcos\\UniPKG"))
                {
                    Directory.CreateDirectory("TempENV\\UniCMD.data\\Macros\\UniPKG");
                    Print("[CR] TempENV\\UniCMD.data\\Macros\\UniPKG");
                }
                if (!Directory.Exists("TempENV\\UniCMD.data\\Marcos\\UniPKG\\pkginfo"))
                {
                    Directory.CreateDirectory("TempENV\\UniCMD.data\\UniPKG\\pkginfo");
                    Print("[CR] TempENV\\UniCMD.data\\Macros\\UniPKG\\pkginfo");
                }
                Print("Environment ready!");
            }
            catch (Exception ex)
            {
                Print("!!! Environment preperation failed !!! Exception : " + ex.Message);
            }
            Print("");
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "UniPKG package files (*.unipkg)|*.unipkg|All files (*.*)|*.*";
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    PathTextbox.Text = ofd.FileName;
                }
            }
        }

        private void TempInstallEnv_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DisposeEnvCheckbox.Checked || !Directory.Exists("TempENV"))
            {
                return;
            }

            try
            {
                Directory.Delete("TempENV", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not dispose of TempENV, exception : " + ex.Message);
            }
        }

        private void DisposeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists("TempENV"))
                {
                    Directory.Delete("TempENV", true);
                    MainTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("No TempENV found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot delete TempENV\n\n Exception : " + ex.Message);
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (PathTextbox.Text == "" || !File.Exists(PathTextbox.Text))
            {
                MessageBox.Show("Selected package file does not exist.");
                return;
            }
            MainTextbox.Text = "";

            PrepareEnv();
            string pkgname = PathTextbox.Text;

            try
            {
                try
                {
                    Directory.Delete(@"TempENV\UniCMD.data\UniPKG\TEMP", true);
                }
                catch { }
                Print("Making TEMP directory..");
                Directory.CreateDirectory(@"TempENV\UniCMD.data\UniPKG\TEMP");

                Print("Extracting package to TEMP..");
                System.IO.Compression.ZipFile.ExtractToDirectory(pkgname, @"TempENV\UniCMD.data\UniPKG\TEMP");

                Print("Fetching .pkginfo");
                string PackageName = Path.GetFileNameWithoutExtension(pkgname);

                // Check package info
                try
                {
                    if (!File.Exists(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".pkginfo"))
                    {
                        Print("File does not have .pkginfo file, halting");
                        DeleteTemp();
                        return;
                    }
                    if (!File.Exists(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".inst"))
                    {
                        Print("File does not have .inst file, halting");
                        DeleteTemp();
                        return;
                    }
                    if (!File.Exists(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".uninst"))
                    {
                        Print("File does not have .uninst file, halting");
                        DeleteTemp();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    Print("Installing files failed, exception : " + ex);
                    DeleteTemp();
                    return;
                }

                Print("All package files OK");
                Print("");

                // Read package info
                try
                {
                    string[] PkgInfoLines;
                    PkgInfoLines = File.ReadAllLines(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".pkginfo");
                    Print("\nDefined package information :");
                    foreach (string line in PkgInfoLines)
                    {
                        switch (line)
                        {
                            case string s when s.Contains("Name="):
                                Print(" Name : " + line.Replace("Name=", ""));
                                break;
                            case string s when s.Contains("PackageVersion="):
                                Print(" Version : " + line.Replace("PackageVersion=", ""));
                                break;
                            case string s when s.Contains("Author="):
                                Print(" Author : " + line.Replace("Author=", ""));
                                break;
                            case string s when s.Contains("UniCMDVer="):
                                Print(" For version : " + line.Replace("UniCMDVer=", ""));
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Print("Installing files failed, exception : " + ex);
                    return;
                }
                Print("");

                // Install files
                try
                {
                    Print("Installing files from .inst");
                    File.Move(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".uninst", @"TempENV\UniCMD.data\UniPKG\pkginfo\" + PackageName + ".uninst");
                    Print(" [INFO] .uninst file installed");

                    File.Move(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".pkginfo", @"TempENV\UniCMD.data\UniPKG\pkginfo\" + PackageName + ".pkginfo");
                    Print(" [INFO] .pkginfo file installed");

                    string[] InstLines = File.ReadAllLines(@"TempENV\UniCMD.data\UniPKG\TEMP\" + PackageName + ".inst");
                    foreach (string line in InstLines)
                    {
                        if (line.Contains(" [->] "))
                        {
                            string[] path = line.Split(" [->] ");
                            if (path[0].StartsWith("UniCMD.data"))
                            {
                                path[0] = @"TempENV\" + path[0];
                            }
                            if (path[1].StartsWith("UniCMD.data"))
                            {
                                path[1] = @"TempENV\" + path[1];
                            }
                            File.Move(path[0], path[1]);
                            Print(" " + path[0] + " [->] " + path[1]);
                        }
                        if (line.Contains(" [=>] "))
                        {
                            string[] path = line.Split(" [=>] ");
                            if (path[0].StartsWith("UniCMD.data"))
                            {
                                path[0] = @"TempENV\" + path[0];
                            }
                            if (path[1].StartsWith("UniCMD.data"))
                            {
                                path[1] = @"TempENV\" + path[1];
                            }
                            Directory.Move(path[0], path[1]);
                            Print(" " + @"TempENV\" + path[0] + " [=>] " + @"TempENV\" + path[1]);
                        }
                        if (line.EndsWith(" [CR]"))
                        {
                            string path = line.Replace(" [CR]", "");
                            if (path.StartsWith("UniCMD.data"))
                            {
                                path = @"TempENV\" + path;
                            }
                            Directory.CreateDirectory(path);
                            Print(" [->] " + path);
                        }
                    }
                    Print("Installing from .inst finished");
                }
                catch (Exception ex)
                {
                    Print("Installing files failed, exception : " + ex);
                    return;
                }

                // Delete temp
                DeleteTemp();

                Print("Finished installing");

                void DeleteTemp()
                {
                    Print("Deleting TEMP..");

                    try
                    {
                        Directory.Delete(@"TempENV\UniCMD.data\UniPKG\TEMP", true);
                    }
                    catch (Exception ex)
                    {
                        Print("Deleting TEMP failed, exception : " + ex);
                    }
                    return;
                }
            }
            catch (Exception ex)
            {
                Print("\nInstalling package failed, exception : " + ex);
                Print("Deleting TEMP..");

                Directory.Delete(@"TempENV\UniCMD.data\UniPKG\TEMP", true);
            }
        }
        private void OpenExplorerButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("TempENV"))
            {
                MessageBox.Show("No TempENV found");
                return;
            }
            Process.Start("explorer.exe", "TempENV");
        }
    }
}
