namespace StudentManagementApp.Presentation_Layer
{
    partial class StudentForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentAge = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentNumber = new System.Windows.Forms.TextBox();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbCourse = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.dtpDob = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnViewStudents = new System.Windows.Forms.Button();
            this.clbModulesEnrolled = new System.Windows.Forms.CheckedListBox();
            this.dgvStudentView = new System.Windows.Forms.DataGridView();
            this.btnSummaryReportForm = new System.Windows.Forms.Button();
            this.btnModuleForm = new System.Windows.Forms.Button();
            this.btnStudMod = new System.Windows.Forms.Button();
            this.btnViewStudTextFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(242, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(371, 61);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Student Management";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(12, 411);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(97, 16);
            this.PhoneNumber.TabIndex = 31;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 194);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(61, 16);
            this.lblSurname.TabIndex = 30;
            this.lblSurname.Text = "Surname";
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(132, 405);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(212, 22);
            this.txtStudentPhone.TabIndex = 29;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(132, 188);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(212, 22);
            this.txtStudentSurname.TabIndex = 28;
            // 
            // txtStudentAge
            // 
            this.txtStudentAge.Location = new System.Drawing.Point(132, 295);
            this.txtStudentAge.Name = "txtStudentAge";
            this.txtStudentAge.Size = new System.Drawing.Size(212, 22);
            this.txtStudentAge.TabIndex = 26;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(132, 139);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(212, 22);
            this.txtStudentName.TabIndex = 25;
            // 
            // txtStudentNumber
            // 
            this.txtStudentNumber.Location = new System.Drawing.Point(132, 90);
            this.txtStudentNumber.Name = "txtStudentNumber";
            this.txtStudentNumber.Size = new System.Drawing.Size(212, 22);
            this.txtStudentNumber.TabIndex = 24;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(12, 301);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(32, 16);
            this.lbAge.TabIndex = 23;
            this.lbAge.Text = "Age";
            // 
            // lbCourse
            // 
            this.lbCourse.AutoSize = true;
            this.lbCourse.Location = new System.Drawing.Point(461, 106);
            this.lbCourse.Name = "lbCourse";
            this.lbCourse.Size = new System.Drawing.Size(50, 16);
            this.lbCourse.TabIndex = 22;
            this.lbCourse.Text = "Course";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 145);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Name";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Location = new System.Drawing.Point(12, 96);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(103, 16);
            this.lbStudentID.TabIndex = 20;
            this.lbStudentID.Text = "Student Number";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(12, 245);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(81, 16);
            this.lblDOB.TabIndex = 33;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(12, 355);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(52, 16);
            this.lblGender.TabIndex = 34;
            this.lblGender.Text = "Gender";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(132, 349);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(212, 22);
            this.txtGender.TabIndex = 35;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(132, 468);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 22);
            this.txtAddress.TabIndex = 36;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(15, 473);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Address";
            // 
            // dtpDob
            // 
            this.dtpDob.Location = new System.Drawing.Point(132, 240);
            this.dtpDob.Name = "dtpDob";
            this.dtpDob.Size = new System.Drawing.Size(212, 22);
            this.dtpDob.TabIndex = 38;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSearch.Location = new System.Drawing.Point(551, 553);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(146, 41);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(374, 553);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 41);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete Student";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdateStudent.Location = new System.Drawing.Point(198, 553);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(146, 41);
            this.btnUpdateStudent.TabIndex = 40;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRegister.Location = new System.Drawing.Point(12, 553);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(148, 41);
            this.btnRegister.TabIndex = 39;
            this.btnRegister.Text = "Register Student";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnViewStudents
            // 
            this.btnViewStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewStudents.Location = new System.Drawing.Point(719, 533);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(248, 41);
            this.btnViewStudents.TabIndex = 43;
            this.btnViewStudents.Text = "View All Student From Database";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);
            // 
            // clbModulesEnrolled
            // 
            this.clbModulesEnrolled.FormattingEnabled = true;
            this.clbModulesEnrolled.Location = new System.Drawing.Point(404, 126);
            this.clbModulesEnrolled.Margin = new System.Windows.Forms.Padding(4);
            this.clbModulesEnrolled.Name = "clbModulesEnrolled";
            this.clbModulesEnrolled.Size = new System.Drawing.Size(209, 174);
            this.clbModulesEnrolled.TabIndex = 44;
            // 
            // dgvStudentView
            // 
            this.dgvStudentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentView.Location = new System.Drawing.Point(642, 12);
            this.dgvStudentView.Name = "dgvStudentView";
            this.dgvStudentView.RowHeadersWidth = 51;
            this.dgvStudentView.RowTemplate.Height = 24;
            this.dgvStudentView.Size = new System.Drawing.Size(388, 515);
            this.dgvStudentView.TabIndex = 47;
            // 
            // btnSummaryReportForm
            // 
            this.btnSummaryReportForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSummaryReportForm.Location = new System.Drawing.Point(374, 390);
            this.btnSummaryReportForm.Name = "btnSummaryReportForm";
            this.btnSummaryReportForm.Size = new System.Drawing.Size(239, 52);
            this.btnSummaryReportForm.TabIndex = 48;
            this.btnSummaryReportForm.Text = "Summary Report Form";
            this.btnSummaryReportForm.UseVisualStyleBackColor = false;
            this.btnSummaryReportForm.Click += new System.EventHandler(this.btnSummaryReportForm_Click);
            // 
            // btnModuleForm
            // 
            this.btnModuleForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnModuleForm.Location = new System.Drawing.Point(374, 455);
            this.btnModuleForm.Name = "btnModuleForm";
            this.btnModuleForm.Size = new System.Drawing.Size(239, 52);
            this.btnModuleForm.TabIndex = 49;
            this.btnModuleForm.Text = "Module Form";
            this.btnModuleForm.UseVisualStyleBackColor = false;
            this.btnModuleForm.Click += new System.EventHandler(this.btnModuleForm_Click);
            // 
            // btnStudMod
            // 
            this.btnStudMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStudMod.Location = new System.Drawing.Point(413, 318);
            this.btnStudMod.Name = "btnStudMod";
            this.btnStudMod.Size = new System.Drawing.Size(176, 41);
            this.btnStudMod.TabIndex = 50;
            this.btnStudMod.Text = "View Student Modules";
            this.btnStudMod.UseVisualStyleBackColor = false;
            this.btnStudMod.Click += new System.EventHandler(this.btnStudMod_Click);
            // 
            // btnViewStudTextFile
            // 
            this.btnViewStudTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewStudTextFile.Location = new System.Drawing.Point(804, 580);
            this.btnViewStudTextFile.Name = "btnViewStudTextFile";
            this.btnViewStudTextFile.Size = new System.Drawing.Size(258, 41);
            this.btnViewStudTextFile.TabIndex = 61;
            this.btnViewStudTextFile.Text = "View All Student From TextFile";
            this.btnViewStudTextFile.UseVisualStyleBackColor = false;
            this.btnViewStudTextFile.Click += new System.EventHandler(this.btnViewStudTextFile_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1074, 627);
            this.Controls.Add(this.btnViewStudTextFile);
            this.Controls.Add(this.btnStudMod);
            this.Controls.Add(this.btnModuleForm);
            this.Controls.Add(this.btnSummaryReportForm);
            this.Controls.Add(this.dgvStudentView);
            this.Controls.Add(this.clbModulesEnrolled);
            this.Controls.Add(this.btnViewStudents);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpDob);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtStudentPhone);
            this.Controls.Add(this.txtStudentSurname);
            this.Controls.Add(this.txtStudentAge);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentNumber);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbCourse);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbStudentID);
            this.Controls.Add(this.lblTitle);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentAge;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentNumber;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbCourse;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.DateTimePicker dtpDob;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.CheckedListBox clbModulesEnrolled;
        private System.Windows.Forms.DataGridView dgvStudentView;
        private System.Windows.Forms.Button btnSummaryReportForm;
        private System.Windows.Forms.Button btnModuleForm;
        private System.Windows.Forms.Button btnStudMod;
        private System.Windows.Forms.Button btnViewStudTextFile;
    }
}