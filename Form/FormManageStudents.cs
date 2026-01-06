using iTextSharp.text;
using iTextSharp.text.pdf;
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
    public partial class FormManageStudents : Form
    {
        private string filePath = "students.txt";
        public FormManageStudents()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            dgvStudents.Columns.Clear();
            dgvStudents.Rows.Clear();

            dgvStudents.Columns.Add("StudentId", "Student ID");
            dgvStudents.Columns.Add("StudentName", "Student Name");
            dgvStudents.Columns.Add("Class", "Class");

            if (!File.Exists(filePath))
                return;

            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    dgvStudents.Rows.Add(parts[0], parts[1], parts[2]);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "" || txtStudentName.Text == "" || txtClass.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string record = txtStudentId.Text + "|" +
                            txtStudentName.Text + "|" +
                            txtClass.Text;

            File.AppendAllText(filePath, record + Environment.NewLine);

            LoadStudents();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
                return;

            int index = dgvStudents.CurrentRow.Index;
            string[] lines = File.ReadAllLines(filePath);

            lines[index] = txtStudentId.Text + "|" +
                           txtStudentName.Text + "|" +
                           txtClass.Text;

            File.WriteAllLines(filePath, lines);

            LoadStudents();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
                return;

            int index = dgvStudents.CurrentRow.Index;
            var lines = new System.Collections.Generic.List<string>(File.ReadAllLines(filePath));
            lines.RemoveAt(index);

            File.WriteAllLines(filePath, lines.ToArray());

            LoadStudents();
            ClearInputs();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStudentId.Text = dgvStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtStudentName.Text = dgvStudents.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtClass.Text = dgvStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void ClearInputs()
        {
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtClass.Clear();
        }

        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF Files (*.pdf)|*.pdf";
            sfd.FileName = "StudentList.pdf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                PdfExportHelper.ExportDataGridViewToPdf(
                    dgvStudents,
                    sfd.FileName,
                    "Student List"
                );

                MessageBox.Show("PDF exported successfully.");
            }
        }

    }
}

