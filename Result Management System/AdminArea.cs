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
    public partial class AdminArea : Form
    {
        public AdminArea()
        {
            InitializeComponent();
            BringToFront();
        }

        private void AdminArea_Load(object sender, EventArgs e)
        {

        }

        private void FacultyRegistraion_Click(object sender, EventArgs e)
        {
            FacultyRegistration facultyRegistrationForm = new FacultyRegistration();
            facultyRegistrationForm.ShowDialog();
        }

        private void AddSectionButton_Click(object sender, EventArgs e)
        {
            AddSectionForm addSectionForm = new AddSectionForm();
            addSectionForm.ShowDialog();
        }
    }
}
