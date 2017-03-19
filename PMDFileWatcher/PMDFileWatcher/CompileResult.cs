using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMDFileWatcher
{
    public class CompileResult
    {
        private List<string> textList;

        private bool _success;
        public bool Success
        {
            get
            {
                return _success;
            }
        }

        public CompileResult(List<string> list)
        {
            textList = list;
            _success = isSuccess();
        }

        private bool isSuccess()
        {
            try
            {
                foreach (string line in textList)
                {
                    if (line.Contains("Compile Completed.") == true)
                    {
                        return true;
                    }
                }
                return false;   // MML構文エラー(コンパイル失敗)
            }
            catch
            {
                return false;   // コンパイルプロセスの異常終了
            }
        }

        public override string ToString()
        {
            if (textList == null)
            {
                return "コンパイルの実行に失敗しました。";
            }
            else
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string line in textList)
                    {
                        sb.Append(line);
                        sb.Append("\r\n");

                    }
                    return sb.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    return "データのサイズが大きすぎます。";
                }
                catch
                {
                    return "実行結果を表示できません。";
                }
            }
        }
    }
}
