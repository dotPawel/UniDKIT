using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniDKIT
{
    public partial class PkginfoParser : Form
    {
        public PkginfoParser()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                {
                    PathTextbox.Text = ofd.FileName;
                }
            }
        }

        private void PkginfoParser_Load(object sender, EventArgs e)
        {
            if (Main.DirPath != null)
            {
                string[] PkgInfoFiles = Directory.GetFiles(Main.DirPath, "*.pkginfo");

                if (PkgInfoFiles.Length > 0)
                {
                    PathTextbox.Text = PkgInfoFiles[0];
                }
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (PathTextbox.Text == "")
            {
                MessageBox.Show("No .pkginfo file loaded");
                return;
            }

            if (!File.Exists(PathTextbox.Text))
            {
                MessageBox.Show("File does not exist");
                PathTextbox.Text = "";
                return;
            }

            string[] PkginfoData = File.ReadAllLines(PathTextbox.Text);
            OutputTextbox.Text = "";
            OutputTextbox.Text += "Defined package information :";
            foreach (string line in PkginfoData)
            {
                switch (line)
                {
                    case string s when s.Contains("Name="):
                        OutputTextbox.Text += "\r\n  Name : " + line.Replace("Name=", "");
                        break;
                    case string s when s.Contains("PackageVersion="):
                        OutputTextbox.Text += "\r\n  Version : " + line.Replace("PackageVersion=", "");
                        break;
                    case string s when s.Contains("Author="):
                        OutputTextbox.Text += "\r\n  Author : " + line.Replace("Author=", "");
                        break;
                    case string s when s.Contains("UniCMDVer="):
                        OutputTextbox.Text += "\r\n  For version : " + line.Replace("UniCMDVer=", "");
                        break;
                    case string s when s.Contains("Description="):
                        OutputTextbox.Text += "\r\n  Description : " + line.Replace("Description=", "").Replace(@"\n", "\n");
                        break;
                }
            }

        }
    }
}
