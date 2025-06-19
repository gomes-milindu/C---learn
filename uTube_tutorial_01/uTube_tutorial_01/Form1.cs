using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uTube_tutorial_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello World";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            label1.Text = "Set Button Clicked!";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            label1.Text = "Cancel Button Clicked!";
        }
    }
}
