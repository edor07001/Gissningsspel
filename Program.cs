Random rng = new Random(); int rand1 = rng.Next(101);
Console.WriteLine("Gissa ett heltal mellan 1 och 100:");
string x = Console.ReadLine();
int tal = int.Parse(x);

int y = 1;

while(tal != rand1)
{
    if (tal > 100)
    {
        Console.WriteLine("Gissningen är för hög gissa mellan 1 och 100");
    }

    else if (tal < 1)
    {
        Console.WriteLine("Gissningen är för låg gissa mellan 1 och 100");
    }

    else if (tal > rand1)
    {
        Console.WriteLine("Talet är mindre, gissa igen:");
    }
    
    else if (tal < rand1)
    {
        Console.WriteLine("Talet är större, gissa igen:");
    }
    
    tal = int.Parse(Console.ReadLine());
    
    y++;
}

Console.WriteLine("Du gissade rätt, grattis. Det tog " + y + " försök.");