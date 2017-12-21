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

        private Settings settings;

        public MainForm()
        {
            InitializeComponent();

            settings = Settings.Load();

            ef = new EnvironmentForm(settings);
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
                Console.WriteLine(fileNameArray[0]);
                SetTargetFile(fileNameArray[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("監視するMMLが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!File.Exists(settings.MMLPath))
            {
                MessageBox.Show("指定したMMLは存在しません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (settings.MSDOSEnable && settings.MSDOSPath.Length == 0)
                {
                    MessageBox.Show("MS-DOS Playerが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (settings.MSDOSEnable && !File.Exists(settings.MSDOSPath))
                {
                    MessageBox.Show("指定先にMS-DOS Playerは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (settings.MCPath.Length == 0)
                    {
                        MessageBox.Show("MCが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!File.Exists(settings.MCPath))
                    {
                        MessageBox.Show("指定先にMCコンバータは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (settings.AutoPlay && settings.PlayerPath.Length == 0)
                        {
                            MessageBox.Show("プレーヤが未設定です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (settings.AutoPlay && !File.Exists(settings.PlayerPath))
                        {
                            MessageBox.Show("指定先にプレーヤは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (settings.MSDOSEnable && !File.Exists(settings.MSDOSPath))
            {
                MessageBox.Show("指定先にMS-DOS Playerは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!File.Exists(settings.MCPath))
            {
                MessageBox.Show("指定先にMCは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                        if (settings.ResultFormEnable)
                        {
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
                        }
                        else if (crf != null)
                        {
                            crf.Close();
                        }

                        if (cr.Success && settings.AutoPlay)
                        {
                            if (!File.Exists(settings.PlayerPath))
                            {
                                MessageBox.Show("指定先にプレーヤは存在していません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

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
                                MessageBox.Show("コンパイルしたデータの再生に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }));
                }
            }
        }
    }
}
