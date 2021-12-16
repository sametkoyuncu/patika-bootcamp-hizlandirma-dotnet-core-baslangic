using System;

namespace datetime_and_math_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(4));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddSeconds(34));
            Console.WriteLine(DateTime.Now.AddMonths(5)); //...

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // gün numarası
            Console.WriteLine(DateTime.Now.ToString("ddd")); // gün kısaltması
            Console.WriteLine(DateTime.Now.ToString("dddd")); // gün tam hali

            Console.WriteLine(DateTime.Now.ToString("MM")); // ay numarası
            Console.WriteLine(DateTime.Now.ToString("MMM")); // ay kısaltması
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // ay tam hali

            Console.WriteLine(DateTime.Now.ToString("yy")); // yıl son 2
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // yıl tam hali

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-1)); // mutlak değer

            Console.WriteLine(Math.Sin(45)); // sinüs hesaplar
            Console.WriteLine(Math.Cos(45)); // ... hesaplar
            Console.WriteLine(Math.Tan(45)); // ... hesaplar

            Console.WriteLine(Math.Ceiling(45.2)); // yukarıya yuvarlar
            Console.WriteLine(Math.Round(45.3)); // kime yakınsa ona yuvarlar
            Console.WriteLine(Math.Floor(45.4)); // aşağıya yuvarlar

            Console.WriteLine(Math.Min(45, 30)); //
            Console.WriteLine(Math.Max(45, 30)); //

            Console.WriteLine(Math.Pow(3, 4)); // 3^4'ü verir
            Console.WriteLine(Math.Sqrt(9)); // 9'un karekökü
            Console.WriteLine(Math.Log(9)); // 9'un e tabanındaki logaritmik karşılığı
            Console.WriteLine(Math.Exp(3)); // e üzeri 3 => e^3
            Console.WriteLine(Math.Log10(9)); // 9'un 10 tabanındaki logaritmik karşılığı





        }
    }
}
