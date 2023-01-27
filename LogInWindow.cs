using ExcelDataReader; 
using System.Text;
using System.Threading;

namespace OracleSqlWizard
{
    public partial class LogInWindow : Form
    {
        public readonly string storeExcelPath = "storeExcelPath";
        bool enable = false;
        bool browse = false;
        string excelPath = "";
        public LogInWindow()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
            timer1.Enabled = false;
        }
        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
            timer1.Enabled = false;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            ExcelPath.Text = files[0];
            excelPath = files[0];
            ConstantsClass.ExcelFilePath = excelPath;
            timer1.Enabled = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            browse = true;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Worksheets 2003(*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string? filePath = openFileDialog.FileName;
                    ExcelPath.Text = filePath;
                    excelPath = filePath;
                    ConstantsClass.ExcelFilePath = filePath; 
                }
            }
            EnableButton();
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

        private void ExportAll_Click(object sender, EventArgs e)
        {

        }

        private void ExportLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog(); 
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                SaveLocation.Text = folderPath;
                ConstantsClass.SaveFileLocation = folderPath;
            }
            enable = true;
            EnableButton();
        }
        private void EnableButton()
        {
            if(enable && browse) 
            {
                ConstantsClass.EnableExecuteButton = true;
                ExportDataBase.Enabled = true;
                timer1.Enabled = true;
            }
        }

        private async void ExportDataBase_Click(object sender, EventArgs e)
        {
            LogsData.Text = "";
            try
            {
                var execute = new Executioner();
                execute.Execute(ConstantsClass.ExcelFilePath);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = ConstantsClass.TotalLine;
                timer1.Enabled = true;
            }
            catch
            {
                string message = "Please Select Xcel File?";
                string title = "Invalid Path";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            
        }

        private void  timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = ConstantsClass.ReadingLine;
            
            LogsData.Text = "\n" + ConstantsClass.LogText ;
            Sleep();
        }

        private async void  Sleep()
        {
            await Task.Run(() => Thread.Sleep(3000));
        }
    }
}
