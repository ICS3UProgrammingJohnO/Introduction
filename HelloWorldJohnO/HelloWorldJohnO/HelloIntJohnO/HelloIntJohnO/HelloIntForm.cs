/*
 * Created by: John Omage
 * Created on: Fed. 11, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello, World! International
 * This program displays 4 radio buttons and when the user clicks on each radio 
 * button the greeting changes according to the language of the radio button.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloIntJohnO
{
    public partial class HelloIntForm : Form
    {
        public HelloIntForm()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Yoruba
            this.lblGreeting.Text = "Mo ki O Ile Aiye!";
        }

        private void RadEnglish_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to English
            this.lblGreeting.Text = "Hello, World!";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // change the greeting to Spanish
            this.lblGreeting.Text = "Hola Mundo!";
        }

        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            // change the greeting to Turkish
            this.lblGreeting.Text = "Selam Dünya!";
        }
    }
}
