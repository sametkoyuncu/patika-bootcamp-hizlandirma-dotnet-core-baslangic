using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.Beslenme(); // tohumlubitkiler.beslenme <- bitkiler <- canliler.beslenme

            Kuslar marti = new Kuslar();
            marti.Solunum();
        }
    }
}
