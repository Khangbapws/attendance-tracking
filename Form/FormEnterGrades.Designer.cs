namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    partial class FormEnterGrades
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(202, 157);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(195, 32);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Name";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(202, 330);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(110, 32);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(202, 495);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(93, 32);
            this.lblGrade.TabIndex = 2;
            this.lblGrade.Text = "Grade";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(455, 157);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(365, 38);
            this.txtStudentName.TabIndex = 3;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(455, 327);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(365, 38);
            this.txtSubject.TabIndex = 4;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(455, 489);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(365, 38);
            this.txtGrade.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(208, 697);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(237, 121);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Grade";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(619, 697);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(242, 121);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1053, 697);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(238, 121);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(1379, 955);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(168, 70);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // FormEnterGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 1037);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblStudentName);
            this.Name = "FormEnterGrades";
            this.Text = "EnterGrades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFeedback;
    }
}