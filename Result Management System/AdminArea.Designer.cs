namespace Result_Management_System
{
    partial class AdminArea
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
            this.FacultyRegistraion = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FacultyRegistraion
            // 
            this.FacultyRegistraion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyRegistraion.Location = new System.Drawing.Point(32, 30);
            this.FacultyRegistraion.Name = "FacultyRegistraion";
            this.FacultyRegistraion.Size = new System.Drawing.Size(275, 42);
            this.FacultyRegistraion.TabIndex = 0;
            this.FacultyRegistraion.Text = "Faculty Registration";
            this.FacultyRegistraion.UseVisualStyleBackColor = true;
            this.FacultyRegistraion.Click += new System.EventHandler(this.FacultyRegistraion_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(32, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Section";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(32, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(275, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Student To Section";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AdminArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 247);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.FacultyRegistraion);
            this.Name = "AdminArea";
            this.Text = "Admin Area";
            this.Load += new System.EventHandler(this.AdminArea_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FacultyRegistraion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}