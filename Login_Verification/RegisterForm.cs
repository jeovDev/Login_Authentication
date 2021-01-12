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
    public partial class RegisterForm : Form
    {
  
        public RegisterForm()
        {

            InitializeComponent();
            siticoneAnimateWindow1.AnimationType = Siticone.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_CENTER;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
      
        }

        private void button_register_Click(object sender, EventArgs e)
        {


            if (String.IsNullOrEmpty(text_firstname.Text) || String.IsNullOrEmpty(text_lastname.Text) || String.IsNullOrEmpty(text_username.Text) || String.IsNullOrEmpty(text_password.Text) || String.IsNullOrEmpty(combo_role.Text))
            {
                MessageBox.Show("All fields required");
            } 
            else if (text_password.Text != text_confirm.Text) 
            {
                MessageBox.Show("Password does not match");
            }
            else
            {
                ClassConnection register = new ClassConnection();
                register.firstname = text_firstname.Text;
                register.lastname = text_lastname.Text;
                register.username = text_username.Text;
                register.password = text_password.Text;
                register.role = combo_role.Text;
                register.Register();
            }
        }
    }
}
