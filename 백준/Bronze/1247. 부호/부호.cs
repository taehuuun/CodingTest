using System.Numerics;

for (int i = 0; i < 3; i++)
{
    int n = int.Parse(Console.ReadLine());

    BigInteger total = BigInteger.Zero;
    
    for (int j = 0; j < n; j++)
    {
        total += BigInteger.Parse(Console.ReadLine());
    }

    if (total.IsZero)
    {
        Console.WriteLine("0");
    }
    else if (total < 0)
    {
        Console.WriteLine("-");
    }
    else
    {
        Console.WriteLine("+");
    }
}