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
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();

        public FormViewGrades()
        {
            this.AutoScaleMode = AutoScaleMode.None; // Turn off WinForms auto-scaling
            this.AutoScaleDimensions = new SizeF(96F, 96F); //Lock DPI

            InitializeComponent();
            LoadGrades();
        }

        private void FormViewGrades_Load(object sender, EventArgs e)
        {
            originalFormSize = this.Size;
            StoreSontrolBounds(this);

        }
        private void StoreSontrolBounds(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!controlBounds.ContainsKey(ctrl))
                    controlBounds[ctrl] = ctrl.Bounds;
                if (ctrl.HasChildren)
                    StoreSontrolBounds(ctrl);
            }
        }

        private void FormViewGrades_Resize(object sender, EventArgs e)
        {
            float xRAtio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            ResizeControls(this, xRAtio, yRatio);
        }

        private void ResizeControls(Control parent, float xRAtio, float yRatio)
        {
            foreach (Control ctrl in parent.Controls)
            {
                Rectangle original = controlBounds[ctrl];
                ctrl.SetBounds(
                    (int)(original.X * xRAtio),
                    (int)(original.Y * yRatio),
                    (int)(original.Width * xRAtio),
                    (int)(original.Height * yRatio)
                );

                if (ctrl.HasChildren)
                    ResizeControls(ctrl, xRAtio, yRatio);
            }
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
