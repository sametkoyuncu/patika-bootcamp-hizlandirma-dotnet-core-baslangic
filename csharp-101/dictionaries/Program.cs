using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // key value ilişkisi var, key'ler unique
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();

            kullanicilar.Add(10, "Veli Kağan");
            kullanicilar.Add(12, "Ezgi Çetin");
            kullanicilar.Add(13, "Ali Kemal");

            Console.WriteLine(kullanicilar[12]);

            // Count

            // ContainsValue ve ContainsKey, true veya false döner

            // Remove

            // Keys ve Values
            // kullanicilar.Keys  gibi foreach yer
        }
    }
}
