using System;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            ArrayList numbers = new ArrayList();
            ArrayList min3Numbers = new ArrayList();
            ArrayList max3Numbers = new ArrayList();
            double minOrt;
            double maxOrt;

            Console.WriteLine(length + " adet tam sayı giriniz: ");
            for (int i = 0; i < length; i++)
            {
                numbers.Add(Int32.Parse(Console.ReadLine()));
            }

            numbers.Sort();

            min3Numbers.Add(numbers[0]);
            min3Numbers.Add(numbers[1]);
            min3Numbers.Add(numbers[2]);

            max3Numbers.Add(numbers[length - 1]);
            max3Numbers.Add(numbers[length - 2]);
            max3Numbers.Add(numbers[length - 3]);

            minOrt = ortalama(min3Numbers);
            maxOrt = ortalama(max3Numbers);

            Console.WriteLine("Min'lerin ortalaması: " + minOrt);
            Console.WriteLine("Max'larin ortalaması: " + maxOrt);
            Console.WriteLine("Ortalama Toplamları: " + (minOrt + maxOrt));

        }

        public static double ortalama(ArrayList nums)
        {
            double ort = 0;
            int toplam = 0;
            foreach (var num in nums)
            {
                toplam += (int)num;
            }

            ort = (double)toplam / (double)nums.Count;
            return ort;
        }
    }
}
