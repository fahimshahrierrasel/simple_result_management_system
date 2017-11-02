namespace Result_Management_System
{
    partial class FacultyRegistration
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
            this.label4 = new System.Windows.Forms.Label();
            this.FacultyName = new System.Windows.Forms.TextBox();
            this.FacultyInitial = new System.Windows.Forms.TextBox();
            this.FacultyDepartment = new System.Windows.Forms.ComboBox();
            this.FacultyRegisterButton = new System.Windows.Forms.Button();
            this.FacultyRegistraionCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Registration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Initial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Department";
            // 
            // FacultyName
            // 
            this.FacultyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyName.Location = new System.Drawing.Point(113, 66);
            this.FacultyName.Name = "FacultyName";
            this.FacultyName.Size = new System.Drawing.Size(281, 26);
            this.FacultyName.TabIndex = 4;
            // 
            // FacultyInitial
            // 
            this.FacultyInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyInitial.Location = new System.Drawing.Point(113, 101);
            this.FacultyInitial.Name = "FacultyInitial";
            this.FacultyInitial.Size = new System.Drawing.Size(281, 26);
            this.FacultyInitial.TabIndex = 5;
            // 
            // FacultyDepartment
            // 
            this.FacultyDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyDepartment.FormattingEnabled = true;
            this.FacultyDepartment.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "BBA",
            "PHAR",
            "ECO"});
            this.FacultyDepartment.Location = new System.Drawing.Point(113, 136);
            this.FacultyDepartment.Name = "FacultyDepartment";
            this.FacultyDepartment.Size = new System.Drawing.Size(281, 28);
            this.FacultyDepartment.TabIndex = 6;
            // 
            // FacultyRegisterButton
            // 
            this.FacultyRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyRegisterButton.Location = new System.Drawing.Point(324, 186);
            this.FacultyRegisterButton.Name = "FacultyRegisterButton";
            this.FacultyRegisterButton.Size = new System.Drawing.Size(80, 28);
            this.FacultyRegisterButton.TabIndex = 7;
            this.FacultyRegisterButton.Text = "Register";
            this.FacultyRegisterButton.UseVisualStyleBackColor = true;
            this.FacultyRegisterButton.Click += new System.EventHandler(this.FacultyRegisterButton_Click);
            // 
            // FacultyRegistraionCancelButton
            // 
            this.FacultyRegistraionCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyRegistraionCancelButton.Location = new System.Drawing.Point(243, 186);
            this.FacultyRegistraionCancelButton.Name = "FacultyRegistraionCancelButton";
            this.FacultyRegistraionCancelButton.Size = new System.Drawing.Size(80, 28);
            this.FacultyRegistraionCancelButton.TabIndex = 8;
            this.FacultyRegistraionCancelButton.Text = "Cancel";
            this.FacultyRegistraionCancelButton.UseVisualStyleBackColor = true;
            this.FacultyRegistraionCancelButton.Click += new System.EventHandler(this.FacultyRegistraionCancelButton_Click);
            // 
            // FacultyRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 226);
            this.Controls.Add(this.FacultyRegistraionCancelButton);
            this.Controls.Add(this.FacultyRegisterButton);
            this.Controls.Add(this.FacultyDepartment);
            this.Controls.Add(this.FacultyInitial);
            this.Controls.Add(this.FacultyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FacultyRegistration";
            this.Text = "FacultyRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FacultyName;
        private System.Windows.Forms.TextBox FacultyInitial;
        private System.Windows.Forms.ComboBox FacultyDepartment;
        private System.Windows.Forms.Button FacultyRegisterButton;
        private System.Windows.Forms.Button FacultyRegistraionCancelButton;
    }
}