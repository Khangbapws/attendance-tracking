using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l11_danh_mục_điện_tử_để_chấm_điểm_học_sinh_14_12_2025.Helpers
{
    public static class PdfExportHelper
    {
        public static void ExportDataGridViewToPdf(
            DataGridView dgv,
            string filePath,
            string titleText)
        {
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            //Font
            BaseFont baseFont = BaseFont.CreateFont(
                BaseFont.TIMES_ROMAN,
                BaseFont.CP1252,
                BaseFont.NOT_EMBEDDED);

            Font titleFont = new Font(baseFont, 16, Font.BOLD);
            Font headerFont = new Font(baseFont, 12, Font.BOLD);
            Font cellFont = new Font(baseFont, 11, Font.NORMAL);
            Font subTitleFont = new Font(baseFont, 11, Font.ITALIC);

            //Title
            Paragraph title = new Paragraph(titleText, titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            title.SpacingAfter = 20f;
            document.Add(title);

            //University Name
            Paragraph university = new Paragraph("Universitatea Petrol-Gaze din Ploiești",subTitleFont);
            university.Alignment = Element.ALIGN_CENTER;
            document.Add(university);

            //Date
            Paragraph date = new Paragraph("Generated on: " + System.DateTime.Now.ToString("dd/MM/yyyy"),subTitleFont);
            date.Alignment = Element.ALIGN_CENTER;
            date.SpacingAfter = 20f;
            document.Add(date);

            //Table
            PdfPTable table = new PdfPTable(dgv.Columns.Count);
            table.WidthPercentage = 100;

            // Header
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

            // Rows
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Phrase(
                        cell.Value?.ToString() ?? "",
                        cellFont));
                }
            }

            document.Add(table);
            document.Close();
        }
    }
}
