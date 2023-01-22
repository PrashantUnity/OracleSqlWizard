﻿using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace OracleSqlWizard
{
    public partial class LogInWindow : Form
    {
        public readonly string storeExcelPath = "storeExcelPath";
        public LogInWindow()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Worksheets 2003(*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                    //File.Create(Directory.GetCurrentDirectory()+ $"\\{storeExcelPath}.txt");

                    File.WriteAllText(Directory.GetCurrentDirectory() + $"\\{storeExcelPath}.txt", filePath);
                    //Read the contents of the file into a stream
                    ExcelPath.Text = filePath;
                    excelData.Text = FillRichTextBox(filePath);
                }
            }

        }

        public string FillRichTextBox(string filePath)
        {
            var sb = new StringBuilder();

            long rowCount = 0;
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        try
                        {

                            sb.Append(string.Format(
                                "{0,-15} {1,-15} {2,-15} {3,-15}{4,-15}{5,-15}{6,-15}\n\n",
                                (reader.GetValue(0)).ToString().Trim() + "\t",
                                (reader.GetValue(1)).ToString().Trim() + "\t",
                                (reader.GetValue(2)).ToString().Trim() + "\t",
                                (reader.GetValue(3)).ToString().Trim() + "\t",
                                (reader.GetValue(4)).ToString().Trim() + "\t",
                                $"'{(reader.GetValue(5)).ToString().Trim()}'" + "\t",
                                 (reader.GetValue(6)).ToString().Trim() + "\t"
                            ));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Something is Wrong With Excel Data or {e.Message}");
                        }
                        rowCount++;
                    }
                    sb.Append("\n");
                }
            }
            return sb.ToString();
        }
    }
}
