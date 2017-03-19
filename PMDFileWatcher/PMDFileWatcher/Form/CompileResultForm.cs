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
    public partial class CompileResultForm : System.Windows.Forms.Form
    {
        private CompileResult cr;

        public CompileResultForm()
        {
            InitializeComponent();
        }

        public void SetResult(CompileResult cr)
        {
            this.cr = cr;
            resultTextBox.Text = cr.ToString();
            resultTextBox.SelectionStart = resultTextBox.Text.Length;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
