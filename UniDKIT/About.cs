using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniDKIT.Tools;

namespace UniDKIT
{
    public partial class About : Form
    {
        int counter1;
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            VersionText.Text = "// " + Main.Version;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            counter1 += 1;

            if (counter1 > 53 && Main.counter2 > 37) 
            {
                counter1 = -4354564;
                Main.counter2 = -345564567;
                var soap = new Placeholder();
                soap.Show();
            }
        }
    }
}
