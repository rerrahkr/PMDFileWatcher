using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMDFileWatcher.Form
{
    public partial class SettingsForm : System.Windows.Forms.Form
    {
        public event InitializeButtonClickEventHandler InitializeButtonClick;

        private Settings settings;

        public SettingsForm(Settings settings)
        {
            InitializeComponent();

            this.settings = settings;
        }

        public void OnInitializeButtonClick(Settings settings)
        {
            var args = new InitializeButtonClickEventArgs();
            args.Settings = settings;
            InitializeButtonClick?.Invoke(this, args);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            msdosCheckBox.Checked = settings.MSDOSEnable;
            msdosReferenceTextBox.Text = settings.MSDOSPath;
            mcReferenceTextBox.Text = settings.MCPath;
            mcOptionTextBox.Text = settings.MCOption;
            resultFormComboBox.SelectedIndex = settings.ResultForm;
            soundNotifyCheckBox.Checked = settings.SoundNotification;
            autoPlayCheckBox.Checked = settings.AutoPlay;
            playerReferenceTextBox.Text = settings.PlayerPath;
        }

        private void msdosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                msdosReferenceTextBox.Enabled = true;
                msdosReferenceButton.Enabled = true;
            }
            else
            {
                msdosReferenceTextBox.Enabled = false;
                msdosReferenceButton.Enabled = false;
            }
        }

        private void msdosReferenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select MS-DOS Player";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                msdosReferenceTextBox.Text = ofd.FileName;
            }
        }

        private void mcReferenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select MC";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mcReferenceTextBox.Text = ofd.FileName;
            }
        }

        private void autoPlayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked)
            {
                playerCaptionLabel.Enabled = true;
                playerReferenceTextBox.Enabled = true;
                playerReferenceButton.Enabled = true;
            }
            else
            {
                playerCaptionLabel.Enabled = false;
                playerReferenceTextBox.Enabled = false;
                playerReferenceButton.Enabled = false;
            }
        }

        private void playerReferenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Player";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                playerReferenceTextBox.Text = ofd.FileName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            settings.MSDOSEnable = msdosCheckBox.Checked;
            settings.MSDOSPath = msdosReferenceTextBox.Text;
            settings.MCPath = mcReferenceTextBox.Text;
            settings.MCOption = mcOptionTextBox.Text;
            settings.ResultForm = resultFormComboBox.SelectedIndex;
            settings.SoundNotification = soundNotifyCheckBox.Checked;
            settings.AutoPlay = autoPlayCheckBox.Checked;
            settings.PlayerPath = playerReferenceTextBox.Text;

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            settings = new Settings();
            OnLoad(EventArgs.Empty);
            OnInitializeButtonClick(settings);
        }
    }

    public class InitializeButtonClickEventArgs : EventArgs
    {
        public Settings Settings { get; set; }
    }

    public delegate void InitializeButtonClickEventHandler(object sender, InitializeButtonClickEventArgs e);
}
