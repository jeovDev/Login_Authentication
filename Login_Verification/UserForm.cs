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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            loadData();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
        void loadData() {

            ClassConnection data = new ClassConnection();

            data.username = Form1.username;
            data.displayData();
            label_firstname.Text = data.firstname;
            label_lastname.Text = data.lastname;
            label_id.Text = data.ID;
            label_username.Text = Form1.username;
            label_role.Text = data.role;
           


        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form1 logout = new Form1();
            logout.Show();
            this.Hide();
        }
    }
}
