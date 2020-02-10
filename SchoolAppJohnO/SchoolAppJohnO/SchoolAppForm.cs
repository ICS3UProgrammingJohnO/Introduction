using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolAppJohnO
{
    public partial class frmSchoolApp : Form
    {
        public frmSchoolApp()
        {
            InitializeComponent();
        }

        private void LblMascot_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the program
            this.Close();
        }
    }
}
