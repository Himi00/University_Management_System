namespace University_Management
{
    partial class AdminForm
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
            this.Admin = new System.Windows.Forms.Label();
            this.IbiaWelcome = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.adminInformationToolStripMenuItem = new System.Windows.Forms.Label();
            this.teacherInformationToolStripMenuItem = new System.Windows.Forms.Label();
            this.studentInformationToolStripMenuItem = new System.Windows.Forms.Label();
            this.CourseInformationToolStripMenuItem = new System.Windows.Forms.Label();
            this.SectionInformationToolStripMenuItem = new System.Windows.Forms.Label();
            this.metroPanel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admin.Location = new System.Drawing.Point(23, 17);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(128, 25);
            this.Admin.TabIndex = 0;
            this.Admin.Text = "Admin Form";
            // 
            // IbiaWelcome
            // 
            this.IbiaWelcome.AutoSize = true;
            this.IbiaWelcome.Location = new System.Drawing.Point(524, 24);
            this.IbiaWelcome.Name = "IbiaWelcome";
            this.IbiaWelcome.Size = new System.Drawing.Size(66, 17);
            this.IbiaWelcome.TabIndex = 1;
            this.IbiaWelcome.Text = "Welcome";
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(944, 17);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(109, 38);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            // 
            // adminInformationToolStripMenuItem
            // 
            this.adminInformationToolStripMenuItem.AutoSize = true;
            this.adminInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminInformationToolStripMenuItem.Location = new System.Drawing.Point(36, 99);
            this.adminInformationToolStripMenuItem.Name = "adminInformationToolStripMenuItem";
            this.adminInformationToolStripMenuItem.Size = new System.Drawing.Size(138, 17);
            this.adminInformationToolStripMenuItem.TabIndex = 3;
            this.adminInformationToolStripMenuItem.Text = "Admin Information";
            // 
            // teacherInformationToolStripMenuItem
            // 
            this.teacherInformationToolStripMenuItem.AutoSize = true;
            this.teacherInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherInformationToolStripMenuItem.Location = new System.Drawing.Point(237, 99);
            this.teacherInformationToolStripMenuItem.Name = "teacherInformationToolStripMenuItem";
            this.teacherInformationToolStripMenuItem.Size = new System.Drawing.Size(154, 17);
            this.teacherInformationToolStripMenuItem.TabIndex = 4;
            this.teacherInformationToolStripMenuItem.Text = "Teacher Information";
            // 
            // studentInformationToolStripMenuItem
            // 
            this.studentInformationToolStripMenuItem.AutoSize = true;
            this.studentInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentInformationToolStripMenuItem.Location = new System.Drawing.Point(464, 99);
            this.studentInformationToolStripMenuItem.Name = "studentInformationToolStripMenuItem";
            this.studentInformationToolStripMenuItem.Size = new System.Drawing.Size(150, 17);
            this.studentInformationToolStripMenuItem.TabIndex = 5;
            this.studentInformationToolStripMenuItem.Text = "Student Information";
            // 
            // CourseInformationToolStripMenuItem
            // 
            this.CourseInformationToolStripMenuItem.AutoSize = true;
            this.CourseInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseInformationToolStripMenuItem.Location = new System.Drawing.Point(680, 99);
            this.CourseInformationToolStripMenuItem.Name = "CourseInformationToolStripMenuItem";
            this.CourseInformationToolStripMenuItem.Size = new System.Drawing.Size(145, 17);
            this.CourseInformationToolStripMenuItem.TabIndex = 6;
            this.CourseInformationToolStripMenuItem.Text = "Course Information";
            // 
            // SectionInformationToolStripMenuItem
            // 
            this.SectionInformationToolStripMenuItem.AutoSize = true;
            this.SectionInformationToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SectionInformationToolStripMenuItem.Location = new System.Drawing.Point(931, 99);
            this.SectionInformationToolStripMenuItem.Name = "SectionInformationToolStripMenuItem";
            this.SectionInformationToolStripMenuItem.Size = new System.Drawing.Size(148, 17);
            this.SectionInformationToolStripMenuItem.TabIndex = 7;
            this.SectionInformationToolStripMenuItem.Text = "Section Information";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Location = new System.Drawing.Point(36, 144);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1054, 358);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 514);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.SectionInformationToolStripMenuItem);
            this.Controls.Add(this.CourseInformationToolStripMenuItem);
            this.Controls.Add(this.studentInformationToolStripMenuItem);
            this.Controls.Add(this.teacherInformationToolStripMenuItem);
            this.Controls.Add(this.adminInformationToolStripMenuItem);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.IbiaWelcome);
            this.Controls.Add(this.Admin);
            this.Name = "AdminForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Label IbiaWelcome;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label adminInformationToolStripMenuItem;
        private System.Windows.Forms.Label teacherInformationToolStripMenuItem;
        private System.Windows.Forms.Label studentInformationToolStripMenuItem;
        private System.Windows.Forms.Label CourseInformationToolStripMenuItem;
        private System.Windows.Forms.Label SectionInformationToolStripMenuItem;
        private System.Windows.Forms.Panel metroPanel1;
    }
}

