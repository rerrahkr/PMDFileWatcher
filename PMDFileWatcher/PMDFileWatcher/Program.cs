using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMDFileWatcher
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (System.Threading.Mutex mutex = new System.Threading.Mutex(false, "PMDFileWatcher"))
                {
                    bool hasHandle = false;

                    try
                    {
                        try
                        {
                            hasHandle = mutex.WaitOne(0, false);
                            if (hasHandle == false)
                            {
                                WakeUpWindow();
                                return;
                            }
                        }
                        catch (System.Threading.AbandonedMutexException)
                        {
                            hasHandle = true;
                        }

                        try
                        {
                            Application.EnableVisualStyles();
                            Application.SetCompatibleTextRenderingDefault(false);
                            Application.Run(new Form.MainForm());
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(string.Format("不明なエラーが発生しました。\nException Message: {0}", ex.Message), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        if (hasHandle == true)
                        {
                            mutex.ReleaseMutex();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("PMDFileWatcherの起動に失敗しました。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void WakeUpWindow()
        {
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processList = Process.GetProcessesByName(currentProcess.ProcessName);

            foreach (Process process in processList)
            {
                if (process.Id != currentProcess.Id && string.Compare(process.MainModule.FileName, currentProcess.MainModule.FileName) == 0)
                {
                    if (IsIconic(process.MainWindowHandle) == true)
                    {
                        ShowWindowAsync(process.MainWindowHandle, SW_RESTORE);
                    }
                    SetForegroundWindow(process.MainWindowHandle);
                    return;
                }
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);
    }
}
