using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMDFileWatcher
{
    public class CompileResult
    {
        private readonly List<string> textList;

        public bool Success { get; }

        public CompileResult(List<string> list)
        {
            textList = list;
            Success = IsSuccess();
        }

        private bool IsSuccess()
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
                    var sb = new StringBuilder();
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
