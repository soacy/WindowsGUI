// this is just a template for whatever you feel like doing with it.
// its all designed to look and sorta feel like a small windows client
// feel free to change any code or replace it

// all of this was made by me (aka soac)
// https://github.com/soacy :)


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // shitty login code lol

            if (guna2TextBox2.Text == "password")
            {
                MessageBox.Show("Welcome User.", "Sucessfully Logged In");

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();

                SoundPlayer sp = new SoundPlayer(Properties.Resources.Login_Sound);
                sp.Play();

                Form2 f2 = new Form2();
                this.Hide();

                f2.FormClosed += (s, args) =>
                {
                    this.Close();
                };
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please try again with a different passwprd.", "Invalid Password.");
            }
        }

        private void guna2TextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1_Click(this, new EventArgs());
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // this would be for your discord or anything else idk

            Process.Start("https://discord.gg/aRepW8G68d");
        }
    }
}
