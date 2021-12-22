using System;
using System.Linq;
using System.Collections.Generic;

namespace One
{
    class Program
    {
        private static void yeniKisi(ref List<Kisi> rehber)
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string telefon = Console.ReadLine();

            rehber.Add(new Kisi(ad, soyad, telefon));
        }

        private static void kisiSil(ref List<Kisi> rehber, string silinecekVeri)
        {
            string secim;
            //index i bul
            int index = rehber.FindIndex(x => x.Ad == silinecekVeri || x.Soyad == silinecekVeri);
            //index varsa silme onayı al
            if (index >= 0)
            {
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", rehber[index].Ad);
                secim = Console.ReadLine();
                if (secim == "y")
                {
                    rehber.RemoveAt(index);
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                secim = Console.ReadLine();
                if (secim == "2")
                {
                    kisiSil(ref rehber, silinecekVeri);
                }
            }

        }

        private static void kisiDuzenle(ref List<Kisi> rehber, string duzenlenecekVeri)
        {
            string secim;
            //index i bul
            int index = rehber.FindIndex(x => x.Ad == duzenlenecekVeri || x.Soyad == duzenlenecekVeri);
            if (index >= 0)
            {
                Console.WriteLine("Sırası ile bilgileri giriniz.");
                Console.WriteLine("Eğer bilgiyi gğncellemek istemiyorsanız, aynı değeri yazınız.");
                Console.WriteLine("Eski İsim: {0}", rehber[index].Ad);
                Console.WriteLine("Yeni İsim:");
                rehber[index].Ad = Console.ReadLine();

                Console.WriteLine("Eski Soyisim: {0}", rehber[index].Soyad);
                Console.WriteLine("Yeni Soyisim:");
                rehber[index].Soyad = Console.ReadLine();

                Console.WriteLine("Eski Telefon Numarası: {0}", rehber[index].Telefon);
                Console.WriteLine("Yeni Telefon Numarası:");
                rehber[index].Telefon = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Düzenlemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                secim = Console.ReadLine();
                if (secim == "2")
                {
                    kisiDuzenle(ref rehber, duzenlenecekVeri);
                }
            }



        }

        private static void listele(ref List<Kisi> rehber)
        {
            int secim;
            Console.WriteLine("Sıralama yöntemi seçiniz: ");

            Console.WriteLine("* İsme göre A'dan Z'ye : (1)");
            Console.WriteLine("* İsme göre Z'den A'ya : (2)");

            Console.WriteLine("* Soyisme göre A'dan Z'ye : (3)");
            Console.WriteLine("* Soyisme göre Z'den A'ya : (4)");

            Console.WriteLine("* Telefon numarasına göre 0'dan 9'a : (5)");
            Console.WriteLine("* Telefon numarasına göre 9'dan 0'a : (6)");

            secim = Int32.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    rehber = rehber.OrderBy(x => x.Ad).ToList();
                    break;
                case 2:
                    rehber = rehber.OrderByDescending(x => x.Ad).ToList();
                    break;
                case 3:
                    rehber = rehber.OrderBy(x => x.Soyad).ToList();
                    break;
                case 4:
                    rehber = rehber.OrderByDescending(x => x.Soyad).ToList();
                    break;
                case 5:
                    rehber = rehber.OrderBy(x => x.Telefon).ToList();
                    break;
                case 6:
                    rehber = rehber.OrderByDescending(x => x.Telefon).ToList();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim, rehber varsayılan şekilde listelenecek.");
                    break;
            }

            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            foreach (var kisi in rehber)
            {
                Console.WriteLine(" İsim: {0}", kisi.Ad);
                Console.WriteLine(" Soyisim: {0}", kisi.Soyad);
                Console.WriteLine(" Telefon Numarası: {0}", kisi.Telefon);
                Console.WriteLine("-");
            }
        }
        static void Main(string[] args)
        {
            List<Kisi> rehber = new List<Kisi>();
            rehber.Add(new Kisi("Samet", "Koyuncu", "05333333333"));
            rehber.Add(new Kisi("Ayşe", "Yılmaz", "05444444444"));
            rehber.Add(new Kisi("Büşra", "Korkmaz", "05555555555"));
            int islem;
            string silinecekVeri;
            string duzenlenecekVeri;
            while (true)
            {
                islem = giris();
                switch (islem)
                {
                    case 1:
                        yeniKisi(ref rehber);
                        break;
                    case 2:
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        silinecekVeri = Console.ReadLine();
                        kisiSil(ref rehber, silinecekVeri);
                        break;
                    case 3:
                        Console.WriteLine("Lütfen düzenlemek istediğiniz kişinin adını ya da soyadını giriniz:");
                        duzenlenecekVeri = Console.ReadLine();
                        kisiDuzenle(ref rehber, duzenlenecekVeri);
                        break;
                    case 4:
                        listele(ref rehber);
                        break;
                    default:
                        Console.WriteLine("Lütfen geçerli bir işlem seçiniz: ");
                        break;
                }
            }


        }

        class Kisi
        {
            public string Ad;
            public string Soyad;
            public string Telefon;

            public Kisi(string ad, string soyad, string telefon)
            {
                Ad = ad;
                Soyad = soyad;
                Telefon = telefon;
            }
        }

        public static int giris()
        {

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            Console.WriteLine("(ctrl + c) Çıkış Yap");

            return Int32.Parse(Console.ReadLine());
        }


    }
}
