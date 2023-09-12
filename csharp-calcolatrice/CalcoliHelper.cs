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
            return Math.Abs(a);
        }

        //Valore Assoluto numero double
        public static double ValoreAssoluto(double a)
        {
            return Math.Abs(a);
        }
    }

}
