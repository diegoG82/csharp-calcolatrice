
using csharp_calcolatrice;

while (true)
{
    Console.WriteLine("Quale operazione vuoi fare?");
    Console.WriteLine("1 - Somma di numeri interi");
    Console.WriteLine("2 - Somma di numeri double ");
    Console.WriteLine("3 - Sottrazione di numeri interi");
    Console.WriteLine("4 - Sottrazione di numeri double");
    Console.WriteLine("5 - Moltiplicazione di numeri interi");
    Console.WriteLine("6 - Moltiplicazione di numeri double");
    Console.WriteLine("7 - Valore assoluto di un numero intero");
    Console.WriteLine("8 -Valore assoluto di un numero double");
    Console.WriteLine("Esci dal programma");

    string scelta = Console.ReadLine();

    if (string.IsNullOrEmpty(scelta))
    {
        Console.WriteLine("Seleziona un opzione valida");
        continue;
    }

    if (scelta == "1")
    {
        int a = 5;
        int b = 6;

        int risultato = CalcoliHelper.Somma(a, b);

        Console.WriteLine($"La somma di {a} e {b} e' : {risultato}");
        break;
    }

    if (scelta == "2")
    {
        double a = 5.5;
        double b = 6.5;

        double risultato = CalcoliHelper.Somma(a, b);

        Console.WriteLine($"La somma di {a} e {b} e' : {risultato}");
        break;
    }

    if (scelta == "3")
    {
        int a = 6;
        int b = 5;

        int risultato = CalcoliHelper.Sottrazione(a, b);

        Console.WriteLine($"La sottrazione di {a} e {b} e' : {risultato}");
        break;
    }

    if (scelta == "4")
    {
        double a = 6.5;
        double b = 5.5;

        double risultato = CalcoliHelper.Sottrazione(a, b);

        Console.WriteLine($"La sottrazione di {a} e {b} e' : {risultato}");
        break;
    }

    if (scelta == "5")
    {
        int a = 6;
        int b = 5;

        int risultato = CalcoliHelper.Moltiplicazione(a, b);

        Console.WriteLine($"La moltiplicazione di {a} e {b} e' : {risultato}");
        break;
    }

    if (scelta == "6")
    {
        double a = 5.5;
        double b = 6.5;

        double risultato = CalcoliHelper.Moltiplicazione(a, b);

        Console.WriteLine($"La moltiplicazione di {a} e {b} e' : {risultato}");
        break;
    }

    if (scelta == "7")
    {
        int a = 7;

        int risultato = CalcoliHelper.ValoreAssoluto(a);

        Console.WriteLine($"Il valore assoluto di {a} e' : {risultato}");
        break;
    }

    if (scelta == "8")
    {
        double a = 7.5;

        double risultato = CalcoliHelper.ValoreAssoluto(a);

        Console.WriteLine($"Il valore assoluto di {a} e' : {risultato}");
        break;
    }



    if (scelta == "Esci")
    {
        break;
    }






}





