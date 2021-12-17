using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // List<T> class
            // System.Collections.Generic
            // T -> Object türünde

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(1);
            sayiListesi.Add(5);
            sayiListesi.Add(3);
            sayiListesi.Add(17);
            sayiListesi.Add(11);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("mor");
            renkListesi.Add("mavi");
            renkListesi.Add("turuncu");

            // Count
            Console.WriteLine(sayiListesi.Count);

            foreach (var item in renkListesi)
            {
                Console.WriteLine(item);
            }

            renkListesi.ForEach(renk => Console.Write(renk + " "));
            Console.WriteLine();

            // Listeden eleman çıkarma
            renkListesi.Remove("mavi");
            sayiListesi.RemoveAt(0); // index'e göre çıkarma

            // arama
            if (sayiListesi.Contains(11))
                Console.WriteLine("11 bulundu.");

            // index bulma
            Console.WriteLine(renkListesi.BinarySearch("turuncu"));

            // diziyi listeye çevirme
            string[] hayvanlar = { "koyun", "kedi", "kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);
            hayvanListesi.ForEach(hayvan => Console.Write(hayvan + " "));
            Console.WriteLine();

            // Liste temizleme
            hayvanListesi.Clear();

            // nesne listesi
            List<Kullanici> kullaniciListesi = new List<Kullanici>();

            Kullanici kullanici1 = new Kullanici();
            kullanici1.AdSoyad = "Ayşe Yılmaz";
            kullanici1.Yas = 23;

            Kullanici kullanici2 = new Kullanici();
            kullanici2.AdSoyad = "Mert Kaya";
            kullanici2.Yas = 25;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanici> yeniKullaniciListesi = new List<Kullanici>();
            yeniKullaniciListesi.Add(new Kullanici()
            {
                AdSoyad = "Veli Kaymak",
                Yas = 53
            });

        }
    }

    public class Kullanici
    {
        private string adSoyad;
        private int yas;

        public string AdSoyad { get => adSoyad; set => adSoyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
