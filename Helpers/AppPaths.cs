using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Helpers
{
    public static class AppPaths
    {
        public static string DataFolder
        {
            get
            {
                string folder = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "ElectronicGradeBook"
                );
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }

        public static string GradesFile => Path.Combine(DataFolder, "grades.txt");
        public static string StudentsFile => Path.Combine(DataFolder, "students.txt");
        public static string FeedbackFile => Path.Combine(DataFolder, "usability_feedback.txt");
    }
}
