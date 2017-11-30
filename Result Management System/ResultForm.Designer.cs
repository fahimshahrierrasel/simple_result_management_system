namespace Result_Management_System
{
    partial class ResultForm
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
            this.StudentIdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.Label();
            this.DepartmentName = new System.Windows.Forms.Label();
            this.DepartmentLabel = new System.Windows.Forms.Label();
            this.ResultView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentIdTextBox
            // 
            this.StudentIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentIdTextBox.Location = new System.Drawing.Point(116, 24);
            this.StudentIdTextBox.Name = "StudentIdTextBox";
            this.StudentIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.StudentIdTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(231, 24);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(41, 69);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 16);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(123, 69);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(93, 16);
            this.StudentName.TabIndex = 4;
            this.StudentName.Text = "Student Name";
            // 
            // DepartmentName
            // 
            this.DepartmentName.AutoSize = true;
            this.DepartmentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentName.Location = new System.Drawing.Point(123, 101);
            this.DepartmentName.Name = "DepartmentName";
            this.DepartmentName.Size = new System.Drawing.Size(118, 16);
            this.DepartmentName.TabIndex = 6;
            this.DepartmentName.Text = "Department Name";
            // 
            // DepartmentLabel
            // 
            this.DepartmentLabel.AutoSize = true;
            this.DepartmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentLabel.Location = new System.Drawing.Point(41, 101);
            this.DepartmentLabel.Name = "DepartmentLabel";
            this.DepartmentLabel.Size = new System.Drawing.Size(78, 16);
            this.DepartmentLabel.TabIndex = 5;
            this.DepartmentLabel.Text = "Department";
            // 
            // ResultView
            // 
            this.ResultView.AllowUserToAddRows = false;
            this.ResultView.AllowUserToDeleteRows = false;
            this.ResultView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultView.Location = new System.Drawing.Point(12, 134);
            this.ResultView.Name = "ResultView";
            this.ResultView.ReadOnly = true;
            this.ResultView.Size = new System.Drawing.Size(329, 150);
            this.ResultView.TabIndex = 7;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 296);
            this.Controls.Add(this.ResultView);
            this.Controls.Add(this.DepartmentName);
            this.Controls.Add(this.DepartmentLabel);
            this.Controls.Add(this.StudentName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentIdTextBox);
            this.Name = "ResultForm";
            this.Text = "Student Result";
            ((System.ComponentModel.ISupportInitialize)(this.ResultView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentIdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label DepartmentName;
        private System.Windows.Forms.Label DepartmentLabel;
        private System.Windows.Forms.DataGridView ResultView;
    }
}