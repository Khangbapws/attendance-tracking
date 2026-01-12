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
    public partial class FormUsabilityQuestionnaire : Form
    {
        private Size originalFormSize;
        private Dictionary<Control, Rectangle> controlBounds = new Dictionary<Control, Rectangle>();

        private readonly string filePath;
        public FormUsabilityQuestionnaire()
        {
            this.AutoScaleMode = AutoScaleMode.None; // Turn off WinForms auto-scaling
            this.AutoScaleDimensions = new SizeF(96F, 96F); //Lock DPI

            InitializeComponent();
            InitializeComboBoxes();
            
            filePath = AppPaths.FeedbackFile;
            btnSubmit.Enabled = false;
        }

        private void FormUsabilityQuestionnaire_Load(object sender, EventArgs e)
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

        private void FormUsabilityQuestionnaire_Resize(object sender, EventArgs e)
        {
            float xRAtio = (float)this.Width / originalFormSize.Width;
            float yRatio = (float)this.Height / originalFormSize.Height;

            ResizeControls(this, xRAtio, yRatio);

        }
        private void ResizeControls(Control parent, float xRAtio, float yRatio)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!controlBounds.ContainsKey(ctrl))
                    continue;
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

                cbo.SelectedIndexChanged -= cbo_SelectedIndexChanged;
                cbo.SelectedIndexChanged += cbo_SelectedIndexChanged;
            }
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
            try
            {

                string folder = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
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
            catch (Exception ex)
            {
                MessageBox.Show("Unable to save feedback: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = AllQuestionsAnswered();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
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
    }
}
