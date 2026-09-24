int hp1 = 10;
int hp2 = 10;
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
Console.WriteLine("så vad gör du " + player1 + ", 1 (slå tar 1hp) eller 2 (sparka tar 2hp)");


while (hp1 > 0 && hp2 > 0)
{
    Console.WriteLine(player1 + " hp är " + hp1 + " och " + player2 + " hp är " + hp2);
    string player1val = "";
    while (player1val == "")
    {
        player1val = Console.ReadLine();
    }

    if (player1val == "1")
    {
        hp2--;
    }
    else
    {
        hp2 -= 2;
    }
    Console.WriteLine("det är " + player2 + " tur, så vad väljer du");
    string player2val = "";
    while (player2val == "")
    {
        player2val = Console.ReadLine();
    }
    if (player2val == "1")
    {
        hp1--;
    }
    else
    {
        hp1 -= 2;
    }
}
if (hp1 == 0 && hp2 == 0)
{
    Console.WriteLine("wow trorde inte det skulle hända");
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