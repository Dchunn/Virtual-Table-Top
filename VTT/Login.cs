using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace VTT
{
    public partial class Login : Form
    {
        //I need a random string generator
        public string random_string(int amount)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var output = new char[amount];
            var random = new Random();

            for (int i = 0; i < amount; i++)
            {
                output[i] = chars[random.Next(chars.Length)];
            }

            return output.ToString();
        }
        //The password checker
        public bool passoword_check(string user, string password)
        {
            //I need to hash the password and send that to another program to check it
            //and I need to add random salt to it

            byte[] data = System.Text.Encoding.ASCII.GetBytes(password);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            string hash = System.Text.Encoding.ASCII.GetString(data);
            string begining = random_string(5);
            string ending = random_string(7);
            hash = begining + hash + ending;

            return false;
        }
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //grab text box indformatio and send it to the checker
        }
    }
}
