using StudentManagementApp.Business_Logic_Layer;
using StudentManagementApp.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp.Presentation_Layer
{
    public partial class ModuleForm : Form
    {
        public ModuleForm()
        {
            InitializeComponent();
        }

        private void btnRegisterModule_Click(object sender, EventArgs e)
        {
            string moduleCode = txtModCode.Text;
            string moduleName = txtModName.Text;
            string moduleDesc = txtModDesc.Text;
            string resources = txtModResource.Text;
            Module module = new Module(moduleCode, moduleName, moduleDesc, resources);
            DataHandler dataHandler = new DataHandler();
            dataHandler.RegisterMod(module);
            dgvModuleForm.DataSource = dataHandler.FetchModData();
        }

        private void btnUpdateModule_Click(object sender, EventArgs e)
        {
            string moduleCode = txtModCode.Text;
            string moduleName = txtModName.Text;
            string moduleDesc = txtModDesc.Text;
            string resources = txtModResource.Text;
            Module module = new Module(moduleCode, moduleName, moduleDesc, resources);
            DataHandler dataHandler = new DataHandler();
            dataHandler.UpdateMod(module);
            dgvModuleForm.DataSource = dataHandler.FetchModData();
        }

        private void btnDeleteModule_Click(object sender, EventArgs e)
        {
            string moduleCode = txtModCode.Text;
            Module module = new Module(moduleCode);
            DataHandler dataHandler = new DataHandler();
            dataHandler.DeleteMod(module);
            dgvModuleForm.DataSource = dataHandler.FetchModData();
        }

        private void btnSearchModule_Click(object sender, EventArgs e)
        {
            string modCode = txtModCode.Text;
            DataHandler dataHandler = new DataHandler();
            dgvModuleForm.DataSource = dataHandler.SearchMod(modCode);
        }

        private void btnViewModules_Click(object sender, EventArgs e)
        {
            DataHandler dataHandler = new DataHandler();
            dgvModuleForm.DataSource = dataHandler.FetchModData();
        }

        private void btnStudentForm_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            this.Hide();
            studentForm.Show();
        }
    }
}
