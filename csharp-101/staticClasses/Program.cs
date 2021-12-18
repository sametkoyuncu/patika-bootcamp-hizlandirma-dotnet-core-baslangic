using System;

namespace staticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);

            Calisan c1 = new Calisan("Samet");
            Console.WriteLine("Çalışan Sayısı: " + Calisan.CalisanSayisi);

            Console.WriteLine(Islemler.Topla(3, 5));

        }
    }

    class Calisan
    {

        // static sınıf bazında, her oluşturulan nesne için ortak değer, en son ne atandıysa o
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }
        private string Isim;

        // static constructor ların erişim belirteçi olmaz
        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim)
        {
            this.Isim = isim;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static int Topla(int a, int b)
        {
            return a + b;
        }
    }
}
