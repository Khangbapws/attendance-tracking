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
    public partial class FormUsabilityQuestionnaire : Form
    {
        string filePath = "usability_feedback.txt";
        public FormUsabilityQuestionnaire()
        {
            InitializeComponent();
            InitializeComboBoxes();

            btnSubmit.Enabled = false;
        }
        private void InitializeComboBoxes()
        {
            ComboBox[] combos =
            {
                comboBox1, comboBox2, comboBox3, comboBox4,
                comboBox5, comboBox6, comboBox7, comboBox8
            };

            foreach (ComboBox cbo in combos)
            {
                cbo.DropDownStyle = ComboBoxStyle.DropDownList;
                cbo.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
                cbo.SelectedIndex = 2; // Default = Neutral (3)
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!AllQuestionsAnswered())
            {
                MessageBox.Show("Please answer all questions.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            SaveFeedback();
            MessageBox.Show("Thank you for your feedback!");

            this.Close();
        }
        private bool AllQuestionsAnswered()
        {
            ComboBox[] combos =
            {
                comboBox1, comboBox2, comboBox3, comboBox4,
                comboBox5, comboBox6, comboBox7, comboBox8
            };

            foreach (ComboBox cbo in combos)
            {
                if (cbo.SelectedItem == null)
                    return false;
            }

            return true;
        }
        private void SaveFeedback()
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(
                    $"Q1={comboBox1.SelectedItem}|" +
                    $"Q2={comboBox2.SelectedItem}|" +
                    $"Q3={comboBox3.SelectedItem}|" +
                    $"Q4={comboBox4.SelectedItem}|" +
                    $"Q5={comboBox5.SelectedItem}|" +
                    $"Q6={comboBox6.SelectedItem}|" +
                    $"Q7={comboBox7.SelectedItem}|" +
                    $"Q8={comboBox8.SelectedItem}"
                );

                sw.WriteLine("Feedback=" + txtFeedback.Text);
                sw.WriteLine("Date=" + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                sw.WriteLine("--------------------------------------");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = AllQuestionsAnswered();
        }
    }
}
