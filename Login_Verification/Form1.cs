using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Verification
{
    public partial class Form1 : Form
    {
        public static string username;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            ClassConnection login = new ClassConnection();
            login.username = text_username.Text;
            login.password = text_password.Text;
            login.Login();
            //

            if (ClassConnection.isVerified == true)
            {
                username = text_username.Text;
                UserForm home = new UserForm();
                home.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("Username and password is incorrect!");
            }

        }

        private void picture_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
