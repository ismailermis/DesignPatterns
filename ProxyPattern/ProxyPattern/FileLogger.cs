using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class FileLogger : IMyLogger
    {
        public void Log(string message)
        {
            message = $"[{DateTime.Now:dd.MM.yyyy}] - {message}";
            string path = @"mylog.log";

            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                message+= Environment.NewLine;
                File.WriteAllText(path, message, Encoding.UTF8);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            message+= Environment.NewLine;
            File.AppendAllText(path, message, Encoding.UTF8);

        }
    }
}
