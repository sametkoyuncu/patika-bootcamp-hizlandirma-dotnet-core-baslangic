using System;
using System.Collections;

namespace arraylists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add("Ali");
            liste.Add(4);
            liste.Add(true);
            liste.Add('A');

            // AddRamge
            liste.AddRange("Mor", 2, 'B');

            // Sort
            // liste.Sort();

            // BinarySearch - önce sıralayıp sonra bunun kullanmamız gerekiyor
            liste.BinarySearch("Mor");

            // Reverse - ters çevir
            liste.Reverse();


        }
    }
}
