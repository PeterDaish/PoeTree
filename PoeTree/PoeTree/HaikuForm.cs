using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoeTree
{
    public partial class HaikuForm : Form
    {
        public HaikuForm()
        {
            InitializeComponent();
        }

        private void linkLblHaikuDescription_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Haiku");
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            //Check the syllables within the boxes conform to the requirements, 5, 7, 5
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Format the data entered by the user to make it look pretty.
        }
    }
}
