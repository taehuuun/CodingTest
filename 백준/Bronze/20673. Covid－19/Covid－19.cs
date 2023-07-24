int p = int.Parse(Console.ReadLine());
int q = int.Parse(Console.ReadLine());

if (p <= 50 && q <= 10)
{
    Console.WriteLine("White");
}
else if (q > 30)
{
    Console.WriteLine("Red");
}
else
{
    Console.WriteLine("Yellow");
}