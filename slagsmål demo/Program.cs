int card = Random.Shared.Next(52);
System.Console.WriteLine(card);

System.Console.WriteLine("Skriv in ditt namn");
String name = Console.ReadLine();

while (name.Length < 3)
{
    System.Console.WriteLine("Du får inte");
    name = Console.ReadLine();
}

Console.WriteLine($"hej {name}");



Console.ReadLine();