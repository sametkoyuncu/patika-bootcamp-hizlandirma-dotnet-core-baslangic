using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ödev 1 - 1. Kısım - Görmek için metodu yorumdan çıkartın.");
            // firstPart();
            Console.WriteLine("Ödev 1 - 2. Kısım - Görmek için metodu yorumdan çıkartın.");
            // secondPart();
            Console.WriteLine("Ödev 1 - 3. Kısım - Görmek için metodu yorumdan çıkartın.");
            // thirdPart();
            Console.WriteLine("Ödev 1 - 4. Kısım");
            fourthPart();
        }

        public static void firstPart()
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] dizi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                dizi[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Girdiğiniz çift sayılar: ");
            for (int i = 0; i < n; i++)
            {
                if (dizi[i] % 2 == 0)
                    Console.Write("{0} ", dizi[i]);
            }
            Console.WriteLine();
        }

        public static void secondPart()
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Pozitif bir sayı daha giriniz: ");
            int m = Int32.Parse(Console.ReadLine());

            int[] dizi = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                dizi[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("{0}'e eşit veya çift olan sayılar: ", m);
            for (int i = 0; i < n; i++)
            {
                if (dizi[i] == m)
                    Console.Write("{0} ", dizi[i]);
                else if (dizi[i] % 2 == 0)
                    Console.Write("{0} ", dizi[i]);

            }
            Console.WriteLine();
        }

        public static void thirdPart()
        {
            Console.WriteLine("Pozitif bir sayı giriniz: ");
            int n = Int32.Parse(Console.ReadLine());

            string[] dizi = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Bir kelime giriniz: ");
                dizi[i] = Console.ReadLine();
            }

            Console.Write("Sondan başa doğru gidiğiniz kelimeler: ");
            Array.Reverse(dizi);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", dizi[i]);

            }
            Console.WriteLine();
        }

        public static void fourthPart()
        {
            Console.WriteLine("Bir cümle giriniz: ");
            string cumle = Console.ReadLine();

            string[] kelimeler = cumle.Split(" ");

            string bosluksuzCumle = string.Join("", kelimeler);

            Console.WriteLine("Kelime sayısı: {0}", kelimeler.Length);
            Console.WriteLine("Harf sayısı: {0}", bosluksuzCumle.Length);
            Console.WriteLine();
        }
    }
}
