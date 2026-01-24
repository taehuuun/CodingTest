using System.Numerics;

BigInteger[] input = Array.ConvertAll(Console.ReadLine().Split(" "), BigInteger.Parse);

Array.Sort(input);

Console.WriteLine(input[1]);