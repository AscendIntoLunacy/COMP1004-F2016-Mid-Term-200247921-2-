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
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Sets all text boxes to what is stored in Character class.
        private void FinalForm_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = Program.character.FirstName.ToString();
            LastNameTextBox.Text = Program.character.LastName.ToString();

            RaceTextBox.Text = Program.character.Race.ToString();

            StrengthTextBox.Text = Program.character.Strength.ToString();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();
            CharismaTextBox.Text = Program.character.Charisma.ToString();
        }
    }
}
