using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Excel = Microsoft.Office.Interop.Excel;

namespace CourseWork
{
    internal class ExcelSheet
    {
        string filePath = "";
        Excel.Application excel;
        Workbook workbook;
        Worksheet worksheet;


        public ExcelSheet(string path, int sheetN = 0)
        {
            excel = new Excel.Application();
            filePath = path;

            this.workbook = excel.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
            worksheet = workbook.Worksheets["sheet1"];
            worksheet.StandardWidth = 25;
            worksheet.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            worksheet.Cells.VerticalAlignment = XlVAlign.xlVAlignTop;

            SaveAs(filePath);
        }

        public void OpenFile()
        {
            this.workbook = excel.Workbooks.Open(Directory.GetCurrentDirectory() + "\\" + filePath, Excel.XlFileFormat.xlOpenXMLWorkbook);
            worksheet = workbook.Worksheets["sheet1"];
        }
        public string ReadCell(int i, int j)
        {
            string? value = worksheet.Cells[i + 1, j + 1].Value;
            return value ??= "";
        }

        public void WriteToCell(int i, int j, string s)
        {
            worksheet.Cells[i + 1,j + 1].Value = s;
        }

        public void PaintCell(int i, int j, Color c)
        {
            worksheet.Cells[i + 1, j + 1].Interior.Color = c;
        }

        public void SetColumnWidth(int column, double width)
        {
            worksheet.Columns[column].ColumnWidth = width;
        }

        public void MergeRange(string range)
        {
            worksheet.Range[range].Merge();
        }

        public void SetBorder(string range, Color c)
        {
            worksheet.Range[range].Borders.Color = c;
        }

        public void Save() => workbook.Save();
        public void SaveAs(string path)
        {
            workbook.SaveAs(Directory.GetCurrentDirectory() + "\\" + path, Excel.XlFileFormat.xlOpenXMLWorkbook);
        }
        public void Close()
        {
            excel.Visible = false;
            workbook.Close();

        }

        public void Show() => excel.Visible = true;
        public void Hide() => excel.Visible = false;
    }
}
