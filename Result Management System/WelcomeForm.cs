using System;
using System.Windows.Forms;

namespace Result_Management_System
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Login Form will open for admin to login to the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminLoginButton_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        /// <summary>
        /// Login Form will open for faculty to login to the system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FacultyLoginButton_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        
        /// <summary>
        ///  Open UserLoginForm for entering the username and password
        /// </summary>
        private void OpenLoginForm()
        {
            UserLogin userLoginForm = new UserLogin();
            userLoginForm.Show();
        }

        /// <summary>
        /// Result Form Will open for Showing result to the student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm();
            resultForm.ShowDialog();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
