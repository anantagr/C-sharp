// Program Name:    GUI Technical Support

// Author:          Anant Agarwal

// Date:            10 April 20

//Description:      Mini-Project 4 Part 2
//                      The intent of this application is guide user what to do with a malfunctiong computer.

//Information provided by the user:
//                  1) If computer beeps ------ Y or N via checkboxes
//                  1) If discdrive beeps ----- Y or N via checkboxes

//There were no compilation errors in the program

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Technical_Support
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        
        //Clicking the Quit button will exit the application.
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Based on user's selection, we are determing the problem and displaying it in the textbox.
        //We are using if-else ladder to do the same
        private void outputButton_Click(object sender, EventArgs e)
        {
            if (computerBeepCheckBox.Checked )
            {
                if(DiscdriveSpinsCheckBox.Checked)
                {
                    resultTextBox.Text = "Bring your computer in to repair center";
                }
                else
                {
                    resultTextBox.Text = "Check drive cables";
                }
            }
            else
            {
                if (DiscdriveSpinsCheckBox.Checked)
                {
                    resultTextBox.Text = "Check speaker wires";
                }
                else
                {
                    resultTextBox.Text = "Call Tech Support";
                }
            }
        }

        //Everytime the user changes it choices, the display message is reset to blank.
        private void checkBoxChanged(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
        }
    }
}
