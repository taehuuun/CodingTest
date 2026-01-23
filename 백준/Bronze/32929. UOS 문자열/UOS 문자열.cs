int x = int.Parse(Console.ReadLine());

var index = x % 3;

switch (index % 3)
{
    case 0:
        Console.WriteLine("S");
        break;
    case 1:
        Console.WriteLine("U");
        break;
    case 2:
        Console.WriteLine("O");
        break;
}