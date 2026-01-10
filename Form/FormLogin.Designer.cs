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
            this.btnFeedback = new System.Windows.Forms.Button();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(97, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(502, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electronic Gradebook";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(108, 669);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(389, 126);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(108, 231);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(866, 45);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // groupRole
            // 
            this.groupRole.Location = new System.Drawing.Point(108, 396);
            this.groupRole.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupRole.Name = "groupRole";
            this.groupRole.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupRole.Size = new System.Drawing.Size(930, 230);
            this.groupRole.TabIndex = 4;
            this.groupRole.TabStop = false;
            this.groupRole.Text = "Select role";
            this.groupRole.Enter += new System.EventHandler(this.groupRole_Enter);
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Location = new System.Drawing.Point(566, 445);
            this.rbTeacher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(160, 43);
            this.rbTeacher.TabIndex = 5;
            this.rbTeacher.TabStop = true;
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            this.rbTeacher.CheckedChanged += new System.EventHandler(this.rbTeacher_CheckedChanged);
            // 
            // rbSecretary
            // 
            this.rbSecretary.AutoSize = true;
            this.rbSecretary.Location = new System.Drawing.Point(566, 522);
            this.rbSecretary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbSecretary.Name = "rbSecretary";
            this.rbSecretary.Size = new System.Drawing.Size(181, 43);
            this.rbSecretary.TabIndex = 6;
            this.rbSecretary.TabStop = true;
            this.rbSecretary.Text = "Secretary";
            this.rbSecretary.UseVisualStyleBackColor = true;
            this.rbSecretary.CheckedChanged += new System.EventHandler(this.rbSecretary_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(101, 140);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 39);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(590, 669);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(305, 126);
            this.btnFeedback.TabIndex = 8;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Properties.Resources.bg_main;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.lblUsername);
            this.pnlBackground.Controls.Add(this.btnFeedback);
            this.pnlBackground.Controls.Add(this.groupRole);
            this.pnlBackground.Controls.Add(this.btnLogin);
            this.pnlBackground.Controls.Add(this.txtUsername);
            this.pnlBackground.Controls.Add(this.lblTitle);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1413, 901);
            this.pnlBackground.TabIndex = 9;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 901);
            this.Controls.Add(this.rbSecretary);
            this.Controls.Add(this.rbTeacher);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
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
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Panel pnlBackground;
    }
}

