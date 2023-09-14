int temp = int.Parse(Console.ReadLine());

int pascal = 5 * temp  - 400;

Console.WriteLine($"{pascal}");
if (pascal > 100)
{
    Console.WriteLine("-1");
}
else if (pascal == 100)
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine("1");
}