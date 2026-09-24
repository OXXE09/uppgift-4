int hp1 = 20;
int hp2 = 20;
Console.WriteLine("vad ska din karaktär heta");
Console.WriteLine("");
string player1 = "";

while (player1 == "")
{
    player1 = Console.ReadLine();
}

Console.WriteLine("");
Console.WriteLine("du har valt namnet " + player1);
Console.WriteLine("");
Console.WriteLine("vad ska din motstondare karaktär heta");
Console.WriteLine("");
string player2 = "";

while (player2 == "")
{
    player2 = Console.ReadLine();
}

Console.WriteLine("");
Console.WriteLine("spelare 2 namne är " + player2);
Console.WriteLine("");
Console.WriteLine("reglarna är att du får välja att antligen slå eller blocka. båda karaktär har 10 hp");
Console.WriteLine("så vad gör du " + player1 + ", 1 (slå kan ta 1 till 5hp) eller 2 (sparka kan ta upp 0 till 10hp)");



while (hp1 > 0 && hp2 > 0)
{
int slo = Random.Shared.Next(1, 5);
int sparka = Random.Shared.Next(0, 10);
    Console.WriteLine(player1 + " hp är " + hp1 + " och " + player2 + " hp är " + hp2);
    string player1val = "";
    while (player1val == "")
    {
        player1val = Console.ReadLine();
    }

    if (player1val == "1")
    {
        hp2 -= slo;
    }
    else
    {
        hp2 -= sparka;
    }
    Console.WriteLine("det är " + player2 + " tur, så vad väljer du");
    string player2val = "";
    while (player2val == "")
    {
        player2val = Console.ReadLine();
    }
    if (player2val == "1")
    {
        hp1-=slo;
    }
    else
    {
        hp1 -= sparka;
    }
}
if (hp1 == 0 && hp2 == 0)
{
    Console.WriteLine("wow trorde inte det skulle hända, Det blev lika");
}
else
{
    if (hp1 == 0)
    {
        Console.WriteLine(player2 + " du van!!!!");
    }
    else
    {
        Console.WriteLine(player1 + "du van!!!!");
    }
}
    Console.ReadLine();