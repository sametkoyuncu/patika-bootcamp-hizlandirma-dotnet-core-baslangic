using System;
namespace Interfaces
{
    public class DatabaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("db log");
        }
    }
}