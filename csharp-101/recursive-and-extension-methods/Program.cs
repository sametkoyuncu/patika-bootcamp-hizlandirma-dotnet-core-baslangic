using System;

namespace recursive_and_extension_methods
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // extension
        /*
        Extension Metotların kelime anlamı genişletilebilir metotlardır. C# 3.0 ile hayatımıza giren, aynı kodu defalarca yazmak yerine, bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
        */
        public static class Extension
        {
            public static bool IsEventNumber(this int value)
            {
                if (value % 2 == 0)
                    return true;
                else
                    return false;
            }
        }

        // recursive
        public static int FibonacciSerisi(int sayi)
        {
            if (sayi == 0)
                return 0;
            else if (sayi == 1)
                return 1;
            else
                return FibonacciSerisi(sayi - 1) + FibonacciSerisi(sayi - 2);
        }
    }
}
