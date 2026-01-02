using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
          //rbTeacher.Checked = true;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show(
                    "Please enter username.",
                    "Login error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                return;
            }
            if (rbTeacher.Checked)
            {
                FormTeacherDashboard teacherForm = new FormTeacherDashboard(this);
                teacherForm.Show();
                this.Hide();
            }
            else if (rbSecretary.Checked)
            {
                FormSecretaryDashboard secretaryForm = new FormSecretaryDashboard(this);
                secretaryForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(
                   "Please select a role.",
                   "Login error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupRole_Enter(object sender, EventArgs e)
        {

        }

        private void rbSecretary_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbTeacher_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
