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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInWindow));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.ExportAll = new System.Windows.Forms.TabPage();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ExcelPath = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.TabPage();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.excelData = new System.Windows.Forms.RichTextBox();
            this.MainTab.SuspendLayout();
            this.ExportAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.ExportAll);
            this.MainTab.Controls.Add(this.Status);
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Margin = new System.Windows.Forms.Padding(0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1280, 681);
            this.MainTab.TabIndex = 0;
            // 
            // ExportAll
            // 
            this.ExportAll.Controls.Add(this.excelData);
            this.ExportAll.Controls.Add(this.BrowseButton);
            this.ExportAll.Controls.Add(this.ExcelPath);
            this.ExportAll.Location = new System.Drawing.Point(4, 24);
            this.ExportAll.Name = "ExportAll";
            this.ExportAll.Padding = new System.Windows.Forms.Padding(3);
            this.ExportAll.Size = new System.Drawing.Size(1272, 653);
            this.ExportAll.TabIndex = 0;
            this.ExportAll.Text = "Export Window";
            this.ExportAll.UseVisualStyleBackColor = true;
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BrowseButton.Location = new System.Drawing.Point(1061, 7);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(176, 61);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse Excel File";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ExcelPath
            // 
            this.ExcelPath.BackColor = System.Drawing.SystemColors.Info;
            this.ExcelPath.Location = new System.Drawing.Point(28, 7);
            this.ExcelPath.Multiline = true;
            this.ExcelPath.Name = "ExcelPath";
            this.ExcelPath.ReadOnly = true;
            this.ExcelPath.Size = new System.Drawing.Size(951, 61);
            this.ExcelPath.TabIndex = 0;
            this.ExcelPath.Text = "Path Of Excel File";
            this.ExcelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(4, 24);
            this.Status.Name = "Status";
            this.Status.Padding = new System.Windows.Forms.Padding(3);
            this.Status.Size = new System.Drawing.Size(1272, 653);
            this.Status.TabIndex = 1;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // excelData
            // 
            this.excelData.Location = new System.Drawing.Point(28, 100);
            this.excelData.Name = "excelData";
            this.excelData.Size = new System.Drawing.Size(1209, 545);
            this.excelData.TabIndex = 2;
            this.excelData.Text = "";
            // 
            // LogInWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInWindow";
            this.Text = "Oracle Wizard";
            this.MainTab.ResumeLayout(false);
            this.ExportAll.ResumeLayout(false);
            this.ExportAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl MainTab;
        private TabPage ExportAll;
        private TabPage Status;
        private Button BrowseButton;
        private TextBox ExcelPath;
        private FolderBrowserDialog folderBrowser;
        private RichTextBox excelData;
    }
}