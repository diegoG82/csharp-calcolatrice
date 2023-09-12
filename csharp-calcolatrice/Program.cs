
using csharp_calcolatrice;

while (true)
{
    Console.WriteLine("Quale operazione vuoi fare?");
    Console.WriteLine("1 - Somma di numeri interi");
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

    if (scelta == "Esci")
    {
        break;
    }

}





