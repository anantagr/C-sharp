using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace getIntegarDialog_Development
{
    public partial class GetIntegarDialog : Form
    {
        public int MaximumValue
        {
            set
            {
                maximumValue = value;
                haveMaximumValue = true;
            }
        }

        private int maximumValue;

        public int MinimumValue
        {
            set
            {
                minimumValue = value;
                haveMinimumValue = true;
            }
        }

        private int minimumValue;
        private bool haveMinimumValue = false;
        private bool haveMaximumValue = false;

        public string Prompt
        {
            set
            {
                promptLabel.Text = value;
            }

            get
            {
                return promptLabel.Text;
            }
        }

        public int EnteredValue
        {
            get
            {
                return enteredValue;
            }
        }

        private int enteredValue;
        public GetIntegarDialog()
        {
            InitializeComponent();
        }

        private bool validIntegarEntry()
        {
            if(inputTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must enter an Integar first");
                return false;
            }

            if(!int.TryParse(inputTextBox.Text, out enteredValue))
            {
                MessageBox.Show("Non numeric characters in the entered Integar.");
                return false;
            }

            if(haveMinimumValue)
            {
                if(enteredValue < minimumValue)
                {
                    MessageBox.Show("Value entered is below the minimum value");
                    return false;
                }
            }

            if (haveMaximumValue)
            {
                if (enteredValue > maximumValue)
                {
                    MessageBox.Show("Value entered is above the maximum value");
                    return false;
                }
            }
            return true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if(!validIntegarEntry())
            {
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
