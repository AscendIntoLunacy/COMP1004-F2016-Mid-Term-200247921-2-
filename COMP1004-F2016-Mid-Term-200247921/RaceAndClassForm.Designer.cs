﻿namespace COMP1004_F2016_Mid_Term_200247921
{
    partial class RaceAndClassForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.RaceGroupBox = new System.Windows.Forms.GroupBox();
            this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
            this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.ElfRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.NextButton = new System.Windows.Forms.Button();
            this.RacePictureBox = new System.Windows.Forms.PictureBox();
            this.RaceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(32, 839);
            this.BackButton.Margin = new System.Windows.Forms.Padding(8);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(302, 95);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RaceGroupBox
            // 
            this.RaceGroupBox.Controls.Add(this.HalflingRadioButton);
            this.RaceGroupBox.Controls.Add(this.DwarfRadioButton);
            this.RaceGroupBox.Controls.Add(this.ElfRadioButton);
            this.RaceGroupBox.Controls.Add(this.HumanRadioButton);
            this.RaceGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceGroupBox.Location = new System.Drawing.Point(32, 29);
            this.RaceGroupBox.Margin = new System.Windows.Forms.Padding(8);
            this.RaceGroupBox.Name = "RaceGroupBox";
            this.RaceGroupBox.Padding = new System.Windows.Forms.Padding(8);
            this.RaceGroupBox.Size = new System.Drawing.Size(390, 415);
            this.RaceGroupBox.TabIndex = 5;
            this.RaceGroupBox.TabStop = false;
            this.RaceGroupBox.Text = "Select Race";
            // 
            // HalflingRadioButton
            // 
            this.HalflingRadioButton.AutoSize = true;
            this.HalflingRadioButton.Location = new System.Drawing.Point(16, 287);
            this.HalflingRadioButton.Margin = new System.Windows.Forms.Padding(8);
            this.HalflingRadioButton.Name = "HalflingRadioButton";
            this.HalflingRadioButton.Size = new System.Drawing.Size(190, 50);
            this.HalflingRadioButton.TabIndex = 5;
            this.HalflingRadioButton.Text = "Halfling";
            this.HalflingRadioButton.UseVisualStyleBackColor = true;
            this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // DwarfRadioButton
            // 
            this.DwarfRadioButton.AutoSize = true;
            this.DwarfRadioButton.Location = new System.Drawing.Point(16, 219);
            this.DwarfRadioButton.Margin = new System.Windows.Forms.Padding(8);
            this.DwarfRadioButton.Name = "DwarfRadioButton";
            this.DwarfRadioButton.Size = new System.Drawing.Size(161, 50);
            this.DwarfRadioButton.TabIndex = 4;
            this.DwarfRadioButton.Text = "Dwarf";
            this.DwarfRadioButton.UseVisualStyleBackColor = true;
            this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // ElfRadioButton
            // 
            this.ElfRadioButton.AutoSize = true;
            this.ElfRadioButton.Location = new System.Drawing.Point(16, 153);
            this.ElfRadioButton.Margin = new System.Windows.Forms.Padding(8);
            this.ElfRadioButton.Name = "ElfRadioButton";
            this.ElfRadioButton.Size = new System.Drawing.Size(104, 50);
            this.ElfRadioButton.TabIndex = 3;
            this.ElfRadioButton.Text = "Elf";
            this.ElfRadioButton.UseVisualStyleBackColor = true;
            this.ElfRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.Checked = true;
            this.HumanRadioButton.Location = new System.Drawing.Point(16, 85);
            this.HumanRadioButton.Margin = new System.Windows.Forms.Padding(8);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(185, 50);
            this.HumanRadioButton.TabIndex = 0;
            this.HumanRadioButton.TabStop = true;
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            this.HumanRadioButton.CheckedChanged += new System.EventHandler(this.RaceRadioButton_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(974, 839);
            this.NextButton.Margin = new System.Windows.Forms.Padding(8);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(302, 95);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // RacePictureBox
            // 
            this.RacePictureBox.Location = new System.Drawing.Point(631, 62);
            this.RacePictureBox.Name = "RacePictureBox";
            this.RacePictureBox.Size = new System.Drawing.Size(645, 639);
            this.RacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RacePictureBox.TabIndex = 6;
            this.RacePictureBox.TabStop = false;
            // 
            // RaceAndClassForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 1046);
            this.ControlBox = false;
            this.Controls.Add(this.RacePictureBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.RaceGroupBox);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "RaceAndClassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race And Class Selection";
            this.RaceGroupBox.ResumeLayout(false);
            this.RaceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RacePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox RaceGroupBox;
        private System.Windows.Forms.RadioButton HalflingRadioButton;
        private System.Windows.Forms.RadioButton DwarfRadioButton;
        private System.Windows.Forms.RadioButton ElfRadioButton;
        private System.Windows.Forms.RadioButton HumanRadioButton;
        protected System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.PictureBox RacePictureBox;
    }
}