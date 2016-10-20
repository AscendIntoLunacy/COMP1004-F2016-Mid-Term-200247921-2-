using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Application Name: Character Generator
 * Author Name: Bradley Girard
 * Application Creation Date: October 20th, 2016
 * Application Description: An application to help create a DnD Character.
 *                          Helps randomly generate names, abilities, and race
 *                          and prints to final form.
 */

namespace COMP1004_F2016_Mid_Term_200247921
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreenTimer_Tick(object sender, EventArgs e)
        {
            SplashScreenTimer.Enabled = false;
            GenerateNameForm nameForm = new GenerateNameForm();
            nameForm.Show();
            this.Hide();
        }
    }
}
