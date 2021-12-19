using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            // DatabaseLogger dblogger = new DatabaseLogger();
            // dblogger.WriteLog();

            // FileLogger flogger = new FileLogger();
            // flogger.WriteLog();

            LogManager lm = new LogManager(new FileLogger());
            lm.WriteLog();
        }
    }
}
