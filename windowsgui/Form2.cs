// like i said, feel free to do what ever you want with this code.

// all of this was made by me (aka soac)
// https://github.com/soacy :)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsgui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            guna2Panel2.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // this would be for your discord or sum
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // windows button thing
            guna2Panel2.Visible = !guna2Panel2.Visible;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // recycle bin app 
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/soacy");
        }

    }
}
