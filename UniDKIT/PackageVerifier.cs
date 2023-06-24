using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniDKIT
{
    public partial class PackageVerifier : Form
    {
        static string[] files;
        static string dirpath;
        public PackageVerifier()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    PathTextbox.Text = fbd.SelectedPath;
                }
            }
        }

        private void PackageVerifier_Load(object sender, EventArgs e)
        {
            if (Main.DirPath != "")
            {
                PathTextbox.Text = Main.DirPath;
            }

            DetailTextPkgInfo.Text = "";
            DetailTextInst.Text = "";
            DetailTextUninst.Text = "";
        }
        private void CheckPackageButton_Click(object sender, EventArgs e)
        {
            if (PathTextbox.Text == "")
            {
                MessageBox.Show("No directory loaded");
                return;
            }

            if (!Directory.Exists(PathTextbox.Text))
            {
                MessageBox.Show("Directory does not exist");
                PathTextbox.Text = "";
                return;
            }

            string[] PkgInfoFiles = Directory.GetFiles(PathTextbox.Text, "*.pkginfo");
            string[] InstFiles = Directory.GetFiles(PathTextbox.Text, "*.inst");
            string[] UninstFiles = Directory.GetFiles(PathTextbox.Text, "*.uninst");

            CheckPkgInfo();
            CheckInst();
            CheckUninst();

            void CheckPkgInfo()
            {
                if (PkgInfoFiles.Length > 0)
                {
                    if (File.ReadAllText(PkgInfoFiles[0]).Length < 6)
                    {
                        PkginfoOkText.ForeColor = Color.Yellow;
                        DetailTextPkgInfo.ForeColor = Color.Yellow;

                        PkginfoOkText.Text = "Warning";
                        DetailTextPkgInfo.Text = ".pkginfo file lenght is below 6 characters.\nPackage data may not be defined";

                    }
                    else
                    {
                        PkginfoOkText.ForeColor = Color.Green;
                        DetailTextPkgInfo.ForeColor = Color.Green;

                        PkginfoOkText.Text = "Ready";
                        DetailTextPkgInfo.Text = ".pkginfo file check successful.";
                    }
                }
                else
                {
                    PkginfoOkText.ForeColor = Color.Red;
                    DetailTextPkgInfo.ForeColor = Color.Red;

                    PkginfoOkText.Text = "Missing";
                    DetailTextPkgInfo.Text = "No .pkginfo file found, package will not install";
                }
            }
            void CheckInst()
            {
                if (InstFiles.Length > 0)
                {
                    if (File.ReadAllText(InstFiles[0]).Length < 18)
                    {
                        InstOkText.ForeColor = Color.Yellow;
                        DetailTextInst.ForeColor = Color.Yellow;

                        InstOkText.Text = "Warning";
                        DetailTextInst.Text = ".inst file lenght below 18 characters.\nInstall data may not be defined correctly";
                    }
                    else
                    {
                        InstOkText.ForeColor = Color.Green;
                        DetailTextInst.ForeColor = Color.Green;

                        InstOkText.Text = "Ready";
                        DetailTextInst.Text = ".inst file ready for installation";
                    }
                }
                else
                {
                    InstOkText.ForeColor = Color.Red;
                    DetailTextInst.ForeColor = Color.Red;

                    InstOkText.Text = "Missing";
                    DetailTextInst.Text = "No .inst file found, package will not install";
                }
            }
            void CheckUninst()
            {
                if (UninstFiles.Length > 0)
                {
                    if (File.ReadAllText(UninstFiles[0]).Length < 1)
                    {
                        UninstOkText.ForeColor = Color.Yellow;
                        DetailTextUninst.ForeColor = Color.Yellow;

                        UninstOkText.Text = "Warning";
                        DetailTextUninst.Text = ".uninst file empty, no uninstall information\ndefined";
                    }
                    else
                    {
                        UninstOkText.ForeColor = Color.Green;
                        DetailTextInst.ForeColor = Color.Green;

                        UninstOkText.Text = "Ready";
                        DetailTextUninst.Text = ".inst file ready for installation";
                    }
                }
                else
                {
                    UninstOkText.ForeColor = Color.Red;
                    DetailTextUninst.ForeColor = Color.Red;

                    UninstOkText.Text = "Missing";
                    DetailTextUninst.Text = "No .uninst file found, package will not install";
                }
            }
            void CheckFilenames()
            {
                string PkgInfoFileName = PkgInfoFiles[0].Replace(".pkginfo", "");
                string InstFileName = InstFiles[0].Replace(".inst", "");
                string UninstFileName = InstFiles[0].Replace(".uninst", "");
            }
        }
    }
}
