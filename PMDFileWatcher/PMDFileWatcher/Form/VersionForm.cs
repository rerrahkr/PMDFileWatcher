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
    public partial class VersionForm : System.Windows.Forms.Form
    {
        public VersionForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            applicationNameLabel.Text = Common.AssemblyTitle;
            versionLabel.Text = "Version " + Common.AssemblyFileVersion;
            copyrightLabel.Text = Common.AssemblyCopyright;
            iconPictureBox.Image = Common.Icon.ToBitmap();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
