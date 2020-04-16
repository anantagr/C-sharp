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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void getIntegarButton_Click(object sender, EventArgs e)
        {
            //this creates the instance
            GetIntegarDialog gid = new GetIntegarDialog(); 

            //configure the properties
            if (useCustomerPromptCheckbox.Checked)
            {
                gid.Prompt = customPromptTextbox.Text;
            }

            if (useMinimumValueCheckbox.Checked)
            {
                gid.MinimumValue = int.Parse(minimumValueTextBox.Text);
            }

            if (useMaximumValueCheckbox.Checked)
            {
                gid.MaximumValue = int.Parse(maximumValueTextBox.Text);
            }

            //put the Dialog on the display and capture result
            DialogResult result = gid.ShowDialog();

            //now show the result coming back from dialog
            switch (result)
            {
                case DialogResult.OK:

                    int entry = gid.EnteredValue;
                    enteredIntegarTextBox.Text = entry.ToString();
                    statusTextBox.Text = "Pressed OK";
                    break;

                case DialogResult.Cancel:
                    enteredIntegarTextBox.Text = "";
                    statusTextBox.Text = "Pressed Cancel";
                    break;

                default:
                    statusTextBox.Text = $"Got unexpected result {result}";
                    break;
            }
        }
    }
}
