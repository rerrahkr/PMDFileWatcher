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
            this.compileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparateMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.environmentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSeparateMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.endMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchStartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchStopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MMLGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.referenceButton = new System.Windows.Forms.Button();
            this.referenceTextBox = new System.Windows.Forms.TextBox();
            this.watchStartButton = new System.Windows.Forms.Button();
            this.watchStopButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.MMLGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.statusStrip.SuspendLayout();
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
            this.compileMenuItem,
            this.fileSeparateMenuItem1,
            this.environmentMenuItem,
            this.fileSeparateMenuItem2,
            this.endMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileMenuItem.Text = "File(&F)";
            // 
            // compileMenuItem
            // 
            this.compileMenuItem.Name = "compileMenuItem";
            this.compileMenuItem.Size = new System.Drawing.Size(139, 22);
            this.compileMenuItem.Text = "Compile(&C)";
            this.compileMenuItem.Click += new System.EventHandler(this.compileMenuItem_Click);
            // 
            // fileSeparateMenuItem1
            // 
            this.fileSeparateMenuItem1.Name = "fileSeparateMenuItem1";
            this.fileSeparateMenuItem1.Size = new System.Drawing.Size(136, 6);
            // 
            // environmentMenuItem
            // 
            this.environmentMenuItem.Name = "environmentMenuItem";
            this.environmentMenuItem.Size = new System.Drawing.Size(139, 22);
            this.environmentMenuItem.Text = "Settings(&E)...";
            this.environmentMenuItem.Click += new System.EventHandler(this.environmentMenuItem_Click);
            // 
            // fileSeparateMenuItem2
            // 
            this.fileSeparateMenuItem2.Name = "fileSeparateMenuItem2";
            this.fileSeparateMenuItem2.Size = new System.Drawing.Size(136, 6);
            // 
            // endMenuItem
            // 
            this.endMenuItem.Name = "endMenuItem";
            this.endMenuItem.Size = new System.Drawing.Size(139, 22);
            this.endMenuItem.Text = "Exit(&X)";
            this.endMenuItem.Click += new System.EventHandler(this.endMenuItem_Click);
            // 
            // watchMenuItem
            // 
            this.watchMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchStartMenuItem,
            this.watchStopMenuItem});
            this.watchMenuItem.Name = "watchMenuItem";
            this.watchMenuItem.Size = new System.Drawing.Size(98, 20);
            this.watchMenuItem.Text = "Monitoring(&M)";
            // 
            // watchStartMenuItem
            // 
            this.watchStartMenuItem.Name = "watchStartMenuItem";
            this.watchStartMenuItem.Size = new System.Drawing.Size(117, 22);
            this.watchStartMenuItem.Text = "Start(&M)";
            this.watchStartMenuItem.Click += new System.EventHandler(this.watchStartButton_Click);
            // 
            // watchStopMenuItem
            // 
            this.watchStopMenuItem.Enabled = false;
            this.watchStopMenuItem.Name = "watchStopMenuItem";
            this.watchStopMenuItem.Size = new System.Drawing.Size(117, 22);
            this.watchStopMenuItem.Text = "Stop(&S)";
            this.watchStopMenuItem.Click += new System.EventHandler(this.watchStopButton_Click);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionMenuItem});
            this.helpMenuItem.Name = "helpMenuItem";
            this.helpMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpMenuItem.Text = "Help(&H)";
            // 
            // versionMenuItem
            // 
            this.versionMenuItem.Name = "versionMenuItem";
            this.versionMenuItem.Size = new System.Drawing.Size(132, 22);
            this.versionMenuItem.Text = "About(&A)...";
            this.versionMenuItem.Click += new System.EventHandler(this.versionMenuItem_Click);
            // 
            // MMLGroupBox
            // 
            this.MMLGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MMLGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.MMLGroupBox.Location = new System.Drawing.Point(12, 27);
            this.MMLGroupBox.Name = "MMLGroupBox";
            this.MMLGroupBox.Size = new System.Drawing.Size(260, 52);
            this.MMLGroupBox.TabIndex = 5;
            this.MMLGroupBox.TabStop = false;
            this.MMLGroupBox.Text = "Target MML";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.referenceButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.referenceTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // referenceButton
            // 
            this.referenceButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.referenceButton.Location = new System.Drawing.Point(221, 5);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(30, 23);
            this.referenceButton.TabIndex = 1;
            this.referenceButton.Text = "...";
            this.referenceButton.UseVisualStyleBackColor = true;
            this.referenceButton.Click += new System.EventHandler(this.referenceButton_Click);
            // 
            // referenceTextBox
            // 
            this.referenceTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.referenceTextBox.Location = new System.Drawing.Point(3, 7);
            this.referenceTextBox.Name = "referenceTextBox";
            this.referenceTextBox.ReadOnly = true;
            this.referenceTextBox.Size = new System.Drawing.Size(212, 19);
            this.referenceTextBox.TabIndex = 2;
            // 
            // watchStartButton
            // 
            this.watchStartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.watchStartButton.Location = new System.Drawing.Point(55, 88);
            this.watchStartButton.Name = "watchStartButton";
            this.watchStartButton.Size = new System.Drawing.Size(75, 23);
            this.watchStartButton.TabIndex = 6;
            this.watchStartButton.Text = "Start";
            this.watchStartButton.UseVisualStyleBackColor = true;
            this.watchStartButton.Click += new System.EventHandler(this.watchStartButton_Click);
            // 
            // watchStopButton
            // 
            this.watchStopButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.watchStopButton.Enabled = false;
            this.watchStopButton.Location = new System.Drawing.Point(155, 88);
            this.watchStopButton.Name = "watchStopButton";
            this.watchStopButton.Size = new System.Drawing.Size(75, 23);
            this.watchStopButton.TabIndex = 7;
            this.watchStopButton.Text = "Stop";
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 119);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Ready";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.statusStrip);
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
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.MMLGroupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripSeparator fileSeparateMenuItem1;
        private System.Windows.Forms.GroupBox MMLGroupBox;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Button watchStartButton;
        private System.Windows.Forms.Button watchStopButton;
        private System.Windows.Forms.ToolStripMenuItem watchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchStartMenuItem;
        private System.Windows.Forms.ToolStripMenuItem watchStopMenuItem;
        private System.Windows.Forms.TextBox referenceTextBox;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.ToolStripMenuItem compileMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileSeparateMenuItem2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

