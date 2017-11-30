namespace Result_Management_System
{
    partial class FacultyArea
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
            this.GradeSubmissionButton = new System.Windows.Forms.Button();
            this.FacultyName = new System.Windows.Forms.Label();
            this.FacultyDepartment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SectionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // GradeSubmissionButton
            // 
            this.GradeSubmissionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeSubmissionButton.Location = new System.Drawing.Point(37, 189);
            this.GradeSubmissionButton.Name = "GradeSubmissionButton";
            this.GradeSubmissionButton.Size = new System.Drawing.Size(215, 44);
            this.GradeSubmissionButton.TabIndex = 0;
            this.GradeSubmissionButton.Text = "Grade Submission";
            this.GradeSubmissionButton.UseVisualStyleBackColor = true;
            this.GradeSubmissionButton.Click += new System.EventHandler(this.GradeSubmissionButton_Click);
            // 
            // FacultyName
            // 
            this.FacultyName.AutoSize = true;
            this.FacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyName.Location = new System.Drawing.Point(65, 39);
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.Size = new System.Drawing.Size(164, 16);
            this.FacultyName.TabIndex = 1;
            this.FacultyName.Text = "A Really Really Big Name";
            this.FacultyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FacultyName.Click += new System.EventHandler(this.FacultyName_Click);
            // 
            // FacultyDepartment
            // 
            this.FacultyDepartment.AutoSize = true;
            this.FacultyDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyDepartment.Location = new System.Drawing.Point(105, 67);
            this.FacultyDepartment.Name = "FacultyDepartment";
            this.FacultyDepartment.Size = new System.Drawing.Size(78, 16);
            this.FacultyDepartment.TabIndex = 2;
            this.FacultyDepartment.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Section";
            // 
            // SectionSelectionComboBox
            // 
            this.SectionSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionSelectionComboBox.FormattingEnabled = true;
            this.SectionSelectionComboBox.Location = new System.Drawing.Point(108, 156);
            this.SectionSelectionComboBox.Name = "SectionSelectionComboBox";
            this.SectionSelectionComboBox.Size = new System.Drawing.Size(121, 24);
            this.SectionSelectionComboBox.TabIndex = 4;
            // 
            // FacultyArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SectionSelectionComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyDepartment);
            this.Controls.Add(this.FacultyName);
            this.Controls.Add(this.GradeSubmissionButton);
            this.Name = "FacultyArea";
            this.Text = "Faculty Area";
            this.Load += new System.EventHandler(this.FacultyArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GradeSubmissionButton;
        private System.Windows.Forms.Label FacultyName;
        private System.Windows.Forms.Label FacultyDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SectionSelectionComboBox;
    }
}