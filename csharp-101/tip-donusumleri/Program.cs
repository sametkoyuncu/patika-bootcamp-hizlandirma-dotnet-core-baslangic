using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Implicit Conversion
            float a;
            int b = 25;
            a = b;

            short x = 10;
            int y;
            y = x;

            // Explicit Conversion
            int a2 = 2323;
            byte b2 = a2;
        }
    }
}
