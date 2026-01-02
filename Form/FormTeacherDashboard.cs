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
    public partial class FormTeacherDashboard : Form
    {
        private FormLogin loginForm;
        public FormTeacherDashboard(FormLogin login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void btnEnterGrades_Click(object sender, EventArgs e)
        {
            FormEnterGrades f = new FormEnterGrades();
            f.ShowDialog();
        }

        private void btnViewGrades_Click(object sender, EventArgs e)
        {
            FormViewGrades f = new FormViewGrades();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
