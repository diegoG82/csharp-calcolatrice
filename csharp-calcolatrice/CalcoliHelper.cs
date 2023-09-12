namespace csharp_calcolatrice
{

    public static class CalcoliHelper
    {
        //Somma:
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        public static double Somma(double a, double b)
        {
            return a + b;
        }

        //Differenza:
        public static int Sottrazione(int a, int b)
        {
            return a - b;
        }

        public static double Sottrazione(double a, double b)
        {
            return a - b;
        }

        //Moltiplicazione

        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        //Valore assoluto numero intero 
        public static int ValoreAssoluto(int a)
        {
            if (a < 0)
            {
                return a * -1;
            }
            else
            {
                return a;
            }

            //return Math.Abs(a)

        }

        //Valore Assoluto numero double
        public static double ValoreAssoluto(double a)
        {
            //return Math.Abs(a);

            if (a < 0)
            {
                return a * -1;
            }
            else
            {
                return a;
            }
        }

        //Minimo tra due numeri interi
        public static int ValoreMinimo(int a, int b)
        {
            return Math.Min(a, b);
        }

        //Minimo tra due numeri double
        public static double ValoreMinimo(double c, double d)
        {
            return Math.Min(c, d);
        }

        //Massimo tra due numeri interi
        public static int ValoreMassimo(int a, int b)
        {
            return Math.Max(a, b);
        }

        //Massimo tra due numeri double
        public static double ValoreMassimo(double c, double d)
        {
            return Math.Max(c, d);
        }

        //BONUS: Elevazione a potenza

        public static int ElevoAPotenza(int nb, int ne)
        {
            if (nb == 0 && ne == 0)
                return 1;
            else
            {
                return (int)Math.Pow(nb, ne);
            }
        }

    }

}
