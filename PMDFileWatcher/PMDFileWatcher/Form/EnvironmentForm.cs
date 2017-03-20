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
    public partial class EnvironmentForm : System.Windows.Forms.Form
    {
        public event EventHandler LoadedSettings;

        public void LoadSettings()
        {
            LoadedSettings?.Invoke(this, EventArgs.Empty);
        }

        public EnvironmentForm()
        {
            InitializeComponent();

            LoadedSettings += new EventHandler(EnvironmentForm_Load);
        }

        private void EnvironmentForm_Load(object sender, EventArgs e)
        {
            msdosCheckBox.Checked = Properties.Settings.Default.MSDOSEnable;
            msdosReferenceTextBox.Text = Properties.Settings.Default.MSDOSPath;
            mcReferenceTextBox.Text = Properties.Settings.Default.MCPath;
            mcOptionTextBox.Text = Properties.Settings.Default.MCOption;
            autoPlayCheckBox.Checked = Properties.Settings.Default.AutoPlay;
            playerReferenceTextBox.Text = Properties.Settings.Default.PlayerPath;
        }

        private void msdosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                msdosCaptionLabel.Enabled = true;
                msdosReferenceTextBox.Enabled = true;
                msdosReferenceButton.Enabled = true;
            }
            else if (cb.Checked == false)
            {
                msdosCaptionLabel.Enabled = false;
                msdosReferenceTextBox.Enabled = false;
                msdosReferenceButton.Enabled = false;
            }
            Properties.Settings.Default.MSDOSEnable = cb.Checked;
        }

        private void msdosReferenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "MS-DOS Playerを選択";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                msdosReferenceTextBox.Text = ofd.FileName;
                Properties.Settings.Default.MSDOSPath = ofd.FileName;
            }
        }

        private void mcReferenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "MMLコンパイラを選択";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                mcReferenceTextBox.Text = ofd.FileName;
                Properties.Settings.Default.MCPath = ofd.FileName;
            }
        }

        private void autoPlayCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked == true)
            {
                playerCaptionLabel.Enabled = true;
                playerReferenceTextBox.Enabled = true;
                playerReferenceButton.Enabled = true;
            }
            else if (cb.Checked == false)
            {
                playerCaptionLabel.Enabled = false;
                playerReferenceTextBox.Enabled = false;
                playerReferenceButton.Enabled = false;
            }
            Properties.Settings.Default.AutoPlay = cb.Checked;
        }

        private void playerReferenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "プレーヤを選択";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                playerReferenceTextBox.Text = ofd.FileName;
                Properties.Settings.Default.PlayerPath = ofd.FileName;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MCOption = mcOptionTextBox.Text;
            Properties.Settings.Default.Save();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            Close();
        }

        private void initializeButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            LoadSettings();
        }
    }
}
