using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMDFileWatcher.Form
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private SettingsForm ef;
        private CompileResultForm crf;

        private DateTime prevChangeTime;

        private System.Diagnostics.Process compileProcess;
        private System.Diagnostics.Process playProcess;

        List<string> compileResultTextList;

        private Settings settings;

        public MainForm()
        {
            InitializeComponent();

            settings = Settings.Load();

            ef = new SettingsForm(settings);
            ef.InitializeButtonClick += new InitializeButtonClickEventHandler(EnvironmentForm_InitializeButtonClick);
            crf = null;

            prevChangeTime = DateTime.Now;

            compileProcess = null;
            playProcess = null;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string[] files = Environment.GetCommandLineArgs();
            if (files.Length == 2 && File.Exists(files[1]))
            {
                SetTargetFile(files[1]);
            }
            referenceTextBox.Text = settings.MMLPath;
            referenceTextBox.SelectionStart = referenceTextBox.Text.Length;
        }

        protected override void OnDragEnter(DragEventArgs drgevent)
        {
            base.OnDragEnter(drgevent);

            string[] files = (string[])drgevent.Data.GetData(DataFormats.FileDrop, false);
            if (watchStartButton.Enabled && drgevent.Data.GetDataPresent(DataFormats.FileDrop) && files.Length == 1)
            {
                drgevent.Effect = DragDropEffects.All;
                return;
            }
            drgevent.Effect = DragDropEffects.None;
        }

        protected override void OnDragDrop(DragEventArgs drgevent)
        {
            base.OnDragDrop(drgevent);

            try
            {
                var fileNameArray = (string[])drgevent.Data.GetData(DataFormats.FileDrop, false);
                SetTargetFile(fileNameArray[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            settings.Save();
        }

        private void EnvironmentForm_InitializeButtonClick(object sender, InitializeButtonClickEventArgs e)
        {
            settings = e.Settings;
            OnLoad(EventArgs.Empty);
        }

        private void compileMenuItem_Click(object sender, EventArgs e)
        {
            Compile();
        }

        private void environmentMenuItem_Click(object sender, EventArgs e)
        {
            ef.ShowDialog();
        }

        private void endMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void versionMenuItem_Click(object sender, EventArgs e)
        {
            VersionForm vf = new VersionForm();
            vf.Show();
        }

        private void referenceButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select MML";
            ofd.Filter = "MML File (*.mml)|*.mml|All File (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                SetTargetFile(ofd.FileName);
            }
        }

        private void SetTargetFile(string path)
        {
            referenceTextBox.Text = path;
            referenceTextBox.SelectionStart = path.Length;
            settings.MMLPath = path;
            settings.Save();
        }

        private void watchStartButton_Click(object sender, EventArgs e)
        {
            if (settings.MMLPath.Length == 0)
            {
                MessageBox.Show("Target MML is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists(settings.MMLPath))
            {
                MessageBox.Show("Target MML was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (settings.MSDOSEnable && settings.MSDOSPath.Length == 0)
                {
                    MessageBox.Show("MS-DOS Player is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (settings.MSDOSEnable && !File.Exists(settings.MSDOSPath))
                {
                    MessageBox.Show("MS-DOS Player was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (settings.MCPath.Length == 0)
                    {
                        MessageBox.Show("MC is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!File.Exists(settings.MCPath))
                    {
                        MessageBox.Show("MC was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (settings.AutoPlay && settings.PlayerPath.Length == 0)
                        {
                            MessageBox.Show("Player is not set.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (settings.AutoPlay && !File.Exists(settings.PlayerPath))
                        {
                            MessageBox.Show("Player was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                fileSystemWatcher.Path = Path.GetDirectoryName(settings.MMLPath);
                                fileSystemWatcher.Filter = Path.GetFileName(settings.MMLPath);
                                fileSystemWatcher.EnableRaisingEvents = true;

                                watchStartButton.Enabled = false;
                                watchStopButton.Enabled = true;
                                environmentMenuItem.Enabled = false;
                                watchStartMenuItem.Enabled = false;
                                watchStopMenuItem.Enabled = true;
                                referenceButton.Enabled = false;
                                toolStripStatusLabel.Text = "Monitoring...";
                            }
                            catch
                            {
                                MessageBox.Show("MML path is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void watchStopButton_Click(object sender, EventArgs e)
        {
            if (compileProcess != null) // Stop the compile
            {
                compileProcess.Kill();
                compileProcess.Close();
                compileProcess = null;
                compileResultTextList = null;
                MessageBox.Show("Cancelled MML compilation.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            fileSystemWatcher.EnableRaisingEvents = false;

            watchStopButton.Enabled = false;
            watchStartButton.Enabled = true;
            environmentMenuItem.Enabled = true;
            watchStartMenuItem.Enabled = true;
            watchStopMenuItem.Enabled = false;
            referenceButton.Enabled = true;
            toolStripStatusLabel.Text = "Ready";
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            // Prevent continuous execution 
            DateTime curChangeTime = DateTime.Now;
            if (curChangeTime - prevChangeTime < TimeSpan.FromMilliseconds(250))
            {
                return;
            }
            prevChangeTime = curChangeTime;

            Compile();
        }

        private void Compile()
        {
            if (!File.Exists(settings.MMLPath))
            {
                MessageBox.Show("Target MML was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "Compilation failed";
                return;
            }
            else if (settings.MSDOSEnable && !File.Exists(settings.MSDOSPath))
            {
                MessageBox.Show("MS-DOS Player was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "Compilation failed";
                return;
            }
            else if (!File.Exists(settings.MCPath))
            {
                MessageBox.Show("MC was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "Compilation failed";
                return;
            }

            compileProcess = new System.Diagnostics.Process();
            if (settings.MSDOSEnable)
            {
                compileProcess.StartInfo.FileName = settings.MSDOSPath;
                if (settings.MCOption.Length == 0)
                {
                    compileProcess.StartInfo.Arguments = settings.MCPath + " " + settings.MMLPath;
                }
                else
                {
                    compileProcess.StartInfo.Arguments = settings.MCPath + " " + settings.MCOption + " " + settings.MMLPath;
                }
            }
            else
            {
                compileProcess.StartInfo.FileName = settings.MCPath;
                if (settings.MCOption.Length == 0)
                {
                    compileProcess.StartInfo.Arguments = settings.MMLPath;
                }
                else
                {
                    compileProcess.StartInfo.Arguments = settings.MCOption + " " + settings.MMLPath;
                }
            }
            compileProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(settings.MMLPath);
            compileProcess.StartInfo.CreateNoWindow = true;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(compileProcess_OutputDataReceived);

            compileResultTextList = new List<string>();
            toolStripStatusLabel.Text = "Compiling...";
            statusStrip.Update();
            try
            {
                compileProcess.Start();
                try
                {
                    compileProcess.BeginOutputReadLine();
                }
                catch
                {
                    compileProcess.Kill();
                    throw;
                }
            }
            catch
            {
                compileProcess.Close();
                compileProcess = null;
                compileResultTextList = null;
                MessageBox.Show("Failed to compile MML.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toolStripStatusLabel.Text = "Compilation failed";
                return;
            }
        }

        private void compileProcess_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (compileProcess != null) // Skip when cancelling compilation in MainForm
            {
                if (e.Data != null)
                {
                    compileResultTextList.Add(e.Data);
                }
                else
                {
                    compileProcess.Close();
                    compileProcess = null;

                    BeginInvoke((Action)(() =>
                    {
                        CompileResult cr = new CompileResult(compileResultTextList);

                        if (settings.ResultFormEnable)
                        {
                            if (crf == null)    // Closed compilation result form
                            {
                                crf = new CompileResultForm();
                                crf.FormClosed += (sender2, e2) => { crf = null; };
                                crf.SetResult(cr);
                                crf.Show();
                            }
                            else
                            {
                                crf.SetResult(cr);
                            }
                        }
                        else if (crf != null)
                        {
                            crf.Close();
                        }

                        if (cr.Success)
                        {
                            toolStripStatusLabel.Text = "Compiled";
                        }
                        else
                        {
                            toolStripStatusLabel.Text = "Compilation failed";
                            if (settings.SoundNotification)
                            {
                                System.Media.SystemSounds.Hand.Play();
                            }
                        }

                        if (cr.Success && settings.AutoPlay)
                        {
                            if (!File.Exists(settings.PlayerPath))
                            {
                                MessageBox.Show("Player was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                toolStripStatusLabel.Text = "Autoplay failed";
                                return;
                            }

                            toolStripStatusLabel.Text = "Sending the song to the player...";
                            statusStrip.Update();
                            try
                            {
                                playProcess?.Close();

                                playProcess = new System.Diagnostics.Process();
                                playProcess.StartInfo.FileName = settings.PlayerPath;
                                playProcess.StartInfo.Arguments = Path.Combine(Path.GetDirectoryName(settings.MMLPath), CompiledFile.getFileName(settings.MMLPath));
                                playProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(settings.MMLPath);

                                playProcess.Start();
                            }
                            catch
                            {
                                playProcess.Close();
                                playProcess = null;
                                MessageBox.Show("Failed to play the compiled data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                toolStripStatusLabel.Text = "Autoplay failed";
                                return;
                            }

                            toolStripStatusLabel.Text = "Success to send the song to the player";
                        }
                    }));
                }
            }
        }
    }
}
