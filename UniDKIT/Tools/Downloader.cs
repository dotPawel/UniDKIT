using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniDKIT
{
    public partial class Downloader : Form
    {
        static int Mode = 1;
        public Downloader()
        {
            InitializeComponent();
        }

        private void Downloader_Load(object sender, EventArgs e)
        {

        }
        private void OnUncheck(object sender, EventArgs e)
        {
            InputTextbox.Text = string.Empty;
            OutputTextbox.Text = string.Empty;

            if (PackageButton.Checked)
            {
                InfoButton.Checked = false;
                Mode = 1;
            }
            if (InfoButton.Checked)
            {
                PackageButton.Checked = false;
                Mode = 2;
            }
            else
            {
                InfoButton.Checked = false;
                PackageButton.Checked = true;
                Mode = 1;
            }
        }

        private void BrowseButton_Click(object sender, EventArgs e)
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
                using (var sfd = new SaveFileDialog())
                {
                    sfd.Filter = "UniPKG package information files (*.pkginfo)|*.pkginfo|All files (*.*)|*.*";
                    DialogResult result = sfd.ShowDialog();

                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(sfd.FileName))
                    {
                        OutputTextbox.Text = sfd.FileName;
                    }
                }
            }
        }

        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {
            if (Main.DirPath != null)
            {
                if (Mode == 1)
                {
                    OutputTextbox.Text = Main.DirPath + @"\" + InputTextbox.Text + ".unipkg";
                }
                if (Mode == 2)
                {
                    OutputTextbox.Text = Main.DirPath + @"\" + InputTextbox.Text + ".pkginfo";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (InputTextbox.Text == "")
            {
                MessageBox.Show("Package name is empty");
                return;
            }
            if (OutputTextbox.Text == "")
            {
                MessageBox.Show("Output is empty");
                return;
            }

            try
            {
                if (Mode == 1)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://unipkg.vercel.app/unipkg/" + InputTextbox.Text + ".unipkg", OutputTextbox.Text);
                    }
                }
                if (Mode == 2)
                {
                    using (var client = new WebClient())
                    {
                        client.DownloadFile("https://unipkg.vercel.app/unipkg/" + InputTextbox.Text + ".pkginfo", OutputTextbox.Text);
                    }
                }
                MessageBox.Show("Successfully downloaded file from server\n\n" + OutputTextbox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Downloading failed\n\n Exception : " + ex.Message);
            }
        }
    }
}
