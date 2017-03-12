using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Enter_Student_Details
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            dateLabel.Text = "Today : "+DateTime.Today.ToShortDateString();
        }

        //REGISTER ENTERED STUDENT
        private void register()
        {
            Student student = new Student
            {
                Firstname = txtFirstName.Text,
                Middlename = txtMiddleName.Text,
                Lastname = txtLastName.Text,
                Dob = dobDateTime.Value
            };

            DBClass db=new DBClass();
            if (db.registerStudent(student))
            {
                resetTxtx();
                MetroMessageBox.Show(this, "Successfully Registered " + student.Firstname);

            }
        }

        //RESET INPUT TEXTBOXES
        private void resetTxtx()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            dobDateTime.Value = DateTime.Today;
        }

        //VALIDATE DATA
        private bool validateStudentDetails()
        {
            if (txtFirstName.Text == "")
            {
                errorProvider1.SetError(txtFirstName,"Please enter FirstName");
            }
            else if (txtLastName.Text == "")
            {
                errorProvider1.SetError(txtLastName, "Please enter LatsName");
            }
            else
            {
                return true;
            }
            return false;
        }

        //REGISTER BUTTON CLICKED
        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (validateStudentDetails())
            {
                register();
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearErrorsLink_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

    }
}
