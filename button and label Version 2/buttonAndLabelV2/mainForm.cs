using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button
{
    public partial class mainForm : Form
    {
        private int clickCount = 0;
        private int mouseEnterCount = 0;
        private int mouseHoverCount = 0;
        private int mouseLeaveCount = 0;
        private int mouseUpCount = 0;


        public mainForm()
        {
            InitializeComponent();
        }

        private void pushMeButton_Click(object sender, EventArgs e)
        {
            clickCount++;
            buttonClickOutput.Text = ($"{clickCount}");
        }

        private void pushMeButton_MouseEnter(object sender, EventArgs e)
        {
            mouseEnterCount++;
            mouseEnterOutput.Text = ($"{mouseEnterCount}");
        }

        private void pushMeButton_MouseHover(object sender, EventArgs e)
        {
            mouseHoverCount++;
            mouseHoverOutput.Text = ($"{mouseHoverCount}");
        }

        private void pushMeButton_MouseLeave(object sender, EventArgs e)
        {
            mouseLeaveCount++;
            mouseLeaveOutput.Text = ($"{mouseLeaveCount}");
        }

        private void pushMeButton_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUpCount++;
            mouseUpOutput.Text = ($"{mouseUpCount}");
        }
    }
}
