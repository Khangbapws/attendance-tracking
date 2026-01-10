namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    partial class FormTeacherDashboard
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
            this.btnEnterGrades = new System.Windows.Forms.Button();
            this.btnViewGrades = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnterGrades
            // 
            this.btnEnterGrades.Location = new System.Drawing.Point(136, 88);
            this.btnEnterGrades.Name = "btnEnterGrades";
            this.btnEnterGrades.Size = new System.Drawing.Size(285, 93);
            this.btnEnterGrades.TabIndex = 0;
            this.btnEnterGrades.Text = "Enter Grades";
            this.btnEnterGrades.UseVisualStyleBackColor = true;
            this.btnEnterGrades.Click += new System.EventHandler(this.btnEnterGrades_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Location = new System.Drawing.Point(587, 88);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(277, 94);
            this.btnViewGrades.TabIndex = 1;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(347, 373);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(294, 120);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(827, 517);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(170, 79);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // FormTeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 608);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewGrades);
            this.Controls.Add(this.btnEnterGrades);
            this.Name = "FormTeacherDashboard";
            this.Text = "FormTeacherDashBoard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGrades;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedback;
    }
}