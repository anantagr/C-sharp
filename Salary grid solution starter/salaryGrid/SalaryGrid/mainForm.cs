//  Demonstration Code to show use of a rectangular array
//
//  Author:     Scott D. Thornton - All Rights Reserved
//              Februrary 2019
//
//  Purpose:    Teaching example - SAIT CPRG 200 (Manpower)
//
//  Description:    Determine a salary for teachers using a rectangular array where the rows correspond to number of years
//                  of teaching experience and the columns correspond to the number of years of post-secondary education.
//
//                  Use up/down counters to allow user to select both the year of education and experience. As they are changed,
//                  use a value changed event handler to signal that the salary should be recomputed and displayed. 
//

using System;
using System.Windows.Forms;

namespace SalaryGrid
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void displaySalary()
        {
            double[,] salaryGrid = {    { 59054 ,  62514 ,  66475 },
                                        { 62514 ,  65982 ,  69932 },
                                        { 65982 ,  69447 ,  73400 },
                                        { 69447 ,  72900 ,  76862 },
                                        { 72900 ,  76360 ,  80319 },
                                        { 76360 ,  79831 ,  83789 },
                                        { 79831 ,  83293 ,  87250 },
                                        { 83293 ,  86754 ,  90709 },
                                        { 86754 ,  90223 ,  94170 },
                                        { 90223 ,  93681 ,  97641 },
                                        { 93912 ,  97372 ,  101331 }

                                      };
            int yearsOfEducation    = (int)educationUpdown.Value;
            int yearsOfExperience   = (int)experienceUpdown.Value;
            //Console.WriteLine($"Education : {yearsOfEducation}, Experience : {yearsOfExperience}");

            //Validate and adjust years
            if(yearsOfEducation<4)
            {
                salaryTextbox.Text = "No job";
                return;
            }

            yearsOfEducation    = Math.Min(6,   yearsOfEducation);
            yearsOfExperience   = Math.Min(10,  yearsOfExperience);

            //index in to the salary grid table and put down the display

            salaryTextbox.Text = $"{salaryGrid[yearsOfExperience, yearsOfEducation - 4]:C2}";
        }
        private void experienceUpdown_ValueChanged(object sender, EventArgs e)
        {
            displaySalary();
        }

        private void educationUpdown_ValueChanged(object sender, EventArgs e)
        {
            displaySalary();
        }
    }
}
