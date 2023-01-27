﻿namespace OracleSqlWizard
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
            this.ExportDataBase = new System.Windows.Forms.Button();
            this.SaveLocation = new System.Windows.Forms.TextBox();
            this.ExportLocation = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ExcelPath = new System.Windows.Forms.TextBox();
            this.LogsDatas = new System.Windows.Forms.TabPage();
            this.LogsData = new System.Windows.Forms.RichTextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainTab.SuspendLayout();
            this.ExportAll.SuspendLayout();
            this.LogsDatas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.AllowDrop = true;
            this.MainTab.Controls.Add(this.ExportAll);
            this.MainTab.Controls.Add(this.LogsDatas);
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Margin = new System.Windows.Forms.Padding(0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(636, 285);
            this.MainTab.TabIndex = 0;
            // 
            // ExportAll
            // 
            this.ExportAll.AllowDrop = true;
            this.ExportAll.BackColor = System.Drawing.Color.Black;
            this.ExportAll.Controls.Add(this.progressBar1);
            this.ExportAll.Controls.Add(this.ExportDataBase);
            this.ExportAll.Controls.Add(this.SaveLocation);
            this.ExportAll.Controls.Add(this.ExportLocation);
            this.ExportAll.Controls.Add(this.BrowseButton);
            this.ExportAll.Controls.Add(this.ExcelPath);
            this.ExportAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExportAll.Location = new System.Drawing.Point(4, 24);
            this.ExportAll.Name = "ExportAll";
            this.ExportAll.Padding = new System.Windows.Forms.Padding(3);
            this.ExportAll.Size = new System.Drawing.Size(628, 257);
            this.ExportAll.TabIndex = 0;
            this.ExportAll.Text = "Export Window";
            this.ExportAll.Click += new System.EventHandler(this.ExportAll_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(72, 144);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(458, 51);
            this.progressBar1.TabIndex = 5;
            // 
            // ExportDataBase
            // 
            this.ExportDataBase.Enabled = false;
            this.ExportDataBase.Location = new System.Drawing.Point(155, 201);
            this.ExportDataBase.Name = "ExportDataBase";
            this.ExportDataBase.Size = new System.Drawing.Size(313, 50);
            this.ExportDataBase.TabIndex = 4;
            this.ExportDataBase.Text = "Export Database";
            this.ExportDataBase.UseVisualStyleBackColor = true;
            this.ExportDataBase.Click += new System.EventHandler(this.ExportDataBase_Click);
            // 
            // SaveLocation
            // 
            this.SaveLocation.BackColor = System.Drawing.SystemColors.Info;
            this.SaveLocation.Location = new System.Drawing.Point(375, 82);
            this.SaveLocation.Multiline = true;
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.ReadOnly = true;
            this.SaveLocation.Size = new System.Drawing.Size(155, 56);
            this.SaveLocation.TabIndex = 3;
            this.SaveLocation.Text = "Export Location";
            // 
            // ExportLocation
            // 
            this.ExportLocation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ExportLocation.Location = new System.Drawing.Point(375, 15);
            this.ExportLocation.Name = "ExportLocation";
            this.ExportLocation.Size = new System.Drawing.Size(155, 61);
            this.ExportLocation.TabIndex = 2;
            this.ExportLocation.Text = "Browse Export Location";
            this.ExportLocation.UseVisualStyleBackColor = false;
            this.ExportLocation.Click += new System.EventHandler(this.ExportLocation_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.AllowDrop = true;
            this.BrowseButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BrowseButton.Location = new System.Drawing.Point(72, 15);
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
            this.ExcelPath.Location = new System.Drawing.Point(72, 82);
            this.ExcelPath.Multiline = true;
            this.ExcelPath.Name = "ExcelPath";
            this.ExcelPath.ReadOnly = true;
            this.ExcelPath.Size = new System.Drawing.Size(176, 56);
            this.ExcelPath.TabIndex = 0;
            this.ExcelPath.Text = "Path Of Excel File";
            this.ExcelPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LogsDatas
            // 
            this.LogsDatas.BackColor = System.Drawing.Color.Black;
            this.LogsDatas.Controls.Add(this.LogsData);
            this.LogsDatas.Location = new System.Drawing.Point(4, 24);
            this.LogsDatas.Name = "LogsDatas";
            this.LogsDatas.Size = new System.Drawing.Size(628, 257);
            this.LogsDatas.TabIndex = 2;
            this.LogsDatas.Text = "Logs";
            // 
            // LogsData
            // 
            this.LogsData.Location = new System.Drawing.Point(3, 3);
            this.LogsData.Name = "LogsData";
            this.LogsData.Size = new System.Drawing.Size(622, 251);
            this.LogsData.TabIndex = 0;
            this.LogsData.Text = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(628, 257);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "How To Use";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(622, 241);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // folderBrowser
            // 
            this.folderBrowser.RootFolder = System.Environment.SpecialFolder.MyDocuments;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LogInWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(645, 294);
            this.Controls.Add(this.MainTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "LogInWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Oracle Wizard";
            this.MainTab.ResumeLayout(false);
            this.ExportAll.ResumeLayout(false);
            this.ExportAll.PerformLayout();
            this.LogsDatas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private TabPage tabPage1;
        private RichTextBox richTextBox1;
    }
}