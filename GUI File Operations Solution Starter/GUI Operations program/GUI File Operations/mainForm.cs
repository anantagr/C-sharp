//  Demonstration Code to demonstrate the use of the file operations and GUI controls for file selection
//
//  Author:     Scott D. Thornton - All Rights Reserved
//              Februrary 2019
//
//  Purpose:    Teaching example - SAIT CPRG 200 (Manpower)
//
//  Description:    
//
//                  Expected Behaviour
//                      Select File button      pop a OpenFileDialog() to select a data file. Put the full path into the
//                                              textbox positioned beside the button
//                      File Path Textbox       gets the file path selected by GUI control or entered/edited directly by the
//                                              user (lets the user enter a "bad" filepath to test an open failure)
//
//                                              Once we have a potential file path (characters in the textbox) turn on
//                                              calculate button.
//
//                      Calculate button        opens the file whose path is given in the file path textbox. Reads the
//                                              contents of the file (a list of numbers, possibly more than one per line, 
//                                              blank lines allowed), calculates the sum, min, max as the data is read
//                                              (no need for arrays here) and then the average. Put the results into the 
//                                              various text boxes. Close the file, and turn on the Write Results button.
//
//                      Write Results           pop a SaveFileDialog() to select the name of an ouptut file, write out the 
//                                              statistics text boxes.
//

using System;
using System.IO;
using System.Windows.Forms;

namespace GUIFileOperations
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void filePathTextbox_TextChanged(object sender, EventArgs e)
        {
            calculateButton.Enabled = filePathTextbox.Text.Length != 0;
            //if (filePathTextbox.Text.Length == 0)
            //{
            //    calculateButton.Enabled = false;
            //}
            //else
            //{
            //    calculateButton.Enabled = true;
            //}
        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title       = "Open Text File";
            ofd.Filter      = " Text File |*.txt| All Files |*.*";
            ofd.FilterIndex = 1;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePathTextbox.Text = ofd.FileName;
            }
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inFile;
            int sum;
            int maximum;
            int minimum;
            double average;
            bool result;

            //Try to open the file and catch any exceptions. If the file fails to open then give up

            try
            {
                inFile = new StreamReader(filePathTextbox.Text);
            }

            catch (Exception exception)
            {
                MessageBox.Show($"File failed to open. \n\n{exception.Message}");
                calculateButton.Enabled = false;
                return;
            }

            //If the file successfully opened, so pass the stream reader on a different method to calculate
            //sum, average, min and max

            result = findStatistics(inFile, out sum, out average, out minimum, out maximum);

            //close the file and display the results on the form

            inFile.Close();
            if(result)
            {
                sumTextbox.Text = sum.ToString();
                averageTextbox.Text = average.ToString("N2");
                minimumTextbox.Text = minimum.ToString();
                maximumTextbox.Text = maximum.ToString();

                writeResultButton.Enabled = true;
            }
        }

        //creating a method to find sum, average, max and min
        private bool findStatistics(StreamReader file, out int sum, out double average, out int minimum, out int maximum)
        {
            string inputLine;                              //To store one line at a time while reading the file
            string[] numbers;                              //numbers will be an array to store the number after splitting 
                                                           //it fromt the line
            char[] delimiters = { ' ' , ',' , '\t' };      //This is an array to store our delimiters to break each line 
                                                           //into individual numbers
            
            //initialize the output variables
            sum         = 0;
            average     = 0.0;
            minimum     = 0;
            maximum     = 0;
            int count   = 0;
            //read data while we are not in the end of stream
            //  1) Read each line
            //  2) Split the lines into token
            //  3) convert each token to a number
            //  4) and adjust the statistics

            while(!file.EndOfStream)
            {
                inputLine = file.ReadLine();    //We are strong one line at a time from file in inputLine

                //This will split the line based on delimiters and store that in numbers array, also we will 
                //remove any empty entries
                numbers = inputLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); 

                //This will run a foreach loop in array and extract individual numbers and store it in v
                foreach(string v in numbers)
                {
                    int value;

                    //We will take each bit of numbers stored in 'v' as string and make it an integar and store in value.
                    //So 'v' going in and 'value' coming out
                    //if not int means it was not able to convert 'v' into integar 'value'. So exit
                    if (!int.TryParse(v, out value))
                    {
                        MessageBox.Show($"Error in file. Line is \n'{inputLine}'");
                        return false;
                    }

                    sum += value;
                    count++;

                    if (count == 1)
                    {
                        minimum = value;
                        maximum = value;
                    }
                    else
                    {
                        minimum = Math.Min(minimum, value);
                        maximum = Math.Max(maximum, value);
                    }
                }
            }

            //  Calculate the average
            average = (double)sum / count;

            return true;
        }

        private void writeResultButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title       = "Save Statistics";
            sfd.DefaultExt  = ".results";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter outfile = new StreamWriter(sfd.FileName);
                    
                    outfile.WriteLine($"Sum:        {sumTextbox.Text}");
                    outfile.WriteLine($"Average:    {averageTextbox.Text}");
                    outfile.WriteLine($"Minimum:    {minimumTextbox.Text}");
                    outfile.WriteLine($"Maximum:    {maximumTextbox.Text}");

                    outfile.Close(); 

                }
                catch (Exception exception)
                {
                    MessageBox.Show($"File was not created. \n\n{exception.Message}");
                    return;
                }




            }
        }
    }
}