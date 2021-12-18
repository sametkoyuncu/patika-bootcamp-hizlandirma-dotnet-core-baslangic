using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ogrenci o1 = new Ogrenci("Ayşe", "Yılmaz", 274756373, 11);

            // o1.OgrenciBilgileriniGetir();
            // o1.SinifAtlat();
            // o1.OgrenciBilgileriniGetir();
            Ogrenci o2 = new Ogrenci("Ahmet", "Yılmaz", 343523, -1);
            o2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int numara;
        private int sinif;

        // public string Isim { get => isim; set => isim = value; }
        // yukarıda ki gibi veya aşağıdaki gibi aynı şey
        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Numara { get => numara; set => numara = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf en az 1 olabilir.");
                    value = 1;
                }
                sinif = value;
            }
        }

        public Ogrenci() { }

        public Ogrenci(string isim, string soyisim, int numara, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            Numara = numara;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Öğrenci Bilgileri *****");
            Console.WriteLine("İsim         :" + this.Isim);
            Console.WriteLine("Soyisim      :" + this.Soyisim);
            Console.WriteLine("Numara       :" + this.Numara);
            Console.WriteLine("Sınıf        :" + this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif++;
        }

        public void SinifDusur()
        {
            this.Sinif--;
        }
    }
}
