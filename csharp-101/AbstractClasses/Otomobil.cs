namespace AbstractClasses
{
    public abstract class Otomobil
    {
        // herkes için standart
        public int KacTekerlekli()
        {
            return 4;
        }
        // çoğu için geçerli ama override edilebilir
        public virtual Renk VarsayilanRenkNe()
        {
            return Renk.Beyaz;
        }
        // her araba kendine özel doldurmalı
        public abstract Marka HangiMarka();
    }
}