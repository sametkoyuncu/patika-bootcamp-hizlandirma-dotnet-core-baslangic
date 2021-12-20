namespace AbstractClasses
{
    public class Focus : IOtomobil
    {
        public int KacTekerlekli()
        {
            return 4;
        }
        public Marka HangiMarka()
        {
            return Marka.Ford;
        }
        public Renk VarsayilanRenkNe()
        {
            return Renk.Beyaz;
        }
    }
}