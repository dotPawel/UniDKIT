using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniDKIT
{
    public partial class Packager : Form
    {
        static int Mode = 1;
        public Packager()
        {
            InitializeComponent();
        }

        private void Packager_Load(object sender, EventArgs e)
        {
            StartButton.Text = "Package";
        }

        private void OnUncheck(object sender, EventArgs e)
        {
            InputTextbox.Text = string.Empty;
            OutputTextbox.Text = string.Empty;

            if (PackageRButton.Checked)
            {
                DepackageRButton.Checked = false;
                Mode = 1;
                StartButton.Text = "Package";
            }
            if (DepackageRButton.Checked)
            {
                PackageRButton.Checked = false;
                Mode = 2;
                StartButton.Text = "Depackage";
            }
            else
            {
                DepackageRButton.Checked = false;
                PackageRButton.Checked = true;
                Mode = 1;
            }
        }

        private void InputBrowseButton_Click(object sender, EventArgs e)
        {
            if (Mode == 1)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        InputTextbox.Text = fbd.SelectedPath;
                    }
                }
            }
            if (Mode == 2)
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Filter = "UniPKG package files (*.unipkg)|*.unipkg|All files (*.*)|*.*";
                    DialogResult result = ofd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd.FileName))
                    {
                        InputTextbox.Text = ofd.FileName;
                    }
                }
            }
        }

        private void OutputBrowseButton_Click(object sender, EventArgs e)
        {
            if (Mode == 1)
            {
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "UniPKG package files (*.unipkg)|*.unipkg|All files (*.*)|*.*";
                    DialogResult result = sfd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                    {
                        OutputTextbox.Text = sfd.FileName;
                    }
                }
            }
            if (Mode == 2)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        OutputTextbox.Text = fbd.SelectedPath;
                    }
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (InputTextbox.Text == "")
            {
                MessageBox.Show("No input specified");
                return;
            }
            if (OutputTextbox.Text == "")
            {
                MessageBox.Show("No input specified");
                return;
            }


            if (Mode == 1) // package
            {
                if (!Directory.Exists(InputTextbox.Text))
                {
                    MessageBox.Show("Input directory does not exist");
                    return;
                }

                try
                {
                    ZipFile.CreateFromDirectory(InputTextbox.Text, OutputTextbox.Text);
                    MessageBox.Show("Successfully created package\n\n" + OutputTextbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Packaging failed\n\n Exception : " + ex.Message);
                }
            }
            if (Mode == 2) // depackage
            {
                if (!File.Exists(InputTextbox.Text))
                {
                    MessageBox.Show("Input file does not exist");
                    return;
                }

                try
                {
                    ZipFile.ExtractToDirectory(InputTextbox.Text, OutputTextbox.Text);
                    MessageBox.Show("Successfully extracted package\n\n" + OutputTextbox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Package extraction failed\n\n Exception : " + ex);
                }
            }
        }
    }
}
