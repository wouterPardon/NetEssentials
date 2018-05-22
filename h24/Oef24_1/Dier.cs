namespace Oef24_1
{
    public abstract class Dier
    {
        public int Gewicht { get; set; }


        public Dier(int gewicht)
        {
            Gewicht = gewicht;
        }

        public abstract string say();

    }
}