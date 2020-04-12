using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_hello_world
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void helloWorldLable_Click(object sender, EventArgs e)
        {
            
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (changeLanguageButton.Text == "In English")
            {
                helloWorldLable.Text = "Hello World";
                changeLanguageButton.Text = "en français";
                quitButton.Text = "Quit";
                helloWorldLable.ForeColor = Color.Black;
            }
            else
            { 
            helloWorldLable.Text = "Bonjour le monde";
            helloWorldLable.ForeColor = Color.Green;
            changeLanguageButton.Text = "In English";
            quitButton.Text = "Sortie";
            }
        }
    }
}
