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
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnterGrades
            // 
            this.btnEnterGrades.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnterGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterGrades.Location = new System.Drawing.Point(116, 178);
            this.btnEnterGrades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnterGrades.Name = "btnEnterGrades";
            this.btnEnterGrades.Size = new System.Drawing.Size(321, 111);
            this.btnEnterGrades.TabIndex = 0;
            this.btnEnterGrades.Text = "Enter Grades";
            this.btnEnterGrades.UseVisualStyleBackColor = false;
            this.btnEnterGrades.Click += new System.EventHandler(this.btnEnterGrades_Click);
            // 
            // btnViewGrades
            // 
            this.btnViewGrades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewGrades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGrades.Location = new System.Drawing.Point(730, 177);
            this.btnViewGrades.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewGrades.Name = "btnViewGrades";
            this.btnViewGrades.Size = new System.Drawing.Size(312, 112);
            this.btnViewGrades.TabIndex = 1;
            this.btnViewGrades.Text = "View Grades";
            this.btnViewGrades.UseVisualStyleBackColor = true;
            this.btnViewGrades.Click += new System.EventHandler(this.btnViewGrades_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(418, 420);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(331, 143);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Location = new System.Drawing.Point(909, 610);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(191, 94);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Properties.Resources.bg_main;
            this.pnlBackground.Controls.Add(this.label1);
            this.pnlBackground.Controls.Add(this.btnFeedback);
            this.pnlBackground.Controls.Add(this.btnLogout);
            this.pnlBackground.Controls.Add(this.btnViewGrades);
            this.pnlBackground.Controls.Add(this.btnEnterGrades);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Padding = new System.Windows.Forms.Padding(40);
            this.pnlBackground.Size = new System.Drawing.Size(1168, 752);
            this.pnlBackground.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(116, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(926, 90);
            this.label1.TabIndex = 10;
            this.label1.Text = "TEACHER DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTeacherDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 752);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 420);
            this.Name = "FormTeacherDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacherDashBoard";
            this.Load += new System.EventHandler(this.FormTeacherDashboard_Load);
            this.Resize += new System.EventHandler(this.FormTeacherDashboard_Resize);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnterGrades;
        private System.Windows.Forms.Button btnViewGrades;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label label1;
    }
}