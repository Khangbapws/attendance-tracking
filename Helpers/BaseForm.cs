using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Helpers
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Font = new Font("Times New Roman", 10);
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
