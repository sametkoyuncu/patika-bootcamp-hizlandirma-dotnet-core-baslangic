using System;

namespace structYapi
{
    class Program
    {
        static void Main(string[] args)
        {
            // neden struct
            // 16byte a kadar olan verilen için struct daha uygun (performanslı)
            // 16byte üstü class'dan devam
            Dikdorgen d = new Dikdorgen();
            d.x = 3;
            d.y = 4;
            Console.WriteLine("Class Alan: " + d.Alan());

            // Dikdortgen_Struct ds = new Dikdortgen_Struct();
            Dikdortgen_Struct ds; // new ile de new siz de olur
            ds.x = 3;
            ds.y = 4;
            Console.WriteLine("Struct Alan: " + ds.Alan());
        }
    }

    class Dikdorgen
    {
        public int x;
        public int y;

        public long Alan()
        {
            return this.x * this.y;
        }
    }
    // parametresiz constructor a izin vermiyor
    struct Dikdortgen_Struct
    {
        public int x;
        public int y;
        public long Alan()
        {
            return this.x * this.y;
        }
    }

}
