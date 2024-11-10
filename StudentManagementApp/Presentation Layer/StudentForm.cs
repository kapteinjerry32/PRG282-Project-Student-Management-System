using StudentManagementApp.Business_Logic_Layer;
using StudentManagementApp.Data_Layer;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementApp.Presentation_Layer
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(txtStudentNumber.Text);
            string name = txtStudentName.Text;
            string surname = txtStudentSurname.Text;
            DateTime dateOfBirth = DateTime.Parse(dtpDob.Text);
            int age = int.Parse(txtStudentAge.Text);
            string gender = txtGender.Text;
            string phone = txtStudentPhone.Text;
            string address = txtAddress.Text;
            string course = clbModulesEnrolled.Text;

            Student student = new Student(studentNumber, name, surname, dateOfBirth, age, gender, phone, address, course);

            DataHandler dataHandler = new DataHandler();
            dataHandler.RegisterStud(student);

            FileHandler fileHandler = new FileHandler();
            fileHandler.WriteStudentToFile(student);

            dgvStudentView.DataSource = dataHandler.FetchStudData();
            dgvStudentView.DataSource = fileHandler.ReadAllStudents();

            MessageBox.Show("Student added successfully.");
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(txtStudentNumber.Text);
            string name = txtStudentName.Text;
            string surname = txtStudentSurname.Text;
            DateTime dateOfBirth = DateTime.Parse(dtpDob.Text);
            int age = int.Parse(txtStudentAge.Text);
            string gender = txtGender.Text;
            string phone = txtStudentPhone.Text;
            string address = txtAddress.Text;
            string course = clbModulesEnrolled.Text;

            Student student = new Student(studentNumber, name, surname, dateOfBirth, age, gender, phone, address, course);

            DataHandler dataHandler = new DataHandler();
            dataHandler.UpdateStud(student);

            FileHandler fileHandler = new FileHandler();
            fileHandler.UpdateStudentInFile(student);

            dgvStudentView.DataSource = dataHandler.FetchStudData();
            dgvStudentView.DataSource = fileHandler.ReadAllStudents();

            MessageBox.Show("Student information updated successfully.");
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int studentNumber = int.Parse(txtStudentNumber.Text);

            Student student = new Student { StudentNumber = studentNumber };

            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteStud(student);

            FileHandler fileHandler = new FileHandler();
            fileHandler.DeleteStudentFromFile(studentNumber);

            dgvStudentView.DataSource = fileHandler.ReadAllStudents();
            dgvStudentView.DataSource = dataHandler.FetchStudData();
            

            MessageBox.Show("Student deleted successfully.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int stdNum = int.Parse(txtStudentNumber.Text);
            DataHandler dataHandler = new DataHandler();
            dgvStudentView.DataSource = dataHandler.SearchStud(stdNum);
        }

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dgvStudentView.DataSource = dataHandler.FetchStudData();
        }

        private void btnModuleForm_Click(object sender, EventArgs e)
        {
            ModuleForm moduleForm = new ModuleForm();
            this.Hide();
            moduleForm.Show();
        }

        private void btnSummaryReportForm_Click(object sender, EventArgs e)
        {
            SummaryReportForm summaryReportForm = new SummaryReportForm();
            this.Hide();
            summaryReportForm.Show();
        }

        private void btnStudMod_Click(object sender, EventArgs e)
        {
            try
            {
                int studentNumber = int.Parse(txtStudentNumber.Text);

                DataHandler dataHandler = new DataHandler();
                DataTable studentModules = dataHandler.FetchStudentModules(studentNumber);

                clbModulesEnrolled.Items.Clear();

                if (studentModules == null)
                {
                    MessageBox.Show("An error occurred while fetching modules.");
                    return;
                }

                if (studentModules.Rows.Count == 0)
                {
                    MessageBox.Show("No modules found for the specified student.");
                    return;
                }

                foreach (DataRow row in studentModules.Rows)
                {
                    if (row.Table.Columns.Contains("moduleName"))
                    {
                        clbModulesEnrolled.Items.Add(row["moduleName"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Column 'moduleName' not found in the query result.");
                        return;
                    }
                }

                MessageBox.Show("Modules displayed successfully.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid student number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
        }

        private void btnViewStudTextFile_Click(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            dgvStudentView.DataSource = fileHandler.ReadAllStudents();
        }

        private void cbLPR181_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbWPR281_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
