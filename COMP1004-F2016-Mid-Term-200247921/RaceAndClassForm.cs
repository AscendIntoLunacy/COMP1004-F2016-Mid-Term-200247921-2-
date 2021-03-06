﻿using COMP1004_F2016_Mid_Term_200247921.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class RaceAndClassForm : Form
    {
        public AbilityGeneratorForm previousForm;
        private string _selectedRace;


        public RaceAndClassForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Race = this._selectedRace;

            // Step 1 - show the parent form
            this.previousForm.Show();

            // Step 2 - close this form
            this.Close();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRace = (RadioButton)sender;

            this._selectedRace = selectedRace.Text;

            Program.character.Race = selectedRace.Text;

            string imageString = Regex.Replace(selectedRace.Text, @"\s+", "");
            RacePictureBox.Image = (Image)Resources.ResourceManager.GetObject(imageString);

            Program.character.RacePicture = RacePictureBox.Image;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            FinalForm finalForm = new FinalForm();
            finalForm.previousForm = this;

            finalForm.Show();
            this.Hide();
        }
    }
}
