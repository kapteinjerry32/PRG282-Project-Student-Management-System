namespace StudentManagementApp.Presentation_Layer
{
    partial class SummaryReportForm
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
            this.btnStudentForm = new System.Windows.Forms.Button();
            this.btnGenerateSummaryReport = new System.Windows.Forms.Button();
            this.lblSummaryReport = new System.Windows.Forms.Label();
            this.lvSummaryReport = new System.Windows.Forms.ListView();
            this.btnViewSummaryText = new System.Windows.Forms.Button();
            this.btnModuleForm = new System.Windows.Forms.Button();
            this.dvgSummaryData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummaryData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStudentForm
            // 
            this.btnStudentForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStudentForm.Location = new System.Drawing.Point(268, 256);
            this.btnStudentForm.Name = "btnStudentForm";
            this.btnStudentForm.Size = new System.Drawing.Size(239, 52);
            this.btnStudentForm.TabIndex = 50;
            this.btnStudentForm.Text = "Student Form";
            this.btnStudentForm.UseVisualStyleBackColor = false;
            this.btnStudentForm.Click += new System.EventHandler(this.btnStudentForm_Click);
            // 
            // btnGenerateSummaryReport
            // 
            this.btnGenerateSummaryReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerateSummaryReport.Location = new System.Drawing.Point(34, 139);
            this.btnGenerateSummaryReport.Name = "btnGenerateSummaryReport";
            this.btnGenerateSummaryReport.Size = new System.Drawing.Size(239, 52);
            this.btnGenerateSummaryReport.TabIndex = 51;
            this.btnGenerateSummaryReport.Text = "Generate Summary Report";
            this.btnGenerateSummaryReport.UseVisualStyleBackColor = false;
            this.btnGenerateSummaryReport.Click += new System.EventHandler(this.btnGenerateSummaryReport_Click);
            // 
            // lblSummaryReport
            // 
            this.lblSummaryReport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSummaryReport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummaryReport.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryReport.Location = new System.Drawing.Point(256, 18);
            this.lblSummaryReport.Name = "lblSummaryReport";
            this.lblSummaryReport.Size = new System.Drawing.Size(371, 61);
            this.lblSummaryReport.TabIndex = 52;
            this.lblSummaryReport.Text = "Summary Report";
            this.lblSummaryReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvSummaryReport
            // 
            this.lvSummaryReport.HideSelection = false;
            this.lvSummaryReport.Location = new System.Drawing.Point(34, 256);
            this.lvSummaryReport.Name = "lvSummaryReport";
            this.lvSummaryReport.Size = new System.Drawing.Size(159, 166);
            this.lvSummaryReport.TabIndex = 53;
            this.lvSummaryReport.UseCompatibleStateImageBehavior = false;
            // 
            // btnViewSummaryText
            // 
            this.btnViewSummaryText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnViewSummaryText.Location = new System.Drawing.Point(598, 139);
            this.btnViewSummaryText.Name = "btnViewSummaryText";
            this.btnViewSummaryText.Size = new System.Drawing.Size(239, 52);
            this.btnViewSummaryText.TabIndex = 54;
            this.btnViewSummaryText.Text = "View Summary Text";
            this.btnViewSummaryText.UseVisualStyleBackColor = false;
            this.btnViewSummaryText.Click += new System.EventHandler(this.btnViewSummaryText_Click);
            // 
            // btnModuleForm
            // 
            this.btnModuleForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnModuleForm.Location = new System.Drawing.Point(268, 334);
            this.btnModuleForm.Name = "btnModuleForm";
            this.btnModuleForm.Size = new System.Drawing.Size(239, 52);
            this.btnModuleForm.TabIndex = 55;
            this.btnModuleForm.Text = "Module Form";
            this.btnModuleForm.UseVisualStyleBackColor = false;
            this.btnModuleForm.Click += new System.EventHandler(this.btnModuleForm_Click);
            // 
            // dvgSummaryData
            // 
            this.dvgSummaryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSummaryData.Location = new System.Drawing.Point(574, 237);
            this.dvgSummaryData.Name = "dvgSummaryData";
            this.dvgSummaryData.RowHeadersWidth = 51;
            this.dvgSummaryData.RowTemplate.Height = 24;
            this.dvgSummaryData.Size = new System.Drawing.Size(273, 195);
            this.dvgSummaryData.TabIndex = 56;
            // 
            // SummaryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(883, 464);
            this.Controls.Add(this.dvgSummaryData);
            this.Controls.Add(this.btnModuleForm);
            this.Controls.Add(this.btnViewSummaryText);
            this.Controls.Add(this.lvSummaryReport);
            this.Controls.Add(this.lblSummaryReport);
            this.Controls.Add(this.btnGenerateSummaryReport);
            this.Controls.Add(this.btnStudentForm);
            this.Name = "SummaryReportForm";
            this.Text = "SummaryReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dvgSummaryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudentForm;
        private System.Windows.Forms.Button btnGenerateSummaryReport;
        private System.Windows.Forms.Label lblSummaryReport;
        private System.Windows.Forms.ListView lvSummaryReport;
        private System.Windows.Forms.Button btnViewSummaryText;
        private System.Windows.Forms.Button btnModuleForm;
        private System.Windows.Forms.DataGridView dvgSummaryData;
    }
}