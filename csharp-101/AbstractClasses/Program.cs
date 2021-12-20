using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Civic civic = new Civic();
            Corolla corolla = new Corolla();

            Console.WriteLine(focus.HangiMarka.ToString());
            Console.WriteLine(civic.HangiMarka.ToString());
            Console.WriteLine(corolla.HangiMarka.ToString());
        }
    }
}
