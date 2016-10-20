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
    public partial class GenerateNameForm : Form
    {
        private Random _random;
        public GenerateNameForm()
        {
            InitializeComponent();

        }


        // Generates random names from two list boxes, and submits to character class.
        private void GenerateNames()
        {
            // Generates a random number and sifts through list box.
            // Uses the selected string and prints to text box.
            // Saves Textbox to character class
            int rnd = _random.Next(1, FirstNameListBox.Items.Count);
            FirstNameListBox.Select();
            FirstNameListBox.SelectedItem = FirstNameListBox.Items[rnd];
            FirstNameTextBox.Text = FirstNameListBox.SelectedItem.ToString();
            Program.character.FirstName = FirstNameTextBox.Text;

            int rnd2 = _random.Next(1, LastNameListBox.Items.Count);
            LastNameListBox.Select();
            LastNameListBox.SelectedItem = LastNameListBox.Items[rnd2];
            LastNameTextBox.Text = LastNameListBox.SelectedItem.ToString();
            Program.character.LastName = LastNameTextBox.Text;
        }

        // Runs the GenerateNames method when form loads
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this._random = new Random();
            GenerateNames();
        }

        // Runs Generate Names method when button is clicked
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // Hides form
            this.Hide();
            // Starts new form
            AbilityGeneratorForm abilityGenForm = new AbilityGeneratorForm();
            abilityGenForm.previousNameForm = this;
            abilityGenForm.Show();
        }
    }
}
