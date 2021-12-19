using System;
namespace Interfaces
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("file log");
        }
    }
}