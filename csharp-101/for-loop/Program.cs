using System;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i; ;)// Sonsuz döngü
            {
                a = Convert.ToChar(Console.ReadLine());
                if (i == 7)
                    break;
            }
            //Kod burdan devam eder. 



            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
