﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PMDFileWatcher
{
    public static class CompiledFile
    {
        public static string GetFileName(string mmlPath)
        {
            try
            {
                using (var sr = new StreamReader(mmlPath, Encoding.GetEncoding("shift_jis")))
                {
                    var regex = new Regex("#Filename\\s+(?<name>.+$)", RegexOptions.IgnoreCase);
                    while (sr.Peek() > -1)
                    {
                        Match match = regex.Match(sr.ReadLine());
                        if (match.Success)
                        {
                            string compiledFileName;
                            if (match.Groups["name"].Value.StartsWith(".")) // Extension only
                            {
                                compiledFileName = Path.GetFileNameWithoutExtension(mmlPath) + match.Groups["name"].Value;
                            }
                            else
                            {
                                compiledFileName = match.Groups["name"].Value;
                            }
                            return compiledFileName;
                        }
                    }
                    return Path.GetFileNameWithoutExtension(mmlPath) + ".M";    // Unspecified
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
