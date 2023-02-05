namespace OracleSqlWizard
{
    partial class LogInWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWindow));
            MainTab = new TabControl();
            ExportAll = new TabPage();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            ExportDataBase = new Button();
            SaveLocation = new TextBox();
            ExportLocation = new Button();
            BrowseButton = new Button();
            ExcelPath = new TextBox();
            LogsDatas = new TabPage();
            LogsData = new RichTextBox();
            tabPage2 = new TabPage();
            pictureBox1 = new PictureBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            folderBrowser = new FolderBrowserDialog();
            timer1 = new System.Windows.Forms.Timer(components);
            MainTab.SuspendLayout();
            ExportAll.SuspendLayout();
            LogsDatas.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MainTab
            // 
            MainTab.AllowDrop = true;
            MainTab.Controls.Add(ExportAll);
            MainTab.Controls.Add(LogsDatas);
            MainTab.Controls.Add(tabPage2);
            MainTab.Location = new Point(0, 0);
            MainTab.Margin = new Padding(0);
            MainTab.Name = "MainTab";
            MainTab.SelectedIndex = 0;
            MainTab.Size = new Size(738, 403);
            MainTab.TabIndex = 0;
            // 
            // ExportAll
            // 
            ExportAll.AllowDrop = true;
            ExportAll.BackColor = Color.Black;
            ExportAll.Controls.Add(textBox2);
            ExportAll.Controls.Add(textBox1);
            ExportAll.Controls.Add(progressBar1);
            ExportAll.Controls.Add(ExportDataBase);
            ExportAll.Controls.Add(SaveLocation);
            ExportAll.Controls.Add(ExportLocation);
            ExportAll.Controls.Add(BrowseButton);
            ExportAll.Controls.Add(ExcelPath);
            ExportAll.ForeColor = SystemColors.ControlText;
            ExportAll.Location = new Point(4, 24);
            ExportAll.Name = "ExportAll";
            ExportAll.Padding = new Padding(3);
            ExportAll.Size = new Size(730, 375);
            ExportAll.TabIndex = 0;
            ExportAll.Text = "Export";
            ExportAll.Click += ExportAll_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Black;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(33, 145);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 49);
            textBox2.TabIndex = 7;
            textBox2.Text = "Download Target File Location";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(33, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 49);
            textBox1.TabIndex = 6;
            textBox1.Text = "Upload Source File Location";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 257);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(470, 70);
            progressBar1.TabIndex = 100;
            // 
            // ExportDataBase
            // 
            ExportDataBase.BackColor = Color.LightGray;
            ExportDataBase.Cursor = Cursors.Hand;
            ExportDataBase.Enabled = false;
            ExportDataBase.Location = new Point(526, 257);
            ExportDataBase.Name = "ExportDataBase";
            ExportDataBase.Size = new Size(182, 70);
            ExportDataBase.TabIndex = 4;
            ExportDataBase.Text = "Export Database";
            ExportDataBase.UseVisualStyleBackColor = false;
            ExportDataBase.Click += ExportDataBase_Click;
            // 
            // SaveLocation
            // 
            SaveLocation.BackColor = SystemColors.Info;
            SaveLocation.BorderStyle = BorderStyle.FixedSingle;
            SaveLocation.Location = new Point(376, 145);
            SaveLocation.Multiline = true;
            SaveLocation.Name = "SaveLocation";
            SaveLocation.ReadOnly = true;
            SaveLocation.Size = new Size(332, 49);
            SaveLocation.TabIndex = 3;
            SaveLocation.Text = "Export Location will appear here  after Browsing";
            // 
            // ExportLocation
            // 
            ExportLocation.BackColor = Color.LightSkyBlue;
            ExportLocation.BackgroundImageLayout = ImageLayout.None;
            ExportLocation.Cursor = Cursors.Hand;
            ExportLocation.Location = new Point(249, 145);
            ExportLocation.Name = "ExportLocation";
            ExportLocation.Size = new Size(121, 49);
            ExportLocation.TabIndex = 2;
            ExportLocation.Text = "Browse";
            ExportLocation.UseVisualStyleBackColor = false;
            ExportLocation.Click += ExportLocation_Click;
            // 
            // BrowseButton
            // 
            BrowseButton.AllowDrop = true;
            BrowseButton.BackColor = Color.LightSkyBlue;
            BrowseButton.Cursor = Cursors.Hand;
            BrowseButton.Location = new Point(249, 44);
            BrowseButton.Name = "BrowseButton";
            BrowseButton.Size = new Size(121, 49);
            BrowseButton.TabIndex = 1;
            BrowseButton.Text = "Browse";
            BrowseButton.UseVisualStyleBackColor = false;
            BrowseButton.Click += BrowseButton_Click;
            // 
            // ExcelPath
            // 
            ExcelPath.BackColor = SystemColors.Info;
            ExcelPath.BorderStyle = BorderStyle.FixedSingle;
            ExcelPath.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ExcelPath.Location = new Point(376, 44);
            ExcelPath.Multiline = true;
            ExcelPath.Name = "ExcelPath";
            ExcelPath.ReadOnly = true;
            ExcelPath.Size = new Size(332, 49);
            ExcelPath.TabIndex = 0;
            ExcelPath.Text = "Path Of Excel File will apper here after  Browsing";
            // 
            // LogsDatas
            // 
            LogsDatas.BackColor = Color.Black;
            LogsDatas.Controls.Add(LogsData);
            LogsDatas.Location = new Point(4, 24);
            LogsDatas.Name = "LogsDatas";
            LogsDatas.Size = new Size(730, 375);
            LogsDatas.TabIndex = 2;
            LogsDatas.Text = "Logs";
            // 
            // LogsData
            // 
            LogsData.Location = new Point(3, 3);
            LogsData.Name = "LogsData";
            LogsData.Size = new Size(724, 367);
            LogsData.TabIndex = 0;
            LogsData.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.CausesValidation = false;
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(730, 375);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "About";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Logo2;
            pictureBox1.Image = Properties.Resources.Logo2;
            pictureBox1.Location = new Point(93, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 118);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(484, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 29);
            textBox4.TabIndex = 3;
            textBox4.Text = "Oracle MetaBackup";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(93, 185);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(552, 97);
            textBox3.TabIndex = 2;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(183, 296);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // folderBrowser
            // 
            folderBrowser.RootFolder = Environment.SpecialFolder.MyDocuments;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // LogInWindow
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(738, 404);
            Controls.Add(MainTab);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(600, 300);
            Name = "LogInWindow";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Oracle MetaBackup";
            MainTab.ResumeLayout(false);
            ExportAll.ResumeLayout(false);
            ExportAll.PerformLayout();
            LogsDatas.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTab;
        private TabPage ExportAll;
        private Button BrowseButton;
        private TextBox ExcelPath;
        private FolderBrowserDialog folderBrowser;
        private TabPage LogsDatas;
        private RichTextBox LogsData;
        private Button ExportDataBase;
        private TextBox SaveLocation;
        private Button ExportLocation;
        private ProgressBar progressBar1;
        public System.Windows.Forms.Timer timer1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label1;
    }
}