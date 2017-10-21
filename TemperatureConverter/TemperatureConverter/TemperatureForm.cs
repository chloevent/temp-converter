﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * Simple program in C#.
 * Author: Chloe Viriyapunt
 * Updated: 10/21/2017
 */

namespace TemperatureConverter
{
    public partial class TemperatureForm : Form
    {
        //Create a Degree object
        Degree degree = new Degree();

        public TemperatureForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close program
            this.Close();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempTextBox.Text != null)
                {
                    if (CtoFradioButton.Checked)
                    {
                        double celsius = Double.Parse(tempTextBox.Text);
                        errorLabel.Text = "";
                        resultLabel.Text = degree.CtoF(celsius).ToString("n2") + " F";
                        
                    }
                    else if (FtoCradioButton.Checked)
                    {
                        double fahrenheit = Double.Parse(tempTextBox.Text);
                        errorLabel.Text = "";
                        resultLabel.Text = degree.FtoC(fahrenheit).ToString("n2") + " C";
                    }
                }
                else 
                {
                    errorLabel.Text = "Please enter numeric temperature! Unable to convert text to integer.";
                }
            }
            catch
            {
                errorLabel.Text = "Please enter numeric temperature! Unable to convert text to integer.";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            tempTextBox.Text = "";
            CtoFradioButton.Checked = false;
            FtoCradioButton.Checked = false;
            errorLabel.Text = "";
            tempTextBox.Focus();
        }

        
    }
}
