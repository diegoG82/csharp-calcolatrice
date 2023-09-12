
using csharp_calcolatrice;

//DICHIARAZIONE VALORI INT E DOUBLE CHE USEREMO NELLE NOSTRE FUNZIONI

int a = 5;
int b = 6;
double c = 7.5;
double d = 6.5;

//BASE ED ESPONENTE PER BONUS

int nb = 3;
int ne = 2;

//CICLO WHILE PER SCEGLIERE L'OPERAZIONE DA EFFETTUARE

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
    Console.WriteLine("8 - Valore assoluto di un numero double");
    Console.WriteLine("9 - Valore minimo tra due  numeri interi");
    Console.WriteLine("10 - Valore minimo tra due numeri double");
    Console.WriteLine("11 - Valore massimo tra due  numeri interi");
    Console.WriteLine("12 - Valore massimo tra due numeri double");
    Console.WriteLine("13 - Elevo a potenza");
    Console.WriteLine("Esci dal programma");

    string scelta = Console.ReadLine();

    if (string.IsNullOrEmpty(scelta))
    {
        Console.WriteLine("Seleziona un opzione valida");
        continue;
    }

    if (scelta == "1")
    {
        int risultato = CalcoliHelper.Somma(a, b);
        Console.WriteLine($"La somma di {a} e {b} e' : {risultato}");
    }

    if (scelta == "2")
    {
        double risultato = CalcoliHelper.Somma(c, d);
        Console.WriteLine($"La somma di {c} e {d} e' : {risultato}");
    }

    if (scelta == "3")
    {
        int risultato = CalcoliHelper.Sottrazione(a, b);
        Console.WriteLine($"La sottrazione di {a} e {b} e' : {risultato}");
    }

    if (scelta == "4")
    {
        double risultato = CalcoliHelper.Sottrazione(c, d);
        Console.WriteLine($"La sottrazione di {c} e {d} e' : {risultato}");
    }

    if (scelta == "5")
    {
        int risultato = CalcoliHelper.Moltiplicazione(a, b);
        Console.WriteLine($"La moltiplicazione di {a} e {b} e' : {risultato}");
    }

    if (scelta == "6")
    {
        double risultato = CalcoliHelper.Moltiplicazione(c, d);
        Console.WriteLine($"La moltiplicazione di {c} e {d} e' : {risultato}");
    }

    if (scelta == "7")
    {
        int risultato = CalcoliHelper.ValoreAssoluto(a);
        Console.WriteLine($"Il valore assoluto di {a} e' : {risultato}");
    }

    if (scelta == "8")
    {
        double risultato = CalcoliHelper.ValoreAssoluto(c);
        Console.WriteLine($"Il valore assoluto di {c} e' : {risultato}");
    }

    if (scelta == "9")
    {
        int risultato = CalcoliHelper.ValoreMinimo(a, b);
        Console.WriteLine($"Il minimo tra {a} e {b} e' : {risultato}");
    }

    if (scelta == "10")
    {
        double risultato = CalcoliHelper.ValoreMinimo(c, d);
        Console.WriteLine($"il valore minimo tra {c} e {d} e' : {risultato}");
    }

    if (scelta == "11")
    {
        int risultato = CalcoliHelper.ValoreMassimo(a, b);
        Console.WriteLine($"Il minimo massimo tra {a} e {b} e' : {risultato}");
    }

    if (scelta == "12")
    {
        double risultato = CalcoliHelper.ValoreMassimo(c, d);
        Console.WriteLine($"il valore massimo tra {c} e {d} e' : {risultato}");
    }

    if (scelta == "13")
    {
        int risultato = CalcoliHelper.ElevoAPotenza(nb, ne);
        Console.WriteLine($"il valore di {nb} elevato a {ne} e' : {risultato}");
    }

    if (scelta == "Esci")
    {
        break;
    }






}





