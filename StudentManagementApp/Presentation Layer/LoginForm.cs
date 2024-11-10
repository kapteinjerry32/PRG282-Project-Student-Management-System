using StudentManagementApp.Business_Logic_Layer;
using StudentManagementApp.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp.Presentation_Layer
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                FileHandler fileHandler = new FileHandler();
                string outcome = fileHandler.ReadFromFile(txtEmailAddress.Text, txtPassword.Text);
                switch (outcome)
                {
                    case "Successfull":
                        MessageBox.Show("Login Successfull");
                        StudentForm studentForm = new StudentForm();
                        this.Hide();
                        studentForm.Show();
                        break;

                    case "Incorrect Password":
                        MessageBox.Show("Password Incorrect. Please try again.");
                        break;

                    case "Incorrect Email":
                        MessageBox.Show("Email does not exist. Please Try again or sign up.");
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Logic logic = new Logic();
            if (logic.ValidateEmail(txtEmailAddress.Text) == true)
            {
                try
                {
                    FileHandler fileHandler = new FileHandler();
                    fileHandler.WriteToFile(txtEmailAddress.Text, txtPassword.Text);
                    MessageBox.Show("User Successfully Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Email Address, Please enter a valid email.");
            }
        }
    }
}
