using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 1, 3, 4, 9, 8, 7 };
            Array.Sort(sayiDizisi);
            Array.Clear(sayiDizisi, 2, 2); // 2. indexten 2 eleman sıfırla
            Array.Reverse(sayiDizisi);
            Array.IndexOf(sayiDizisi, 7);
            Array.Resize<int>(ref sayiDizisi, 12); // 12 elemanlı yapar
            sayiDizisi[6] = 10;
            Array.Resize<int>(ref sayiDizisi, 3); // 3 elemana indirir
        }
    }
}
