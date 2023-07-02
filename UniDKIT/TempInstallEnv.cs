using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            MainTextbox.Text = Environment.NewLine;
            PrepareEnv();
        }

        public void Print(string msg)
        {
            MainTextbox.Text += msg + Environment.NewLine;
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
                    Directory.CreateDirectory("TempENV\\UniCMD.data\\Macros\\UniPKG\\pkginfo");
                    Print("[CR] TempENV\\UniCMD.data\\Macros\\UniPKG\\pkginfo");
                }
                Print("Environment ready!");
            }
            catch (Exception ex)
            {
                Print("!!! Environment preperation failed !!!\n\nException : " + ex.Message);
            }
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
            if (!DisposeEnvCheckbox.Checked)
            {
                return;
            }
            try
            {
                Directory.Delete("TempENV", true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not dispose of TempENV\n\n Exception : " + ex.Message);
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

        }
    }
}
