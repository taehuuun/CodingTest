using System.Numerics;

BigInteger[] k = Array.ConvertAll(Console.ReadLine().Split(" "), BigInteger.Parse);
BigInteger[] r = Array.ConvertAll(Console.ReadLine().Split(" "), BigInteger.Parse);
BigInteger[] h = Array.ConvertAll(Console.ReadLine().Split(" "), BigInteger.Parse);

BigInteger result = (k[0] * k[1] + r[0] * r[1]) * h[0] * h[1] * h[2];

Console.WriteLine(result);