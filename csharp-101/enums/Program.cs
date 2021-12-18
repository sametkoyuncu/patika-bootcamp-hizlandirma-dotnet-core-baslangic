using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Salı);
            Console.WriteLine((int)Gunler.Pazar); // numerik değerini alma

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaDurumu.Normal)
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin.");
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
                Console.WriteLine("Dışarıya çıkmak için hava çok sıcak.");
        }
    }

    enum Gunler
    {
        Pazartesi, // normalde 0'dan başlar ama biz değer de atayabiliriz
        Salı,
        Çarşamba,
        Perşembe,
        Cuma = 23,
        Cumartesi, // ardışık gideceği için cumaya kadar 0 1 2 3, cuma 23, sonrası  24, 25
        Pazar
    }

    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}
