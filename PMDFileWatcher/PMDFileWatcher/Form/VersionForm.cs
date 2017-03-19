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
            applicationNameLabel.Text = Application.ProductName;
            versionLabel.Text = "Version " + Application.ProductVersion;
            System.Reflection.AssemblyCopyrightAttribute aca =
                (System.Reflection.AssemblyCopyrightAttribute)
                Attribute.GetCustomAttribute(
                    System.Reflection.Assembly.GetExecutingAssembly(),
                    typeof(System.Reflection.AssemblyCopyrightAttribute));
            copyrightLabel.Text = aca.Copyright;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
