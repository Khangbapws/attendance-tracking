namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    partial class FormSecretaryDashboard
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
            this.btnManageStudents = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.Location = new System.Drawing.Point(184, 132);
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(251, 123);
            this.btnManageStudents.TabIndex = 0;
            this.btnManageStudents.Text = "Manage Students";
            this.btnManageStudents.UseVisualStyleBackColor = true;
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(748, 132);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(259, 123);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(494, 430);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(234, 137);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(1105, 629);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(170, 79);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // FormSecretaryDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 720);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnManageStudents);
            this.Name = "FormSecretaryDashboard";
            this.Text = "SecretaryDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageStudents;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedback;
    }
}