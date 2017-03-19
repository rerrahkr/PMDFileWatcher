namespace PMDFileWatcher.Form
{
    partial class EnvironmentForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compileTabPage = new System.Windows.Forms.TabPage();
            this.mcGroupBox = new System.Windows.Forms.GroupBox();
            this.mcReferenceTextBox = new System.Windows.Forms.TextBox();
            this.mcOptionTextBox = new System.Windows.Forms.TextBox();
            this.mcOptionLabel = new System.Windows.Forms.Label();
            this.mcReferenceButton = new System.Windows.Forms.Button();
            this.msdosGroupBox = new System.Windows.Forms.GroupBox();
            this.msdosReferenceTextBox = new System.Windows.Forms.TextBox();
            this.msdosReferenceButton = new System.Windows.Forms.Button();
            this.playTabPage = new System.Windows.Forms.TabPage();
            this.playEnableGroupBox = new System.Windows.Forms.GroupBox();
            this.playerReferenceTextBox = new System.Windows.Forms.TextBox();
            this.playerCaptionLabel = new System.Windows.Forms.Label();
            this.playerReferenceButton = new System.Windows.Forms.Button();
            this.autoPlayCheckBox = new System.Windows.Forms.CheckBox();
            this.initializeButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.compileTabPage.SuspendLayout();
            this.mcGroupBox.SuspendLayout();
            this.msdosGroupBox.SuspendLayout();
            this.playTabPage.SuspendLayout();
            this.playEnableGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(116, 207);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "保存";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(197, 207);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.compileTabPage);
            this.tabControl.Controls.Add(this.playTabPage);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(259, 188);
            this.tabControl.TabIndex = 2;
            // 
            // compileTabPage
            // 
            this.compileTabPage.Controls.Add(this.mcGroupBox);
            this.compileTabPage.Controls.Add(this.msdosGroupBox);
            this.compileTabPage.Location = new System.Drawing.Point(4, 22);
            this.compileTabPage.Name = "compileTabPage";
            this.compileTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.compileTabPage.Size = new System.Drawing.Size(251, 162);
            this.compileTabPage.TabIndex = 0;
            this.compileTabPage.Text = "コンパイル";
            this.compileTabPage.UseVisualStyleBackColor = true;
            // 
            // mcGroupBox
            // 
            this.mcGroupBox.Controls.Add(this.mcReferenceTextBox);
            this.mcGroupBox.Controls.Add(this.mcOptionTextBox);
            this.mcGroupBox.Controls.Add(this.mcOptionLabel);
            this.mcGroupBox.Controls.Add(this.mcReferenceButton);
            this.mcGroupBox.Location = new System.Drawing.Point(6, 67);
            this.mcGroupBox.Name = "mcGroupBox";
            this.mcGroupBox.Size = new System.Drawing.Size(239, 91);
            this.mcGroupBox.TabIndex = 1;
            this.mcGroupBox.TabStop = false;
            this.mcGroupBox.Text = "MC";
            // 
            // mcReferenceTextBox
            // 
            this.mcReferenceTextBox.Location = new System.Drawing.Point(6, 20);
            this.mcReferenceTextBox.Name = "mcReferenceTextBox";
            this.mcReferenceTextBox.ReadOnly = true;
            this.mcReferenceTextBox.Size = new System.Drawing.Size(191, 19);
            this.mcReferenceTextBox.TabIndex = 4;
            // 
            // mcOptionTextBox
            // 
            this.mcOptionTextBox.Location = new System.Drawing.Point(6, 66);
            this.mcOptionTextBox.Name = "mcOptionTextBox";
            this.mcOptionTextBox.Size = new System.Drawing.Size(227, 19);
            this.mcOptionTextBox.TabIndex = 3;
            // 
            // mcOptionLabel
            // 
            this.mcOptionLabel.AutoSize = true;
            this.mcOptionLabel.Location = new System.Drawing.Point(6, 51);
            this.mcOptionLabel.Name = "mcOptionLabel";
            this.mcOptionLabel.Size = new System.Drawing.Size(96, 12);
            this.mcOptionLabel.TabIndex = 2;
            this.mcOptionLabel.Text = "コンパイルオプション:";
            // 
            // mcReferenceButton
            // 
            this.mcReferenceButton.Location = new System.Drawing.Point(203, 18);
            this.mcReferenceButton.Name = "mcReferenceButton";
            this.mcReferenceButton.Size = new System.Drawing.Size(30, 23);
            this.mcReferenceButton.TabIndex = 1;
            this.mcReferenceButton.Text = "...";
            this.mcReferenceButton.UseVisualStyleBackColor = true;
            this.mcReferenceButton.Click += new System.EventHandler(this.mcReferenceButton_Click);
            // 
            // msdosGroupBox
            // 
            this.msdosGroupBox.Controls.Add(this.msdosReferenceTextBox);
            this.msdosGroupBox.Controls.Add(this.msdosReferenceButton);
            this.msdosGroupBox.Location = new System.Drawing.Point(6, 6);
            this.msdosGroupBox.Name = "msdosGroupBox";
            this.msdosGroupBox.Size = new System.Drawing.Size(239, 55);
            this.msdosGroupBox.TabIndex = 0;
            this.msdosGroupBox.TabStop = false;
            this.msdosGroupBox.Text = "MS-DOS Converter";
            // 
            // msdosReferenceTextBox
            // 
            this.msdosReferenceTextBox.Location = new System.Drawing.Point(6, 20);
            this.msdosReferenceTextBox.Name = "msdosReferenceTextBox";
            this.msdosReferenceTextBox.ReadOnly = true;
            this.msdosReferenceTextBox.Size = new System.Drawing.Size(191, 19);
            this.msdosReferenceTextBox.TabIndex = 2;
            // 
            // msdosReferenceButton
            // 
            this.msdosReferenceButton.Location = new System.Drawing.Point(203, 18);
            this.msdosReferenceButton.Name = "msdosReferenceButton";
            this.msdosReferenceButton.Size = new System.Drawing.Size(30, 23);
            this.msdosReferenceButton.TabIndex = 1;
            this.msdosReferenceButton.Text = "...";
            this.msdosReferenceButton.UseVisualStyleBackColor = true;
            this.msdosReferenceButton.Click += new System.EventHandler(this.msdosReferenceButton_Click);
            // 
            // playTabPage
            // 
            this.playTabPage.Controls.Add(this.playEnableGroupBox);
            this.playTabPage.Location = new System.Drawing.Point(4, 22);
            this.playTabPage.Name = "playTabPage";
            this.playTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playTabPage.Size = new System.Drawing.Size(251, 162);
            this.playTabPage.TabIndex = 1;
            this.playTabPage.Text = "演奏";
            this.playTabPage.UseVisualStyleBackColor = true;
            // 
            // playEnableGroupBox
            // 
            this.playEnableGroupBox.Controls.Add(this.playerReferenceTextBox);
            this.playEnableGroupBox.Controls.Add(this.playerCaptionLabel);
            this.playEnableGroupBox.Controls.Add(this.playerReferenceButton);
            this.playEnableGroupBox.Controls.Add(this.autoPlayCheckBox);
            this.playEnableGroupBox.Location = new System.Drawing.Point(6, 6);
            this.playEnableGroupBox.Name = "playEnableGroupBox";
            this.playEnableGroupBox.Size = new System.Drawing.Size(242, 95);
            this.playEnableGroupBox.TabIndex = 0;
            this.playEnableGroupBox.TabStop = false;
            this.playEnableGroupBox.Text = "自動演奏";
            // 
            // playerReferenceTextBox
            // 
            this.playerReferenceTextBox.Location = new System.Drawing.Point(6, 68);
            this.playerReferenceTextBox.Name = "playerReferenceTextBox";
            this.playerReferenceTextBox.ReadOnly = true;
            this.playerReferenceTextBox.Size = new System.Drawing.Size(194, 19);
            this.playerReferenceTextBox.TabIndex = 5;
            // 
            // playerCaptionLabel
            // 
            this.playerCaptionLabel.AutoSize = true;
            this.playerCaptionLabel.Location = new System.Drawing.Point(9, 49);
            this.playerCaptionLabel.Name = "playerCaptionLabel";
            this.playerCaptionLabel.Size = new System.Drawing.Size(76, 12);
            this.playerCaptionLabel.TabIndex = 4;
            this.playerCaptionLabel.Text = "実行プログラム:";
            // 
            // playerReferenceButton
            // 
            this.playerReferenceButton.Location = new System.Drawing.Point(206, 66);
            this.playerReferenceButton.Name = "playerReferenceButton";
            this.playerReferenceButton.Size = new System.Drawing.Size(30, 23);
            this.playerReferenceButton.TabIndex = 3;
            this.playerReferenceButton.Text = "...";
            this.playerReferenceButton.UseVisualStyleBackColor = true;
            this.playerReferenceButton.Click += new System.EventHandler(this.playerReferenceButton_Click);
            // 
            // autoPlayCheckBox
            // 
            this.autoPlayCheckBox.AutoSize = true;
            this.autoPlayCheckBox.Checked = true;
            this.autoPlayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoPlayCheckBox.Location = new System.Drawing.Point(7, 19);
            this.autoPlayCheckBox.Name = "autoPlayCheckBox";
            this.autoPlayCheckBox.Size = new System.Drawing.Size(191, 16);
            this.autoPlayCheckBox.TabIndex = 0;
            this.autoPlayCheckBox.Text = "コンパイル成功後、自動で演奏する";
            this.autoPlayCheckBox.UseVisualStyleBackColor = true;
            this.autoPlayCheckBox.CheckedChanged += new System.EventHandler(this.autoPlayCheckBox_CheckedChanged);
            // 
            // initializeButton
            // 
            this.initializeButton.Location = new System.Drawing.Point(12, 207);
            this.initializeButton.Name = "initializeButton";
            this.initializeButton.Size = new System.Drawing.Size(75, 23);
            this.initializeButton.TabIndex = 3;
            this.initializeButton.Text = "初期値";
            this.initializeButton.UseVisualStyleBackColor = true;
            this.initializeButton.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // EnvironmentForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 242);
            this.Controls.Add(this.initializeButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EnvironmentForm";
            this.ShowInTaskbar = false;
            this.Text = "環境設定";
            this.Load += new System.EventHandler(this.EnvironmentForm_Load);
            this.tabControl.ResumeLayout(false);
            this.compileTabPage.ResumeLayout(false);
            this.mcGroupBox.ResumeLayout(false);
            this.mcGroupBox.PerformLayout();
            this.msdosGroupBox.ResumeLayout(false);
            this.msdosGroupBox.PerformLayout();
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
    }
}