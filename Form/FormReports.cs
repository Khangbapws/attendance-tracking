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

        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();

        public FormReports()
        {
            this.AutoScaleMode = AutoScaleMode.None; // Turn off WinForms auto-scaling
            this.AutoScaleDimensions = new SizeF(96F, 96F); //Lock DPI

            InitializeComponent();
            InitializeGrid();

            btnExportPdf.Enabled = false;
        }

        private void FormReports_Load(object sender, EventArgs e)
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

        private void FormReports_Resize(object sender, EventArgs e)
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

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FormUsabilityQuestionnaire f = new FormUsabilityQuestionnaire();
            f.ShowDialog();
        }

        
    }
}
