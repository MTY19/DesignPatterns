using System;

namespace ProxyPattern.FirstExample
{
    public class BufferFileLoggerProxy : ILogger
	{
        private readonly FileLogger fileLogger;
        private readonly int bufferSize;
        private List<string> buffer;

        public BufferFileLoggerProxy(int bufferSize)
        {
            this.bufferSize = bufferSize;
            this.fileLogger = new FileLogger();
            this.buffer = new List<string>(capacity: bufferSize);
        }

        public void Log(string message)
        {
            buffer.Add(message);   
            if(bufferSize < buffer.Count)
            {
                fileLogger.Log(buffer);
                buffer.Clear();
            }
        }

        public void Log(IEnumerable<string> messages)
        {
            fileLogger.Log(messages);
        }
    }
}

