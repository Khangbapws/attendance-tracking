namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    partial class FormReports
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
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.btnExportPdf = new System.Windows.Forms.Button();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(196, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(377, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "STUDENT GRADE REPORT";
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Location = new System.Drawing.Point(134, 44);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(215, 46);
            this.btnLoadReport.TabIndex = 1;
            this.btnLoadReport.Text = "Load Report";
            this.btnLoadReport.UseVisualStyleBackColor = true;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // btnExportPdf
            // 
            this.btnExportPdf.Location = new System.Drawing.Point(430, 44);
            this.btnExportPdf.Name = "btnExportPdf";
            this.btnExportPdf.Size = new System.Drawing.Size(221, 46);
            this.btnExportPdf.TabIndex = 2;
            this.btnExportPdf.Text = "Export PDF";
            this.btnExportPdf.UseVisualStyleBackColor = true;
            this.btnExportPdf.Click += new System.EventHandler(this.btnExportPdf_Click);
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(12, 96);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            this.dgvGrades.RowHeadersWidth = 102;
            this.dgvGrades.RowTemplate.Height = 40;
            this.dgvGrades.Size = new System.Drawing.Size(776, 264);
            this.dgvGrades.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(107, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(180, 32);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total grades:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(483, 363);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(215, 32);
            this.lblAverage.TabIndex = 5;
            this.lblAverage.Text = "Average grade: ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(333, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 42);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(729, 433);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(170, 79);
            this.btnFeedback.TabIndex = 9;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // FormReports
            // 
            this.AcceptButton = this.btnLoadReport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 524);
            this.Controls.Add(this.btnFeedback);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvGrades);
            this.Controls.Add(this.btnExportPdf);
            this.Controls.Add(this.btnLoadReport);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.Button btnExportPdf;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFeedback;
    }
}