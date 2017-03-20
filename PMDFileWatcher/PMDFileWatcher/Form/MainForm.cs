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
        private EnvironmentForm ef;
        private CompileResultForm crf;

        private DateTime prevChangeTime;

        private System.Diagnostics.Process compileProcess;
        private System.Diagnostics.Process playProcess;

        List<string> compileResultTextList;

        public MainForm()
        {
            InitializeComponent();

            ef = new EnvironmentForm();
            ef.LoadedSettings += new EventHandler(MainForm_Load);
            crf = null;

            prevChangeTime = DateTime.Now;

            compileProcess = null;
            playProcess = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            referenceTextBox.Text = Properties.Settings.Default.MMLPath;
            referenceTextBox.SelectionStart = referenceTextBox.Text.Length;
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
            ofd.Title = "監視するMMLを選択";
            ofd.Filter = "MML File (*.mml)|*.mml|All File (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                referenceTextBox.Text = ofd.FileName;
                referenceTextBox.SelectionStart = ofd.FileName.Length;
                Properties.Settings.Default.MMLPath = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void watchStartButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MMLPath.Length == 0)
            {
                MessageBox.Show("監視するMMLが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (File.Exists(Properties.Settings.Default.MMLPath) == false)
            {
                MessageBox.Show("指定したMMLは存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Properties.Settings.Default.MSDOSEnable == true && Properties.Settings.Default.MSDOSPath.Length == 0)
                {
                    MessageBox.Show("MS-DOS Playerが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Properties.Settings.Default.MSDOSEnable == true && File.Exists(Properties.Settings.Default.MSDOSPath) == false)
                {
                    MessageBox.Show("指定先にMS-DOS Playerは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Properties.Settings.Default.MCPath.Length == 0)
                    {
                        MessageBox.Show("MCが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (File.Exists(Properties.Settings.Default.MCPath) == false)
                    {
                        MessageBox.Show("指定先にMCコンバータは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Properties.Settings.Default.AutoPlay == true && Properties.Settings.Default.PlayerPath.Length == 0)
                        {
                            MessageBox.Show("プレーヤが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (Properties.Settings.Default.AutoPlay == true && File.Exists(Properties.Settings.Default.PlayerPath) == false)
                        {
                            MessageBox.Show("指定先にプレーヤは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            try
                            {
                                fileSystemWatcher.Path = Path.GetDirectoryName(Properties.Settings.Default.MMLPath);
                                fileSystemWatcher.Filter = Path.GetFileName(Properties.Settings.Default.MMLPath);
                                fileSystemWatcher.EnableRaisingEvents = true;

                                watchStartButton.Enabled = false;
                                watchStopButton.Enabled = true;
                                environmentMenuItem.Enabled = false;
                                watchStartMenuItem.Enabled = false;
                                watchStopMenuItem.Enabled = true;
                                referenceButton.Enabled = false;
                            }
                            catch
                            {
                                MessageBox.Show("MMLファイルのパス指定が間違っています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void watchStopButton_Click(object sender, EventArgs e)
        {
            if (compileProcess != null) // コンパイル中止
            {
                compileProcess.Kill();
                compileProcess.Close();
                compileProcess = null;
                compileResultTextList = null;
                MessageBox.Show("MMLのコンパイルを中断しました。", "情報", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            fileSystemWatcher.EnableRaisingEvents = false;

            watchStopButton.Enabled = false;
            watchStartButton.Enabled = true;
            environmentMenuItem.Enabled = true;
            watchStartMenuItem.Enabled = true;
            watchStopMenuItem.Enabled = false;
            referenceButton.Enabled = true;
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            // 複数回イベント実行防止
            DateTime curChangeTime = DateTime.Now;
            if (curChangeTime - prevChangeTime < TimeSpan.FromMilliseconds(250))
            {
                return;
            }
            prevChangeTime = curChangeTime;

            if (Properties.Settings.Default.MSDOSEnable == true && File.Exists(Properties.Settings.Default.MSDOSPath) == false)
            {
                MessageBox.Show("指定先にMS-DOS Playerは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (File.Exists(Properties.Settings.Default.MCPath) == false)
            {
                MessageBox.Show("指定先にMCは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            compileProcess = new System.Diagnostics.Process();
            if (Properties.Settings.Default.MSDOSEnable == true)
            {
                compileProcess.StartInfo.FileName = Properties.Settings.Default.MSDOSPath;
                if (Properties.Settings.Default.MCOption.Length == 0)
                {
                    compileProcess.StartInfo.Arguments = Properties.Settings.Default.MCPath + " " + Properties.Settings.Default.MMLPath;
                }
                else
                {
                    compileProcess.StartInfo.Arguments = Properties.Settings.Default.MCPath + " " + Properties.Settings.Default.MCOption + " " + Properties.Settings.Default.MMLPath;
                }
            }
            else
            {
                compileProcess.StartInfo.FileName = Properties.Settings.Default.MCPath;
                if (Properties.Settings.Default.MCOption.Length == 0)
                {
                    compileProcess.StartInfo.Arguments = Properties.Settings.Default.MMLPath;
                }
                else
                {
                    compileProcess.StartInfo.Arguments = Properties.Settings.Default.MCOption + " " + Properties.Settings.Default.MMLPath;
                }
            }
            compileProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.MMLPath);
            compileProcess.StartInfo.CreateNoWindow = true;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.RedirectStandardOutput = true;
            compileProcess.OutputDataReceived += new System.Diagnostics.DataReceivedEventHandler(compileProcess_OutputDataReceived);

            compileResultTextList = new List<string>();
            try
            {
                compileProcess.Start();
                compileProcess.BeginOutputReadLine();
            }
            catch
            {
                compileProcess.Kill();
                compileProcess.Close();
                compileProcess = null;
                compileResultTextList = null;
                MessageBox.Show("MMLのコンパイルに失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void compileProcess_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            if (compileProcess != null) // MainFormでコンパイルキャンセルした直後は空処理
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

                        if (crf == null)    // コンパイル結果フォームがない場合
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

                        if (cr.Success == true && Properties.Settings.Default.AutoPlay == true)
                        {
                            if (File.Exists(Properties.Settings.Default.PlayerPath) == false)
                            {
                                MessageBox.Show("指定先にプレーヤは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string compiledFileName = CompiledFile.getFileName(Properties.Settings.Default.MMLPath);
                            try
                            {
                                playProcess?.Close();

                                playProcess = new System.Diagnostics.Process();
                                playProcess.StartInfo.FileName = Properties.Settings.Default.PlayerPath;
                                playProcess.StartInfo.Arguments = Path.Combine(Path.GetDirectoryName(Properties.Settings.Default.MMLPath), compiledFileName);
                                playProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.MMLPath);

                                playProcess.Start();
                            }
                            catch
                            {
                                playProcess.Close();
                                playProcess = null;
                                MessageBox.Show("コンパイルしたデータの再生に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }));
                }
            }
        }
    }
}
