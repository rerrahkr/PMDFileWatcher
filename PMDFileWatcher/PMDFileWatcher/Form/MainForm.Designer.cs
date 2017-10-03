namespace PMDFileWatcher.Form
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparateMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.endMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMLGroupBox = new System.Windows.Forms.GroupBox();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.referenceButton = new System.Windows.Forms.Button();
            this.watchStartButton = new System.Windows.Forms.Button();
            this.watchStopButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.menuStrip.SuspendLayout();
            this.MMLGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.watchMenuItem,
            this.helpMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(284, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.environmentMenuItem,
            this.fileSeparateMenuItem,
            this.endMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileMenuItem.Text = "ファイル(&F)";
            // 
            // environmentMenuItem
            // 
            this.environmentMenuItem.Name = "environmentMenuItem";
            this.environmentMenuItem.Size = new System.Drawing.Size(145, 22);
            this.environmentMenuItem.Text = "環境設定(&E)...";
            this.environmentMenuItem.Click += new System.EventHandler(this.environmentMenuItem_Click);
            // 
            // fileSeparateMenuItem
            // 
            this.fileSeparateMenuItem.Name = "fileSeparateMenuItem";
            this.fileSeparateMenuItem.Size = new System.Drawing.Size(142, 6);
            // 
            // endMenuItem
            // 
            this.endMenuItem.Name = "endMenuItem";
            this.endMenuItem.Size = new System.Drawing.Size(145, 22);
            this.endMenuItem.Text = "終了(&X)";
            this.endMenuItem.Click += new System.EventHandler(this.endMenuItem_Click);
            // 
            // watchMenuItem
            // 
            this.watchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchStartMenuItem,
            this.watchStopMenuItem});
            this.watchMenuItem.Name = "watchMenuItem";
            this.watchMenuItem.Size = new System.Drawing.Size(62, 20);
            this.watchMenuItem.Text = "監視(&W)";
            // 
            // watchStartMenuItem
            // 
            this.watchStartMenuItem.Name = "watchStartMenuItem";
            this.watchStartMenuItem.Size = new System.Drawing.Size(141, 22);
            this.watchStartMenuItem.Text = "監視開始(&W)";
            this.watchStartMenuItem.Click += new System.EventHandler(this.watchStartButton_Click);
            // 
            // watchStopMenuItem
            // 
            this.watchStopMenuItem.Enabled = false;
            this.watchStopMenuItem.Name = "watchStopMenuItem";
            this.watchStopMenuItem.Size = new System.Drawing.Size(141, 22);
            this.watchStopMenuItem.Text = "監視停止(&S)";
            this.watchStopMenuItem.Click += new System.EventHandler(this.watchStopButton_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpMenuItem.Text = "ヘルプ(&H)";
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(167, 22);
            this.versionMenuItem.Text = "バージョン情報(&A)...";
            this.versionMenuItem.Click += new System.EventHandler(this.versionMenuItem_Click);
            // 
            // MMLGroupBox
            // 
            this.MMLGroupBox.Controls.Add(this.referenceTextBox);
            this.MMLGroupBox.Controls.Add(this.referenceButton);
            this.MMLGroupBox.Location = new System.Drawing.Point(12, 27);
            this.MMLGroupBox.Name = "MMLGroupBox";
            this.MMLGroupBox.Size = new System.Drawing.Size(260, 52);
            this.MMLGroupBox.TabIndex = 5;
            this.MMLGroupBox.TabStop = false;
            this.MMLGroupBox.Text = "監視MMLファイル";
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Location = new System.Drawing.Point(6, 20);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.ReadOnly = true;
            this.referenceTextBox.Size = new System.Drawing.Size(212, 19);
            this.referenceTextBox.TabIndex = 2;
            // 
            // referenceButton
            // 
            this.referenceButton.Location = new System.Drawing.Point(224, 18);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(30, 23);
            this.referenceButton.TabIndex = 1;
            this.referenceButton.Text = "...";
            this.referenceButton.UseVisualStyleBackColor = true;
            this.referenceButton.Click += new System.EventHandler(this.referenceButton_Click);
            // 
            // watchStartButton
            // 
            this.watchStartButton.Location = new System.Drawing.Point(55, 88);
            this.watchStartButton.Name = "watchStartButton";
            this.watchStartButton.Size = new System.Drawing.Size(75, 23);
            this.watchStartButton.TabIndex = 6;
            this.watchStartButton.Text = "監視開始";
            this.watchStartButton.UseVisualStyleBackColor = true;
            this.watchStartButton.Click += new System.EventHandler(this.watchStartButton_Click);
            // 
            // watchStopButton
            // 
            this.watchStopButton.Enabled = false;
            this.watchStopButton.Location = new System.Drawing.Point(155, 88);
            this.watchStopButton.Name = "watchStopButton";
            this.watchStopButton.Size = new System.Drawing.Size(75, 23);
            this.watchStopButton.TabIndex = 7;
            this.watchStopButton.Text = "監視停止";
            this.watchStopButton.UseVisualStyleBackColor = true;
            this.watchStopButton.Click += new System.EventHandler(this.watchStopButton_Click);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 123);
            this.Controls.Add(this.watchStopButton);
            this.Controls.Add(this.watchStartButton);
            this.Controls.Add(this.MMLGroupBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "PMDFileWatcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.MMLGroupBox.ResumeLayout(false);
            this.MMLGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environmentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileSeparateMenuItem;
        private System.Windows.Forms.GroupBox MMLGroupBox;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Button watchStartButton;
        private System.Windows.Forms.Button watchStopButton;
        private System.Windows.Forms.ToolStripMenuItem watchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchStartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchStopMenuItem;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher;
    }
}

