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
    public partial class FormReports : Form
    {
        string filePath = "grades.txt";
        public FormReports()
        {
            InitializeComponent();
            InitializeGrid();

            btnExportPdf.Enabled = false;
        }

        private void InitializeGrid()
        {
            dgvGrades.ColumnCount = 3;
            dgvGrades.Columns[0].Name = "Student Name";
            dgvGrades.Columns[1].Name = "Subject";
            dgvGrades.Columns[2].Name = "Grade";
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            LoadGradesAndCalculate();
            btnExportPdf.Enabled = true;
        }

        private void LoadGradesAndCalculate()
        {
            dgvGrades.Rows.Clear();

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Grades file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                MessageBox.Show("No grade data available.");
                return;
            }

            double total = 0;
            int count = 0;

            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length != 3) continue;

                string student = parts[0];
                string subject = parts[1];

                if (!double.TryParse(parts[2], out double grade))
                    continue;

                dgvGrades.Rows.Add(student, subject, grade);

                total += grade;
                count++;
            }

            lblTotal.Text = "Total grades: " + count;

            if (count > 0)
                lblAverage.Text = "Average grade: " + (total / count).ToString("0.00");
            else
                lblAverage.Text = "Average grade: N/A";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
