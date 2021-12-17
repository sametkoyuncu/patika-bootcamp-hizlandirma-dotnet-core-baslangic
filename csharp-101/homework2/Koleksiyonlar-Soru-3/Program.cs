using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            ArrayList sesliHarfler = new ArrayList();

            Console.WriteLine("Bir cümle giriniz: ");
            cumle = Console.ReadLine();

            foreach (var harf in cumle)
            {
                if (harf == 'A' || harf == 'a' ||
                    harf == 'E' || harf == 'e' ||
                    harf == 'I' || harf == 'ı' ||
                    harf == 'İ' || harf == 'i' ||
                    harf == 'O' || harf == 'o' ||
                    harf == 'Ö' || harf == 'ö' ||
                    harf == 'U' || harf == 'u' ||
                    harf == 'Ü' || harf == 'Ü')
                    sesliHarfler.Add(harf);
            }
            Console.Write("Sesli harfler: ");
            sesliHarfler.Sort();
            foreach (var item in sesliHarfler)
            {
                Console.Write(item);
            }
        }
    }
}
