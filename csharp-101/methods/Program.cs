using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int sonuc = instance.ArttırVeTopla(ref x, ref y);

            public int ArttırVeTopla (ref int x, ref int y)
            {
                x+=1;
                y+=y;
                return (x+y);
            }
        }
    }
}
