using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class BufferedFileLoggerProxy : IMyLogger
    {
        private readonly FileLogger _filelogger;
        private readonly int bufferSize;
        private List<string> buffer;

        public BufferedFileLoggerProxy(int bufferSize)
        {
            this.bufferSize = bufferSize;
            _filelogger = new FileLogger();
            buffer = new List<string>();
        }

        public void Log(string message)
        {
            buffer.Add(message);    
            if (buffer.Count >= bufferSize){
                _filelogger.Log(message);
                buffer.Clear(); 
            }
        }
    }
}
