namespace AbstractClasses
{
    public class Civic : IOtomobil
    {
        public int KacTekerlekli()
        {
            return 4;
        }
        public Marka HangiMarka()
        {
            return Marka.Honda;
        }
        public Renk VarsayilanRenkNe()
        {
            return Renk.Gri;
        }
    }
}