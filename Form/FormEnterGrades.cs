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
    public partial class FormEnterGrades : Form
    {
        private readonly string gradesFilePath;

        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();
        public FormEnterGrades()
        {
            this.AutoScaleMode = AutoScaleMode.None; // Turn off WinForms auto-scaling
            this.AutoScaleDimensions = new SizeF(96F, 96F); //Lock DPI

            InitializeComponent();

            gradesFilePath = AppPaths.GradesFile;
        }

        private void FormEnterGrades_Load(object sender, EventArgs e)
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

        private void FormEnterGrades_Resize(object sender, EventArgs e)
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            string subject = txtSubject.Text.Trim();
            string gradeText = txtGrade.Text.Trim();

            if(studentName == ""|| subject == "" ||  gradeText == "")
            {
                MessageBox.Show("Please fill in all fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(gradeText, out double grade))
            {
                MessageBox.Show("Grade must be a numeric value.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (grade < 0 || grade > 10)
            {
                MessageBox.Show("Grade must be between 0 and 10.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            SaveGradeToFile(studentName, subject, grade);

            MessageBox.Show("Grade saved successfully!",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SaveGradeToFile(string studentName, string subject, double grade)
        {
            string line = $"{studentName}|{subject}|{grade}";

            using (StreamWriter sw = new StreamWriter(gradesFilePath, true))
            {
                sw.WriteLine(line);
            }
        }
        private void ClearFields()
        {
            txtStudentName.Clear();
            txtSubject.Clear();
            txtGrade.Clear();
            txtStudentName.Focus();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FormUsabilityQuestionnaire f = new FormUsabilityQuestionnaire();
            f.ShowDialog();
        }

      
    }
}
