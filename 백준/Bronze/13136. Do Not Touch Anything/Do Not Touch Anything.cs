using System.Numerics;

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

BigInteger r = BigInteger.Parse(splitInput[0]);
BigInteger c = BigInteger.Parse(splitInput[1]);
BigInteger n = BigInteger.Parse(splitInput[2]);

BigInteger row = r/n + (r%n == 0 ? 0 : 1);
BigInteger col = c/n + (c%n == 0 ? 0 : 1);
BigInteger result = row * col;

Console.WriteLine(result);