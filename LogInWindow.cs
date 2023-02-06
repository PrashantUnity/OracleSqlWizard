using ExcelDataReader;
using System.ComponentModel;
using System.Text;

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
            AllowDrop = true;
            DragEnter += new DragEventHandler(Form1_DragEnter);
            DragDrop += new DragEventHandler(Form1_DragDrop);
            timer1.Enabled = false;
            MaximizeBox = false;
            ExportDataBase.BackColor = Color.White;
            button1.Enabled = false;
            ExportDataBase.Enabled = false;
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

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Worksheets 2003(*.xls)|*.xls|Excel Worksheets 2007(*.xlsx)|*.xlsx";
                openFileDialog.FilterIndex = 2;
                

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string? filePath = openFileDialog.FileName;
                    ExcelPath.Text = filePath;
                    excelPath = filePath;
                    ConstantsClass.ExcelFilePath = filePath;
                    browse = true;
                    BrowseButton.BackColor = Color.Green;
                }
            }
            EnableButton();
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
                enable = true;
                ExportLocation.BackColor = Color.Green;
            }

            EnableButton();
        }
        private void EnableButton()
        {
            if (enable && browse)
            {
                ConstantsClass.EnableExecuteButton = true;
                ExportDataBase.Enabled = true;
                timer1.Enabled = true;
                ExportDataBase.BackColor = Color.Green;
            }
        }

        private async void ExportDataBase_Click(object sender, EventArgs e)
        {
            ConstantsClass.IsCancelled = false;
            timer1.Enabled = true;
            await Task.Factory.StartNew(() => Doing()); 
            ExportDataBase.Enabled = false;
        }   
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = ConstantsClass.ReadingLine;
            if (ConstantsClass.TotalLine == ConstantsClass.ReadingLine)
            {
                ExportDataBase.BackColor = Color.Green;
                ExportDataBase.Enabled = true;
                timer1.Enabled = false;
                button1.Enabled =false;
                var fileLocation = ConstantsClass.SaveFileLocation + "\\LogsFiles";
                fileLocation = Directory.CreateDirectory(fileLocation).ToString();
                fileLocation += "\\Log.txt";
                if (!File.Exists(fileLocation))
                    File.Create(fileLocation);
                File.WriteAllTextAsync(fileLocation, ConstantsClass.LogText);
            }
            if (ConstantsClass.TotalLine != ConstantsClass.ReadingLine)
            {
                button1.Enabled = true;
                ExportDataBase.BackColor = Color.Red;
                ExportDataBase.Enabled = false;
            }
            richTextBox1.Text = "\n" + ConstantsClass.LogText;
            
        }

        private void Doing()
        {
            richTextBox1.Text = "";
            try
            {
                timer1.Enabled = true;
                var execute = new Executioner();
                execute.Execute(ConstantsClass.ExcelFilePath);
                progressBar1.Minimum = 0;
                progressBar1.Maximum = ConstantsClass.TotalLine;
                ExportDataBase.BackColor = Color.Red;
            }
            catch
            { 
                ConstantsClass.LogText += "\n \"Some thing went Wrong\"\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstantsClass.IsCancelled = true;
            ConstantsClass.LogText += "\n Export Cancelled Manually\n";
            ExportDataBase.Enabled = true; 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }
    }
}
