using l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    public partial class FormViewGrades : Form
    {
        public FormViewGrades()
        {
            InitializeComponent();
            LoadGrades();
        }

        private void LoadGrades()
        {
            dgvGrades.Columns.Clear();
            dgvGrades.Rows.Clear();

            // Create columns
            dgvGrades.Columns.Add("StudentName", "Student Name");
            dgvGrades.Columns.Add("Subject", "Subject");
            dgvGrades.Columns.Add("Grade", "Grade");

            string filePath = Path.Combine(
                Application.StartupPath,
                "grades.txt"
            );

            // If file does not exist
            if (!File.Exists(filePath))
            {
                MessageBox.Show("No grade data found.",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split('|');

                if (parts.Length == 3)
                {
                    dgvGrades.Rows.Add(
                        parts[0], // Student Name
                        parts[1], // Subject
                        parts[2]  // Grade
                    );
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = "StudentGradeReport.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PdfExportHelper.ExportDataGridViewToPdf(
                    dgvGrades,
                    sfd.FileName,
                    "Student Grade Report"
                );

                MessageBox.Show("PDF exported successfully.");
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FormUsabilityQuestionnaire f = new FormUsabilityQuestionnaire();
            f.ShowDialog();
        }
    }
}
