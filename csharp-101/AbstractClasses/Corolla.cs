namespace AbstractClasses
{
    public class Corolla : IOtomobil
    {
        public int KacTekerlekli()
        {
            return 4;
        }
        public Marka HangiMarka()
        {
            return Marka.Toyota;
        }
        public Renk VarsayilanRenkNe()
        {
            return Renk.Beyaz;
        }
    }
}