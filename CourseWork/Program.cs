using System.Diagnostics;
using System.Text.Json;
using Excel = Microsoft.Office.Interop.Excel;
using Application = System.Windows.Forms.Application;
using Microsoft.Office.Interop.Excel;

namespace CourseWork
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            /*Excel.Application app = new Excel.Application();
            app.Visible = true;

           Workbook wb = app.Workbooks.Add();
            Worksheet ws = wb.Worksheets["sheet1"];
            ws.Range["A1"].Value2 = "sales";
            wb.Close();*/

            ApplicationConfiguration.Initialize();
            Application.Run(new StorageForm());
        }
    }
}