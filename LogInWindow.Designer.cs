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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWindow));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.ExportAll = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ExportDataBase = new System.Windows.Forms.Button();
            this.SaveLocation = new System.Windows.Forms.TextBox();
            this.ExportLocation = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ExcelPath = new System.Windows.Forms.TextBox();
            this.LogsDatas = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainTab.SuspendLayout();
            this.ExportAll.SuspendLayout();
            this.LogsDatas.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.AllowDrop = true;
            this.MainTab.Controls.Add(this.ExportAll);
            this.MainTab.Controls.Add(this.LogsDatas);
            this.MainTab.Controls.Add(this.tabPage2);
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Margin = new System.Windows.Forms.Padding(0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(738, 403);
            this.MainTab.TabIndex = 0;
            // 
            // ExportAll
            // 
            this.ExportAll.AllowDrop = true;
            this.ExportAll.BackColor = System.Drawing.Color.White;
            this.ExportAll.Controls.Add(this.progressBar1);
            this.ExportAll.Controls.Add(this.button1);
            this.ExportAll.Controls.Add(this.textBox2);
            this.ExportAll.Controls.Add(this.textBox1);
            this.ExportAll.Controls.Add(this.ExportDataBase);
            this.ExportAll.Controls.Add(this.SaveLocation);
            this.ExportAll.Controls.Add(this.ExportLocation);
            this.ExportAll.Controls.Add(this.BrowseButton);
            this.ExportAll.Controls.Add(this.ExcelPath);
            this.ExportAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportAll.Location = new System.Drawing.Point(4, 24);
            this.ExportAll.Name = "ExportAll";
            this.ExportAll.Padding = new System.Windows.Forms.Padding(3);
            this.ExportAll.Size = new System.Drawing.Size(730, 375);
            this.ExportAll.TabIndex = 0;
            this.ExportAll.Text = "Export";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(658, 47);
            this.progressBar1.TabIndex = 102;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(536, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 70);
            this.button1.TabIndex = 101;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(33, 145);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 49);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Download Target File Location";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(33, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 49);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Upload Source File Location";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExportDataBase
            // 
            this.ExportDataBase.BackColor = System.Drawing.Color.LightGray;
            this.ExportDataBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportDataBase.Enabled = false;
            this.ExportDataBase.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExportDataBase.Location = new System.Drawing.Point(50, 298);
            this.ExportDataBase.Name = "ExportDataBase";
            this.ExportDataBase.Size = new System.Drawing.Size(182, 70);
            this.ExportDataBase.TabIndex = 4;
            this.ExportDataBase.Text = "Export";
            this.ExportDataBase.UseVisualStyleBackColor = false;
            this.ExportDataBase.Click += new System.EventHandler(this.ExportDataBase_Click);
            // 
            // SaveLocation
            // 
            this.SaveLocation.BackColor = System.Drawing.SystemColors.Info;
            this.SaveLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SaveLocation.Location = new System.Drawing.Point(376, 145);
            this.SaveLocation.Multiline = true;
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.ReadOnly = true;
            this.SaveLocation.Size = new System.Drawing.Size(332, 49);
            this.SaveLocation.TabIndex = 3;
            this.SaveLocation.Text = "Target File Path";
            this.SaveLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExportLocation
            // 
            this.ExportLocation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ExportLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExportLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportLocation.Location = new System.Drawing.Point(249, 145);
            this.ExportLocation.Name = "ExportLocation";
            this.ExportLocation.Size = new System.Drawing.Size(121, 49);
            this.ExportLocation.TabIndex = 2;
            this.ExportLocation.Text = "Browse";
            this.ExportLocation.UseVisualStyleBackColor = false;
            this.ExportLocation.Click += new System.EventHandler(this.ExportLocation_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.AllowDrop = true;
            this.BrowseButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BrowseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseButton.Location = new System.Drawing.Point(249, 44);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(121, 49);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ExcelPath
            // 
            this.ExcelPath.BackColor = System.Drawing.SystemColors.Info;
            this.ExcelPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExcelPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExcelPath.Location = new System.Drawing.Point(376, 44);
            this.ExcelPath.Multiline = true;
            this.ExcelPath.Name = "ExcelPath";
            this.ExcelPath.ReadOnly = true;
            this.ExcelPath.Size = new System.Drawing.Size(332, 49);
            this.ExcelPath.TabIndex = 0;
            this.ExcelPath.Text = "Source File Path";
            this.ExcelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogsDatas
            // 
            this.LogsDatas.BackColor = System.Drawing.Color.Black;
            this.LogsDatas.Controls.Add(this.richTextBox1);
            this.LogsDatas.Location = new System.Drawing.Point(4, 24);
            this.LogsDatas.Name = "LogsDatas";
            this.LogsDatas.Size = new System.Drawing.Size(730, 375);
            this.LogsDatas.TabIndex = 2;
            this.LogsDatas.Text = "Logs";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(734, 375);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.CausesValidation = false;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(730, 375);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OracleSqlWizard.Properties.Resources.Logo2;
            this.pictureBox1.Image = global::OracleSqlWizard.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(93, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 118);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(484, 322);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(161, 29);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Oracle MetaBackup";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(93, 185);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(552, 97);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // LogInWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(738, 404);
            this.Controls.Add(this.MainTab);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "LogInWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oracle MetaBackup";
            this.MainTab.ResumeLayout(false);
            this.ExportAll.ResumeLayout(false);
            this.ExportAll.PerformLayout();
            this.LogsDatas.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage ExportAll;
        private Button BrowseButton;
        private TextBox ExcelPath;
        private FolderBrowserDialog folderBrowser;
        private TabPage LogsDatas;
        private Button ExportDataBase;
        private TextBox SaveLocation;
        private Button ExportLocation;
        public System.Windows.Forms.Timer timer1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TabPage tabPage2;
        private PictureBox pictureBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label1;
        private Button button1;
        private RichTextBox richTextBox1;
        private ProgressBar progressBar1;
    }
}