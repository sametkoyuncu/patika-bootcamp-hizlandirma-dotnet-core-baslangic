using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Kaan";
            calisan1.Soyad = "Akçay";
            calisan1.No = 232;
            calisan1.Departman = "İnşaat";

            calisan1.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan adı: {0}", Ad);
            Console.WriteLine("Çalışan soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan numarası: {0}", No);
            Console.WriteLine("Çalışan departmanı: {0}", Departman);
        }

    }

}



//  class SinifAdi
// {
//     [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
//     [Erişim Belirleyici]
//     [Geri Dönüş Değerinin Tipi]
//     MetotAdi([Parametreler])
//     {
//         //Metot Gövdesi
//     }
// }

// erişim belirteçleri
// 1.Public : Her yerden erişilebilir.

// 2.Private : Sadece tanımlandığı sınıf içerisinden erişilebilir.

// 3.Internal : Sadece bulunduğu proje içerisinden erişilebilir

// 4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.