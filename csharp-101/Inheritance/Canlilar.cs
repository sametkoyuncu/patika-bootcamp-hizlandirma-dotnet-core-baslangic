namespace Inheritance
{
    // method'lar protected yapılıp kalıtım alanların constructor'ında base. ile çağır..
    public class Canlilar
    {
        public void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }

        public void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        public void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }
    }
}