using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Toplam(4, 8, out int toplam);
            Console.WriteLine(toplam);
        }

        public void EkranaYazdir(int deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger)
        {
            Console.WriteLine(deger);
        }

        public void EkranaYazdir(string deger1, string deger2)
        {
            Console.WriteLine(deger1 + deger2);
        }



        public static int Toplam(int a, int b, out int toplam)
        {
            toplam = a + b;
            return toplam;
        }
    }
}
