namespace PMDFileWatcher.Form
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compileTabPage = new System.Windows.Forms.TabPage();
            this.msdosGroupBox = new System.Windows.Forms.GroupBox();
            this.msdosCheckBox = new System.Windows.Forms.CheckBox();
            this.msdosReferenceTextBox = new System.Windows.Forms.TextBox();
            this.msdosReferenceButton = new System.Windows.Forms.Button();
            this.mcGroupBox = new System.Windows.Forms.GroupBox();
            this.resultFormComboBox = new System.Windows.Forms.ComboBox();
            this.compileResultLabel = new System.Windows.Forms.Label();
            this.soundNotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.mcReferenceTextBox = new System.Windows.Forms.TextBox();
            this.mcOptionTextBox = new System.Windows.Forms.TextBox();
            this.mcOptionLabel = new System.Windows.Forms.Label();
            this.mcReferenceButton = new System.Windows.Forms.Button();
            this.playTabPage = new System.Windows.Forms.TabPage();
            this.playEnableGroupBox = new System.Windows.Forms.GroupBox();
            this.playerReferenceTextBox = new System.Windows.Forms.TextBox();
            this.playerCaptionLabel = new System.Windows.Forms.Label();
            this.playerReferenceButton = new System.Windows.Forms.Button();
            this.autoPlayCheckBox = new System.Windows.Forms.CheckBox();
            this.initializeButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.compileTabPage.SuspendLayout();
            this.msdosGroupBox.SuspendLayout();
            this.mcGroupBox.SuspendLayout();
            this.playTabPage.SuspendLayout();
            this.playEnableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(116, 263);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 263);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.compileTabPage);
            this.tabControl.Controls.Add(this.playTabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(259, 243);
            this.tabControl.TabIndex = 0;
            // 
            // compileTabPage
            // 
            this.compileTabPage.Controls.Add(this.msdosGroupBox);
            this.compileTabPage.Controls.Add(this.mcGroupBox);
            this.compileTabPage.Location = new System.Drawing.Point(4, 22);
            this.compileTabPage.Name = "compileTabPage";
            this.compileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.compileTabPage.Size = new System.Drawing.Size(251, 217);
            this.compileTabPage.TabIndex = 0;
            this.compileTabPage.Text = "Compile";
            this.compileTabPage.UseVisualStyleBackColor = true;
            // 
            // msdosGroupBox
            // 
            this.msdosGroupBox.Controls.Add(this.msdosCheckBox);
            this.msdosGroupBox.Controls.Add(this.msdosReferenceTextBox);
            this.msdosGroupBox.Controls.Add(this.msdosReferenceButton);
            this.msdosGroupBox.Location = new System.Drawing.Point(3, 153);
            this.msdosGroupBox.Name = "msdosGroupBox";
            this.msdosGroupBox.Size = new System.Drawing.Size(245, 55);
            this.msdosGroupBox.TabIndex = 1;
            this.msdosGroupBox.TabStop = false;
            this.msdosGroupBox.Text = "                         ";
            // 
            // msdosCheckBox
            // 
            this.msdosCheckBox.AutoSize = true;
            this.msdosCheckBox.Location = new System.Drawing.Point(8, 0);
            this.msdosCheckBox.Name = "msdosCheckBox";
            this.msdosCheckBox.Size = new System.Drawing.Size(105, 16);
            this.msdosCheckBox.TabIndex = 6;
            this.msdosCheckBox.Text = "MS-DOS Player";
            this.msdosCheckBox.UseVisualStyleBackColor = true;
            this.msdosCheckBox.CheckedChanged += new System.EventHandler(this.msdosCheckBox_CheckedChanged);
            // 
            // msdosReferenceTextBox
            // 
            this.msdosReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msdosReferenceTextBox.Enabled = false;
            this.msdosReferenceTextBox.Location = new System.Drawing.Point(6, 22);
            this.msdosReferenceTextBox.Name = "msdosReferenceTextBox";
            this.msdosReferenceTextBox.ReadOnly = true;
            this.msdosReferenceTextBox.Size = new System.Drawing.Size(191, 19);
            this.msdosReferenceTextBox.TabIndex = 7;
            // 
            // msdosReferenceButton
            // 
            this.msdosReferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.msdosReferenceButton.Enabled = false;
            this.msdosReferenceButton.Location = new System.Drawing.Point(203, 20);
            this.msdosReferenceButton.Name = "msdosReferenceButton";
            this.msdosReferenceButton.Size = new System.Drawing.Size(30, 23);
            this.msdosReferenceButton.TabIndex = 8;
            this.msdosReferenceButton.Text = "...";
            this.msdosReferenceButton.UseVisualStyleBackColor = true;
            this.msdosReferenceButton.Click += new System.EventHandler(this.msdosReferenceButton_Click);
            // 
            // mcGroupBox
            // 
            this.mcGroupBox.Controls.Add(this.resultFormComboBox);
            this.mcGroupBox.Controls.Add(this.compileResultLabel);
            this.mcGroupBox.Controls.Add(this.soundNotifyCheckBox);
            this.mcGroupBox.Controls.Add(this.mcReferenceTextBox);
            this.mcGroupBox.Controls.Add(this.mcOptionTextBox);
            this.mcGroupBox.Controls.Add(this.mcOptionLabel);
            this.mcGroupBox.Controls.Add(this.mcReferenceButton);
            this.mcGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.mcGroupBox.Location = new System.Drawing.Point(3, 3);
            this.mcGroupBox.Name = "mcGroupBox";
            this.mcGroupBox.Size = new System.Drawing.Size(245, 144);
            this.mcGroupBox.TabIndex = 0;
            this.mcGroupBox.TabStop = false;
            this.mcGroupBox.Text = "MML Compiler";
            // 
            // resultFormComboBox
            // 
            this.resultFormComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultFormComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resultFormComboBox.FormattingEnabled = true;
            this.resultFormComboBox.Items.AddRange(new object[] {
            "Display",
            "Display when compilation failed",
            "Hide"});
            this.resultFormComboBox.Location = new System.Drawing.Point(6, 94);
            this.resultFormComboBox.Name = "resultFormComboBox";
            this.resultFormComboBox.Size = new System.Drawing.Size(236, 20);
            this.resultFormComboBox.TabIndex = 4;
            // 
            // compileResultLabel
            // 
            this.compileResultLabel.AutoSize = true;
            this.compileResultLabel.Location = new System.Drawing.Point(6, 79);
            this.compileResultLabel.Name = "compileResultLabel";
            this.compileResultLabel.Size = new System.Drawing.Size(100, 12);
            this.compileResultLabel.TabIndex = 7;
            this.compileResultLabel.Text = "Compilation result:";
            // 
            // soundNotifyCheckBox
            // 
            this.soundNotifyCheckBox.AutoSize = true;
            this.soundNotifyCheckBox.Checked = true;
            this.soundNotifyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.soundNotifyCheckBox.Location = new System.Drawing.Point(6, 120);
            this.soundNotifyCheckBox.Name = "soundNotifyCheckBox";
            this.soundNotifyCheckBox.Size = new System.Drawing.Size(203, 16);
            this.soundNotifyCheckBox.TabIndex = 5;
            this.soundNotifyCheckBox.Text = "Notify compilation failure by sound";
            this.soundNotifyCheckBox.UseVisualStyleBackColor = true;
            // 
            // mcReferenceTextBox
            // 
            this.mcReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcReferenceTextBox.Location = new System.Drawing.Point(6, 18);
            this.mcReferenceTextBox.Name = "mcReferenceTextBox";
            this.mcReferenceTextBox.ReadOnly = true;
            this.mcReferenceTextBox.Size = new System.Drawing.Size(197, 19);
            this.mcReferenceTextBox.TabIndex = 1;
            // 
            // mcOptionTextBox
            // 
            this.mcOptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mcOptionTextBox.Location = new System.Drawing.Point(6, 57);
            this.mcOptionTextBox.Name = "mcOptionTextBox";
            this.mcOptionTextBox.Size = new System.Drawing.Size(233, 19);
            this.mcOptionTextBox.TabIndex = 3;
            // 
            // mcOptionLabel
            // 
            this.mcOptionLabel.AutoSize = true;
            this.mcOptionLabel.Location = new System.Drawing.Point(6, 42);
            this.mcOptionLabel.Name = "mcOptionLabel";
            this.mcOptionLabel.Size = new System.Drawing.Size(46, 12);
            this.mcOptionLabel.TabIndex = 2;
            this.mcOptionLabel.Text = "Options:";
            // 
            // mcReferenceButton
            // 
            this.mcReferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mcReferenceButton.Location = new System.Drawing.Point(209, 16);
            this.mcReferenceButton.Name = "mcReferenceButton";
            this.mcReferenceButton.Size = new System.Drawing.Size(30, 23);
            this.mcReferenceButton.TabIndex = 2;
            this.mcReferenceButton.Text = "...";
            this.mcReferenceButton.UseVisualStyleBackColor = true;
            this.mcReferenceButton.Click += new System.EventHandler(this.mcReferenceButton_Click);
            // 
            // playTabPage
            // 
            this.playTabPage.Controls.Add(this.playEnableGroupBox);
            this.playTabPage.Location = new System.Drawing.Point(4, 22);
            this.playTabPage.Name = "playTabPage";
            this.playTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playTabPage.Size = new System.Drawing.Size(251, 217);
            this.playTabPage.TabIndex = 1;
            this.playTabPage.Text = "Play";
            this.playTabPage.UseVisualStyleBackColor = true;
            // 
            // playEnableGroupBox
            // 
            this.playEnableGroupBox.Controls.Add(this.playerReferenceTextBox);
            this.playEnableGroupBox.Controls.Add(this.playerCaptionLabel);
            this.playEnableGroupBox.Controls.Add(this.playerReferenceButton);
            this.playEnableGroupBox.Controls.Add(this.autoPlayCheckBox);
            this.playEnableGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.playEnableGroupBox.Location = new System.Drawing.Point(3, 3);
            this.playEnableGroupBox.Name = "playEnableGroupBox";
            this.playEnableGroupBox.Size = new System.Drawing.Size(245, 68);
            this.playEnableGroupBox.TabIndex = 0;
            this.playEnableGroupBox.TabStop = false;
            this.playEnableGroupBox.Text = "                ";
            // 
            // playerReferenceTextBox
            // 
            this.playerReferenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerReferenceTextBox.Location = new System.Drawing.Point(6, 35);
            this.playerReferenceTextBox.Name = "playerReferenceTextBox";
            this.playerReferenceTextBox.ReadOnly = true;
            this.playerReferenceTextBox.Size = new System.Drawing.Size(191, 19);
            this.playerReferenceTextBox.TabIndex = 10;
            // 
            // playerCaptionLabel
            // 
            this.playerCaptionLabel.AutoSize = true;
            this.playerCaptionLabel.Location = new System.Drawing.Point(6, 20);
            this.playerCaptionLabel.Name = "playerCaptionLabel";
            this.playerCaptionLabel.Size = new System.Drawing.Size(39, 12);
            this.playerCaptionLabel.TabIndex = 4;
            this.playerCaptionLabel.Text = "Player:";
            // 
            // playerReferenceButton
            // 
            this.playerReferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerReferenceButton.Location = new System.Drawing.Point(203, 33);
            this.playerReferenceButton.Name = "playerReferenceButton";
            this.playerReferenceButton.Size = new System.Drawing.Size(30, 23);
            this.playerReferenceButton.TabIndex = 11;
            this.playerReferenceButton.Text = "...";
            this.playerReferenceButton.UseVisualStyleBackColor = true;
            this.playerReferenceButton.Click += new System.EventHandler(this.playerReferenceButton_Click);
            // 
            // autoPlayCheckBox
            // 
            this.autoPlayCheckBox.AutoSize = true;
            this.autoPlayCheckBox.Checked = true;
            this.autoPlayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoPlayCheckBox.Location = new System.Drawing.Point(8, 0);
            this.autoPlayCheckBox.Name = "autoPlayCheckBox";
            this.autoPlayCheckBox.Size = new System.Drawing.Size(69, 16);
            this.autoPlayCheckBox.TabIndex = 9;
            this.autoPlayCheckBox.Text = "Autoplay";
            this.autoPlayCheckBox.UseVisualStyleBackColor = true;
            this.autoPlayCheckBox.CheckedChanged += new System.EventHandler(this.autoPlayCheckBox_CheckedChanged);
            // 
            // initializeButton
            // 
            this.initializeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.initializeButton.Location = new System.Drawing.Point(12, 263);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(75, 23);
            this.initializeButton.TabIndex = 12;
            this.initializeButton.Text = "Default";
            this.initializeButton.UseVisualStyleBackColor = true;
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 298);
            this.Controls.Add(this.initializeButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.compileTabPage.ResumeLayout(false);
            this.msdosGroupBox.ResumeLayout(false);
            this.msdosGroupBox.PerformLayout();
            this.mcGroupBox.ResumeLayout(false);
            this.mcGroupBox.PerformLayout();
            this.playTabPage.ResumeLayout(false);
            this.playEnableGroupBox.ResumeLayout(false);
            this.playEnableGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage compileTabPage;
        private System.Windows.Forms.TabPage playTabPage;
        private System.Windows.Forms.GroupBox msdosGroupBox;
        private System.Windows.Forms.Button msdosReferenceButton;
        private System.Windows.Forms.GroupBox playEnableGroupBox;
        private System.Windows.Forms.Label playerCaptionLabel;
        private System.Windows.Forms.Button playerReferenceButton;
        private System.Windows.Forms.CheckBox autoPlayCheckBox;
        private System.Windows.Forms.GroupBox mcGroupBox;
        private System.Windows.Forms.Button mcReferenceButton;
        private System.Windows.Forms.TextBox mcOptionTextBox;
        private System.Windows.Forms.Label mcOptionLabel;
        private System.Windows.Forms.Button initializeButton;
        private System.Windows.Forms.TextBox msdosReferenceTextBox;
        private System.Windows.Forms.TextBox mcReferenceTextBox;
        private System.Windows.Forms.TextBox playerReferenceTextBox;
        private System.Windows.Forms.CheckBox msdosCheckBox;
        private System.Windows.Forms.CheckBox soundNotifyCheckBox;
        private System.Windows.Forms.ComboBox resultFormComboBox;
        private System.Windows.Forms.Label compileResultLabel;
    }
}