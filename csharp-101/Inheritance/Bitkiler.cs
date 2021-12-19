namespace Inheritance
{
    public class Bitkiler : Canlilar
    {
        protected void Fotosensez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosensez();
        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler, tohumla çoğalır.");
        }
    }

    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosensez();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler, sporla çoğalır.");
        }
    }
}