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
    public partial class SummaryReportForm : Form
    {
        public SummaryReportForm()
        {
            InitializeComponent();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            lvSummaryReport.Columns.Add("Summary Item", 150);
            lvSummaryReport.Columns.Add("Value", 150);        
        }

        private void btnGenerateSummaryReport_Click(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            var (totalStudents, averageAge) = fileHandler.CalculateSummary();

            lvSummaryReport.Items.Clear();

            ListViewItem totalStudentsItem = new ListViewItem("Total Students");
            totalStudentsItem.SubItems.Add(totalStudents.ToString());
            lvSummaryReport.Items.Add(totalStudentsItem);

            ListViewItem averageAgeItem = new ListViewItem("Average Age");
            averageAgeItem.SubItems.Add(averageAge.ToString("F2"));
            lvSummaryReport.Items.Add(averageAgeItem);

            fileHandler.SaveSummaryToFile(totalStudents, averageAge);

            MessageBox.Show("Summary report generated successfully and saved to summary.txt.");
        }

        private void btnModuleForm_Click(object sender, EventArgs e)
        {
            ModuleForm moduleForm = new ModuleForm();
            this.Hide();
            moduleForm.Show();
        }

        private void btnViewSummaryText_Click(object sender, EventArgs e)
        {
            FileHandler fileHandler = new FileHandler();
            dvgSummaryData.DataSource = fileHandler.LoadSummaryFromFile();
        }
    }
}
