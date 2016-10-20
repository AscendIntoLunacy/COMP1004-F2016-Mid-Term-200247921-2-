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

        private void GenerateNames()
        {
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

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            this._random = new Random();
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGenForm = new AbilityGeneratorForm();
        }
    }
}
