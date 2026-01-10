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
    public partial class FormSecretaryDashboard : Form
    {
        private FormLogin loginForm;
        public FormSecretaryDashboard(FormLogin login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            FormManageStudents f = new FormManageStudents();
            f.ShowDialog();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FormReports f = new FormReports();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            FormUsabilityQuestionnaire f = new FormUsabilityQuestionnaire();    
            f.ShowDialog();
        }
    }
}
