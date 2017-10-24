using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void FacultyLoginButton_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            UserLogin userLoginForm = new UserLogin();
            userLoginForm.Show();
        }
    }
}
