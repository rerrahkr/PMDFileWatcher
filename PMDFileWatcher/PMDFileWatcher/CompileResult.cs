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
                    if (line.Contains("Compile Completed."))
                    {
                        return true;
                    }
                }
                return false;   // MML syntax error
            }
            catch
            {
                return false;   // Abort
            }
        }

        public override string ToString()
        {
            if (textList == null)
            {
                return "Failed to compile MML.";
            }
            else
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string line in textList)
                    {
                        sb.Append(line);
                        sb.Append(Environment.NewLine);

                    }
                    return sb.ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    return "MML size is too large.";
                }
                catch
                {
                    return "Could not display compilation result.";
                }
            }
        }
    }
}
