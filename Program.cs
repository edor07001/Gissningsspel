Random rng = new Random(); int rand1 = rng.Next(101);
Console.Write("Gissa ett heltal mellan 1 och 100: ");
string x = Console.ReadLine();
int tal = int.Parse(x);

int gissning = 1;

while(tal != rand1)
{
    if (tal > 100)
    {
        Console.Write("Gissningen är för hög, gissa mellan 1 och 100: ");
    }

    else if (tal < 1)
    {
        Console.Write("Gissningen är för låg, gissa mellan 1 och 100: ");
    }

    else if (tal > rand1)
    {
        Console.Write("Talet är mindre, gissa igen: ");
    }
    
    else if (tal < rand1)
    {
        Console.Write("Talet är större, gissa igen: ");
    }
    
    tal = int.Parse(Console.ReadLine());
    
    gissning++;
}

Console.WriteLine("Du gissade rätt, grattis. Det tog " + gissning + " försök.");