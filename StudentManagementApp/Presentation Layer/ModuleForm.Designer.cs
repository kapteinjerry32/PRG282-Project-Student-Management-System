namespace StudentManagementApp.Presentation_Layer
{
    partial class ModuleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModuleManagement = new System.Windows.Forms.Label();
            this.lblModCode = new System.Windows.Forms.Label();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
            this.lblModName = new System.Windows.Forms.Label();
            this.txtModDesc = new System.Windows.Forms.TextBox();
            this.lblModDesc = new System.Windows.Forms.Label();
            this.txtModResource = new System.Windows.Forms.TextBox();
            this.lblModResource = new System.Windows.Forms.Label();
            this.dgvModuleForm = new System.Windows.Forms.DataGridView();
            this.btnViewModules = new System.Windows.Forms.Button();
            this.btnSearchModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnUpdateModule = new System.Windows.Forms.Button();
            this.btnRegisterModule = new System.Windows.Forms.Button();
            this.btnStudentForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleForm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModuleManagement
            // 
            this.lblModuleManagement.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblModuleManagement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModuleManagement.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleManagement.Location = new System.Drawing.Point(234, 9);
            this.lblModuleManagement.Name = "lblModuleManagement";
            this.lblModuleManagement.Size = new System.Drawing.Size(371, 61);
            this.lblModuleManagement.TabIndex = 2;
            this.lblModuleManagement.Text = "Module Management";
            this.lblModuleManagement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(13, 101);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(88, 16);
            this.lblModCode.TabIndex = 3;
            this.lblModCode.Text = "Module Code";
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(146, 101);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(134, 22);
            this.txtModCode.TabIndex = 4;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(146, 161);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(134, 22);
            this.txtModName.TabIndex = 6;
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(13, 161);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(92, 16);
            this.lblModName.TabIndex = 5;
            this.lblModName.Text = "Module Name";
            // 
            // txtModDesc
            // 
            this.txtModDesc.Location = new System.Drawing.Point(146, 227);
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.Size = new System.Drawing.Size(134, 22);
            this.txtModDesc.TabIndex = 8;
            // 
            // lblModDesc
            // 
            this.lblModDesc.AutoSize = true;
            this.lblModDesc.Location = new System.Drawing.Point(13, 227);
            this.lblModDesc.Name = "lblModDesc";
            this.lblModDesc.Size = new System.Drawing.Size(123, 16);
            this.lblModDesc.TabIndex = 7;
            this.lblModDesc.Text = "Module Description";
            // 
            // txtModResource
            // 
            this.txtModResource.Location = new System.Drawing.Point(146, 296);
            this.txtModResource.Name = "txtModResource";
            this.txtModResource.Size = new System.Drawing.Size(134, 22);
            this.txtModResource.TabIndex = 10;
            // 
            // lblModResource
            // 
            this.lblModResource.AutoSize = true;
            this.lblModResource.Location = new System.Drawing.Point(13, 296);
            this.lblModResource.Name = "lblModResource";
            this.lblModResource.Size = new System.Drawing.Size(114, 16);
            this.lblModResource.TabIndex = 9;
            this.lblModResource.Text = "Module Resource";
            // 
            // dgvModuleForm
            // 
            this.dgvModuleForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleForm.Location = new System.Drawing.Point(365, 101);
            this.dgvModuleForm.Name = "dgvModuleForm";
            this.dgvModuleForm.RowHeadersWidth = 51;
            this.dgvModuleForm.RowTemplate.Height = 24;
            this.dgvModuleForm.Size = new System.Drawing.Size(503, 398);
            this.dgvModuleForm.TabIndex = 11;
            // 
            // btnViewModules
            // 
            this.btnViewModules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewModules.Location = new System.Drawing.Point(12, 449);
            this.btnViewModules.Name = "btnViewModules";
            this.btnViewModules.Size = new System.Drawing.Size(148, 41);
            this.btnViewModules.TabIndex = 48;
            this.btnViewModules.Text = "View Module Details";
            this.btnViewModules.UseVisualStyleBackColor = false;
            this.btnViewModules.Click += new System.EventHandler(this.btnViewModules_Click);
            // 
            // btnSearchModule
            // 
            this.btnSearchModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearchModule.Location = new System.Drawing.Point(198, 391);
            this.btnSearchModule.Name = "btnSearchModule";
            this.btnSearchModule.Size = new System.Drawing.Size(146, 41);
            this.btnSearchModule.TabIndex = 47;
            this.btnSearchModule.Text = "Search Module";
            this.btnSearchModule.UseVisualStyleBackColor = false;
            this.btnSearchModule.Click += new System.EventHandler(this.btnSearchModule_Click);
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteModule.Location = new System.Drawing.Point(12, 391);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(148, 41);
            this.btnDeleteModule.TabIndex = 46;
            this.btnDeleteModule.Text = "Delete Module";
            this.btnDeleteModule.UseVisualStyleBackColor = false;
            this.btnDeleteModule.Click += new System.EventHandler(this.btnDeleteModule_Click);
            // 
            // btnUpdateModule
            // 
            this.btnUpdateModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdateModule.Location = new System.Drawing.Point(198, 335);
            this.btnUpdateModule.Name = "btnUpdateModule";
            this.btnUpdateModule.Size = new System.Drawing.Size(146, 41);
            this.btnUpdateModule.TabIndex = 45;
            this.btnUpdateModule.Text = "Update Module";
            this.btnUpdateModule.UseVisualStyleBackColor = false;
            this.btnUpdateModule.Click += new System.EventHandler(this.btnUpdateModule_Click);
            // 
            // btnRegisterModule
            // 
            this.btnRegisterModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegisterModule.Location = new System.Drawing.Point(12, 335);
            this.btnRegisterModule.Name = "btnRegisterModule";
            this.btnRegisterModule.Size = new System.Drawing.Size(148, 41);
            this.btnRegisterModule.TabIndex = 44;
            this.btnRegisterModule.Text = "Register Module";
            this.btnRegisterModule.UseVisualStyleBackColor = false;
            this.btnRegisterModule.Click += new System.EventHandler(this.btnRegisterModule_Click);
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStudentForm.Location = new System.Drawing.Point(198, 449);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(146, 41);
            this.btnStudentForm.TabIndex = 50;
            this.btnStudentForm.Text = "Student Form";
            this.btnStudentForm.UseVisualStyleBackColor = false;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // ModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(880, 511);
            this.Controls.Add(this.btnStudentForm);
            this.Controls.Add(this.btnViewModules);
            this.Controls.Add(this.btnSearchModule);
            this.Controls.Add(this.btnDeleteModule);
            this.Controls.Add(this.btnUpdateModule);
            this.Controls.Add(this.btnRegisterModule);
            this.Controls.Add(this.dgvModuleForm);
            this.Controls.Add(this.txtModResource);
            this.Controls.Add(this.lblModResource);
            this.Controls.Add(this.txtModDesc);
            this.Controls.Add(this.lblModDesc);
            this.Controls.Add(this.txtModName);
            this.Controls.Add(this.lblModName);
            this.Controls.Add(this.txtModCode);
            this.Controls.Add(this.lblModCode);
            this.Controls.Add(this.lblModuleManagement);
            this.Name = "ModuleForm";
            this.Text = "Module Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModuleManagement;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.TextBox txtModDesc;
        private System.Windows.Forms.Label lblModDesc;
        private System.Windows.Forms.TextBox txtModResource;
        private System.Windows.Forms.Label lblModResource;
        private System.Windows.Forms.DataGridView dgvModuleForm;
        private System.Windows.Forms.Button btnViewModules;
        private System.Windows.Forms.Button btnSearchModule;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnUpdateModule;
        private System.Windows.Forms.Button btnRegisterModule;
        private System.Windows.Forms.Button btnStudentForm;
    }
}