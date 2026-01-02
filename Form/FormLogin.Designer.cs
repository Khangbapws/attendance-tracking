namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    partial class FormLogin
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.MaskedTextBox();
            this.groupRole = new System.Windows.Forms.GroupBox();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbSecretary = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(228, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(288, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electronic Gradebook";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(234, 683);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(311, 76);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(234, 254);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(311, 38);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // groupRole
            // 
            this.groupRole.Location = new System.Drawing.Point(234, 355);
            this.groupRole.Name = "groupRole";
            this.groupRole.Size = new System.Drawing.Size(585, 217);
            this.groupRole.TabIndex = 4;
            this.groupRole.TabStop = false;
            this.groupRole.Text = "Select role";
            this.groupRole.Enter += new System.EventHandler(this.groupRole_Enter);
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Location = new System.Drawing.Point(503, 373);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(155, 36);
            this.rbTeacher.TabIndex = 5;
            this.rbTeacher.TabStop = true;
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            this.rbTeacher.CheckedChanged += new System.EventHandler(this.rbTeacher_CheckedChanged);
            // 
            // rbSecretary
            // 
            this.rbSecretary.AutoSize = true;
            this.rbSecretary.Location = new System.Drawing.Point(503, 437);
            this.rbSecretary.Name = "rbSecretary";
            this.rbSecretary.Size = new System.Drawing.Size(172, 36);
            this.rbSecretary.TabIndex = 6;
            this.rbSecretary.TabStop = true;
            this.rbSecretary.Text = "Secretary";
            this.rbSecretary.UseVisualStyleBackColor = true;
            this.rbSecretary.CheckedChanged += new System.EventHandler(this.rbSecretary_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(234, 150);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(144, 32);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 967);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.rbSecretary);
            this.Controls.Add(this.rbTeacher);
            this.Controls.Add(this.groupRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox txtUsername;
        private System.Windows.Forms.GroupBox groupRole;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbSecretary;
        private System.Windows.Forms.Label lblUsername;
    }
}

