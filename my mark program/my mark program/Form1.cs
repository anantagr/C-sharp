using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using getIntegarDialog_Development;
namespace my_mark_program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetIntegarDialog gid = new GetIntegarDialog();
            gid.Prompt = "Get me a triangle leg length";
            gid.MinimumValue = 0;
            if(gid.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show($"USer entered  a {gid.EnteredValue}");
            }

        }
    }
}
