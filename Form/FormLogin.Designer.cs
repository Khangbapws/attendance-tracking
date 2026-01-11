namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Designer fields

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.MaskedTextBox txtUsername;
        private System.Windows.Forms.GroupBox groupRole;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.RadioButton rbSecretary;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnFeedback;

        // Layout controls for responsive design
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.TableLayoutPanel contentTable;
        private System.Windows.Forms.FlowLayoutPanel flowRoles;
        private System.Windows.Forms.FlowLayoutPanel flowButtons;

        // Accessibility/UX helpers
        private System.Windows.Forms.ToolTip toolTip;

        #endregion

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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.MaskedTextBox();
            this.groupRole = new System.Windows.Forms.GroupBox();
            this.flowRoles = new System.Windows.Forms.FlowLayoutPanel();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.rbSecretary = new System.Windows.Forms.RadioButton();
            this.flowButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBackground.SuspendLayout();
            this.mainTable.SuspendLayout();
            this.contentTable.SuspendLayout();
            this.groupRole.SuspendLayout();
            this.flowRoles.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackgroundImage = global::l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Properties.Resources.bg_main;
            this.pnlBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBackground.Controls.Add(this.mainTable);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1168, 752);
            this.pnlBackground.TabIndex = 0;
            // 
            // mainTable
            // 
            this.mainTable.BackColor = System.Drawing.Color.Transparent;
            this.mainTable.ColumnCount = 1;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Controls.Add(this.lblTitle, 0, 0);
            this.mainTable.Controls.Add(this.contentTable, 0, 1);
            this.mainTable.Controls.Add(this.groupRole, 0, 2);
            this.mainTable.Controls.Add(this.flowButtons, 0, 3);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 0);
            this.mainTable.Margin = new System.Windows.Forms.Padding(24);
            this.mainTable.Name = "mainTable";
            this.mainTable.Padding = new System.Windows.Forms.Padding(40);
            this.mainTable.RowCount = 4;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(1168, 752);
            this.mainTable.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(48, 48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1072, 76);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Electronic Gradebook";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // contentTable
            // 
            this.contentTable.AutoSize = true;
            this.contentTable.ColumnCount = 2;
            this.contentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.contentTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentTable.Controls.Add(this.lblUsername, 0, 0);
            this.contentTable.Controls.Add(this.txtUsername, 1, 0);
            this.contentTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentTable.Location = new System.Drawing.Point(40, 132);
            this.contentTable.Margin = new System.Windows.Forms.Padding(0);
            this.contentTable.Name = "contentTable";
            this.contentTable.RowCount = 1;
            this.contentTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.contentTable.Size = new System.Drawing.Size(1088, 71);
            this.contentTable.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(8, 16);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(8, 16, 24, 16);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 39);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip.SetToolTip(this.lblUsername, "Enter your username or ID here.");
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.AccessibleDescription = "Type your username. This field accepts text input.";
            this.txtUsername.AccessibleName = "Username";
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(184, 13);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(896, 45);
            this.txtUsername.TabIndex = 0;
            this.toolTip.SetToolTip(this.txtUsername, "Type your username and press Enter or Tab to move to the role selection.");
            this.txtUsername.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtUsername_MaskInputRejected);
            // 
            // groupRole
            // 
            this.groupRole.AccessibleDescription = "Choose whether you are a Teacher or Secretary.";
            this.groupRole.AccessibleName = "Role selection";
            this.groupRole.AutoSize = true;
            this.groupRole.Controls.Add(this.flowRoles);
            this.groupRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupRole.Location = new System.Drawing.Point(40, 211);
            this.groupRole.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.groupRole.Name = "groupRole";
            this.groupRole.Padding = new System.Windows.Forms.Padding(16);
            this.groupRole.Size = new System.Drawing.Size(1088, 145);
            this.groupRole.TabIndex = 1;
            this.groupRole.TabStop = false;
            this.groupRole.Text = "Select role";
            this.groupRole.Enter += new System.EventHandler(this.groupRole_Enter);
            // 
            // flowRoles
            // 
            this.flowRoles.AutoSize = true;
            this.flowRoles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowRoles.Controls.Add(this.rbTeacher);
            this.flowRoles.Controls.Add(this.rbSecretary);
            this.flowRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowRoles.Location = new System.Drawing.Point(16, 54);
            this.flowRoles.Margin = new System.Windows.Forms.Padding(0);
            this.flowRoles.Name = "flowRoles";
            this.flowRoles.Padding = new System.Windows.Forms.Padding(8);
            this.flowRoles.Size = new System.Drawing.Size(1056, 75);
            this.flowRoles.TabIndex = 1;
            // 
            // rbTeacher
            // 
            this.rbTeacher.AccessibleDescription = "Select this if you are a teacher.";
            this.rbTeacher.AccessibleName = "Teacher role";
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbTeacher.Location = new System.Drawing.Point(20, 16);
            this.rbTeacher.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(160, 43);
            this.rbTeacher.TabIndex = 1;
            this.rbTeacher.TabStop = true;
            this.rbTeacher.Text = "Teacher";
            this.rbTeacher.UseVisualStyleBackColor = true;
            this.rbTeacher.CheckedChanged += new System.EventHandler(this.rbTeacher_CheckedChanged);
            // 
            // rbSecretary
            // 
            this.rbSecretary.AccessibleDescription = "Select this if you are a secretary.";
            this.rbSecretary.AccessibleName = "Secretary role";
            this.rbSecretary.AutoSize = true;
            this.rbSecretary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbSecretary.Location = new System.Drawing.Point(204, 16);
            this.rbSecretary.Margin = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.rbSecretary.Name = "rbSecretary";
            this.rbSecretary.Size = new System.Drawing.Size(181, 43);
            this.rbSecretary.TabIndex = 2;
            this.rbSecretary.TabStop = true;
            this.rbSecretary.Text = "Secretary";
            this.rbSecretary.UseVisualStyleBackColor = true;
            this.rbSecretary.CheckedChanged += new System.EventHandler(this.rbSecretary_CheckedChanged);
            // 
            // flowButtons
            // 
            this.flowButtons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowButtons.AutoSize = true;
            this.flowButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowButtons.Controls.Add(this.btnLogin);
            this.flowButtons.Controls.Add(this.btnFeedback);
            this.flowButtons.Location = new System.Drawing.Point(388, 507);
            this.flowButtons.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.flowButtons.Name = "flowButtons";
            this.flowButtons.Size = new System.Drawing.Size(392, 77);
            this.flowButtons.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleDescription = "Press to attempt login. Also activated by pressing Enter.";
            this.btnLogin.AccessibleName = "Login";
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.AutoSize = true;
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btnLogin.Location = new System.Drawing.Point(8, 8);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(8);
            this.btnLogin.MinimumSize = new System.Drawing.Size(180, 48);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(6);
            this.btnLogin.Size = new System.Drawing.Size(180, 61);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.toolTip.SetToolTip(this.btnLogin, "Press to log in using the provided credentials.");
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.AccessibleDescription = "Open the feedback dialog or form.";
            this.btnFeedback.AccessibleName = "Feedback";
            this.btnFeedback.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFeedback.AutoSize = true;
            this.btnFeedback.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFeedback.Location = new System.Drawing.Point(204, 8);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(8);
            this.btnFeedback.MinimumSize = new System.Drawing.Size(180, 48);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Padding = new System.Windows.Forms.Padding(6);
            this.btnFeedback.Size = new System.Drawing.Size(180, 61);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ShowAlways = true;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1168, 752);
            this.Controls.Add(this.pnlBackground);
            this.Font = new System.Drawing.Font("Times New Roman", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 420);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Resize += new System.EventHandler(this.FormLogin_Resize);
            this.pnlBackground.ResumeLayout(false);
            this.mainTable.ResumeLayout(false);
            this.mainTable.PerformLayout();
            this.contentTable.ResumeLayout(false);
            this.contentTable.PerformLayout();
            this.groupRole.ResumeLayout(false);
            this.groupRole.PerformLayout();
            this.flowRoles.ResumeLayout(false);
            this.flowRoles.PerformLayout();
            this.flowButtons.ResumeLayout(false);
            this.flowButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
