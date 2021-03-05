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
    public partial class PoeTreeMain : Form
    {
        public PoeTreeMain()
        {
            InitializeComponent();
        }

        private void btnHaiku_Click(object sender, EventArgs e)
        {
            Form haikuForm = new HaikuForm();
            haikuForm.Show();
        }
    }
}
