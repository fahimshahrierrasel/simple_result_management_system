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
    public partial class FacultyRegistration : Form
    {
        
        public FacultyRegistration()
        {
            InitializeComponent();
            FacultyDepartment.SelectedIndex = 0;
        }

        private void FacultyRegisterButton_Click(object sender, EventArgs e)
        {
            string name = FacultyName.Text;
            string initial = FacultyInitial.Text;
            string department = FacultyDepartment.SelectedItem.ToString();

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(initial) || String.IsNullOrEmpty(department))
            {
                MessageBox.Show(@"No field can not be empty!", @"Warning");
            }
            else
            {
                if (RegisterFacultyAndUser(name, initial, department))
                {
                    MessageBox.Show(@"Faculty Registered", @"Success");
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Faculty not registered!!", @"Error");
                }
            }
        }

        private void FacultyRegistraionCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool RegisterFacultyAndUser(string name, string initial, string department)
        {
            DatabaseConnection dbConnection = new DatabaseConnection();
            try
            {
                dbConnection.Cmd.CommandText =
                    "Insert into Faculty (name, initial, department) Values(@Name, @Initial, @Dept)";
                dbConnection.Cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;
                dbConnection.Cmd.Parameters.Add("@Initial", SqlDbType.VarChar).Value = initial;
                dbConnection.Cmd.Parameters.Add("@Dept", SqlDbType.VarChar).Value = department;
                dbConnection.Con.Open();
                dbConnection.Cmd.ExecuteNonQuery();
                
                dbConnection.ClearCommandText();

                dbConnection.Cmd.CommandText =
                    "Insert into RMUser (username, pass, type) Values(@UserName, @Pass, @Type)";
                dbConnection.Cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = initial;
                dbConnection.Cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = @"faculty123";
                dbConnection.Cmd.Parameters.Add("@Type", SqlDbType.VarChar).Value = @"Faculty";
                
                dbConnection.Cmd.ExecuteNonQuery();
                dbConnection.ClearCommandText();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.StackTrace, @"Exception");
                return false;
            }
            finally
            {
                dbConnection.Con.Close();
            }
            return true;
        }
    }
}
