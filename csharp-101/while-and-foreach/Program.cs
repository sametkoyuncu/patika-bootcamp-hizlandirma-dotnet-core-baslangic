using System;

namespace while_and_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] diziAdı = { 2, 4, 5, 1, 2, 4 };
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            foreach (değişkenTipi değişkenAdı in diziAdı)
            {
                //Komutlar
            }

            int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
            int toplam = 0;

            foreach (int i in SayiDizisi)
            {
                toplam += i;
            }
        }
    }
}
