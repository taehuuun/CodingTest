using System.Numerics;

int n = int.Parse(Console.ReadLine());
BigInteger total = BigInteger.One;

for (int i = 2; i <= n; i++)
{
    total += (int)Math.Pow(i, 3);
}

Console.WriteLine(total);