using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOddDemo
{
    public partial class mainForm : Form
    {
        const int ARRAY_SIZE = 25;
        int[] myRandomNumbers = new int[ARRAY_SIZE];
        const int RAND_MIN = 0;
        const int RAND_MAX = 999;

        public mainForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            dataDisplayTextbox.Clear();
            System.Random randomNum = new System.Random();
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                myRandomNumbers[i] = randomNum.Next(RAND_MIN, RAND_MAX);
                dataDisplayTextbox.AppendText(myRandomNumbers[i].ToString("000") + Environment.NewLine);
            }

            processButton.Enabled = true;
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            resultTextbox.Clear();
            if(evenRadioButton.Checked)
            {
                for(int i = 0; i < ARRAY_SIZE; i++)
                {
                    while(myRandomNumbers[i] % 2 == 0)
                    { 
                        resultTextbox.AppendText(myRandomNumbers[i].ToString("000") + Environment.NewLine);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ARRAY_SIZE; i++)
                {
                    while (myRandomNumbers[i] % 2 != 0)
                    {
                        resultTextbox.AppendText(myRandomNumbers[i].ToString("000") + Environment.NewLine);
                        break;
                    }
                }
            }
        }
    }
}
