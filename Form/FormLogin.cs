using l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Helpers;
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
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();

        public FormLogin()
        {
            this.AutoScaleMode = AutoScaleMode.None; // Turn off WinForms auto-scaling
            this.AutoScaleDimensions = new SizeF(96F, 96F); //Lock DPI
            InitializeComponent();
            //rbTeacher.Checked = true;  
        }

        private void FormLogin_Load(object sender, EventArgs e)
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
        private void FormLogin_Resize(object sender, EventArgs e)
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

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FormUsabilityQuestionnaire f = new FormUsabilityQuestionnaire();
            f.ShowDialog();
        }

      
    }
}
