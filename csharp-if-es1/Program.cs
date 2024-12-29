// dichiaro le variabili
int numero1;
int numero2;

// chiedo all'utente di inserire i numeri
Console.WriteLine("Inserisci il primo numero:");
int.TryParse(Console.ReadLine(), out numero1);

Console.WriteLine("Inserisci il secondo numero:");
int.TryParse(Console.ReadLine(), out numero2);

// se il numero1 è maggiore del numero2
if (numero1 > numero2)
{
    Console.WriteLine("Il primo numero è maggiore del secondo.");
}
else if (numero1 < numero2) // se il numero2 è maggiore del numero1
{
    Console.WriteLine("Il secondo numero è maggiore del primo.");
}
else // altrimenti i numeri sono uguali
{
    Console.WriteLine("I numeri sono uguali");
}
