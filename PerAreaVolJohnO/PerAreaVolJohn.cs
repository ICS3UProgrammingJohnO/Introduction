using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolJohnO
{
    public partial class frmPerAreaVolJohn : Form
    {
        public frmPerAreaVolJohn()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtlVolume_Click(object sender, EventArgs e)
        {
            this.lblVolume.Text = Convert.ToString((double)4 / (double)3 * Math.PI * Math.Pow(4, 3)) + "cm";
        }

        private void BtlPerimeter_Click(object sender, EventArgs e) =>
            //caculate the perimetre of the rectangle
            this.lblPerimeter.Text = Convert.ToString(2 * 7 + 2 * 5) + "cm";

        private void LblPerimeter_Click(object sender, EventArgs e)
        {
            
        }

        private void BtlArea_Click(object sender, EventArgs e)
        {
            //caculate the area of a circle
            this.lblArea.Text = Convert.ToString(Math.PI * Math.Pow (6, 2)) + "cm";
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelloToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
