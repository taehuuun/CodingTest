int x = int.Parse(Console.ReadLine());

var index = x % 3;

if (index == 0)
{
    Console.WriteLine("S");
}
else
{
    Console.WriteLine("UOS"[index-1]);
}
