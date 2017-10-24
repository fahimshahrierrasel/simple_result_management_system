using System;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void FormCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormLoginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username/Password is empty", "Warning");
            }
            else
            {
                AdminArea adminArea = new AdminArea();
                adminArea.Show();

                Close();
            }
        }
    }
}
