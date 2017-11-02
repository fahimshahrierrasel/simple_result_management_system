namespace Result_Management_System
{
    partial class AddSectionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CourseComboBox = new System.Windows.Forms.ComboBox();
            this.FacultyComboBox = new System.Windows.Forms.ComboBox();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.SubmitSectionButton = new System.Windows.Forms.Button();
            this.CancelAddSectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Section";
            // 
            // CourseComboBox
            // 
            this.CourseComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseComboBox.FormattingEnabled = true;
            this.CourseComboBox.Location = new System.Drawing.Point(87, 15);
            this.CourseComboBox.Name = "CourseComboBox";
            this.CourseComboBox.Size = new System.Drawing.Size(239, 28);
            this.CourseComboBox.TabIndex = 3;
            // 
            // FacultyComboBox
            // 
            this.FacultyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyComboBox.FormattingEnabled = true;
            this.FacultyComboBox.Location = new System.Drawing.Point(87, 52);
            this.FacultyComboBox.Name = "FacultyComboBox";
            this.FacultyComboBox.Size = new System.Drawing.Size(239, 28);
            this.FacultyComboBox.TabIndex = 4;
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionTextBox.Location = new System.Drawing.Point(87, 90);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(239, 26);
            this.SectionTextBox.TabIndex = 5;
            // 
            // SubmitSectionButton
            // 
            this.SubmitSectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitSectionButton.Location = new System.Drawing.Point(257, 136);
            this.SubmitSectionButton.Name = "SubmitSectionButton";
            this.SubmitSectionButton.Size = new System.Drawing.Size(82, 28);
            this.SubmitSectionButton.TabIndex = 6;
            this.SubmitSectionButton.Text = "Submit";
            this.SubmitSectionButton.UseVisualStyleBackColor = true;
            this.SubmitSectionButton.Click += new System.EventHandler(this.SubmitSectionButton_Click);
            // 
            // CancelAddSectionButton
            // 
            this.CancelAddSectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAddSectionButton.Location = new System.Drawing.Point(169, 136);
            this.CancelAddSectionButton.Name = "CancelAddSectionButton";
            this.CancelAddSectionButton.Size = new System.Drawing.Size(82, 28);
            this.CancelAddSectionButton.TabIndex = 7;
            this.CancelAddSectionButton.Text = "Cancel";
            this.CancelAddSectionButton.UseVisualStyleBackColor = true;
            this.CancelAddSectionButton.Click += new System.EventHandler(this.CancelAddSectionButton_Click);
            // 
            // AddSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 176);
            this.Controls.Add(this.CancelAddSectionButton);
            this.Controls.Add(this.SubmitSectionButton);
            this.Controls.Add(this.SectionTextBox);
            this.Controls.Add(this.FacultyComboBox);
            this.Controls.Add(this.CourseComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSectionForm";
            this.Text = "Add Section";
            this.Load += new System.EventHandler(this.AddSectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CourseComboBox;
        private System.Windows.Forms.ComboBox FacultyComboBox;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.Button SubmitSectionButton;
        private System.Windows.Forms.Button CancelAddSectionButton;
    }
}