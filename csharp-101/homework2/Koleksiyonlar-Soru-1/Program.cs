using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 5;
            int[] numbers = new int[arrayLenght];
            ArrayList asal = new ArrayList();
            ArrayList asalDegil = new ArrayList();
            bool checker;
            Console.WriteLine(arrayLenght + " adet pozitif tam sayı giriniz: ");
            for (int i = 0; i < arrayLenght; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
                if (numbers[i] < 0)
                {
                    Console.WriteLine("Lütfen sadece pozitif sayı giriniz.");
                    break;
                }
            }

            for (int i = 0; i < arrayLenght; i++)
            {
                checker = asalMi(numbers[i]);
                if (checker == true)
                    asal.Add(numbers[i]);
                else
                    asalDegil.Add(numbers[i]);
            }

            Console.Write("Girilen Asal Sayılar (adet: " + asal.Count + ", ortalama: " + ortalama(asal).ToString("F2") + "): ");
            asal.Sort();
            foreach (var item in asal)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            asalDegil.Sort();
            Console.Write("Girilen Asal Olmayan Sayılar (adet: " + asalDegil.Count + ", ortalama: " + ortalama(asalDegil).ToString("F2") + "): ");
            foreach (var item in asalDegil)
            {
                Console.Write(item + " ");
            }

        }

        public static bool asalMi(int num)
        {
            int counter = 0;

            if (num == 1)
                return false;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    counter++;
            }

            if (counter != 0)
                return false;
            return true;
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
