using System;

namespace string_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, hoşgeldiniz.";
            string degisken2 = "CSharp";

            // Length uzunluk
            Console.WriteLine(degisken.Length);

            // ToUpper, ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            // Compare, CompareTo - uzunluk karşılaştırıyor gibi
            Console.WriteLine(degisken.CompareTo(degisken2)); // 0, 1, -1
            Console.WriteLine(String.Compare(degisken, degisken2, true)); // 0, 1, -1 küçük büyük harf duyarlı duyarsız
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            // Contains - içeriyor mu
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            // IndexOf
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("CS"));

            // Insert
            Console.WriteLine(degisken.Insert(0, "Marhaba! ")); // 0. index'ten itibaren ekle

            // PadLeft, PadRight verilen değere tamamlayacak kadar şundan ekle gibi gibi
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50, "-") + degisken2);

            // Remove
            Console.WriteLine(degisken.Remove(10)); //10. index ve sonrasını siler
            Console.WriteLine(degisken.Remove(5, 3)); //5. index dahil 3 tane yani 5 6 7 

            // Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "-")); // KEBAB case, you love it :)

            // Split
            Console.WriteLine(degisken.Split(" ")[1]); // boşluklara göre paçala dizi ya, 2. index'i getir

            // Substring
            Console.WriteLine(degisken.Substring(10)); //10. index'ten sonuna kadar getir
            Console.WriteLine(degisken.Substring(10, 6)); //10. index'ten 6 karakter getir



        }
    }
}
