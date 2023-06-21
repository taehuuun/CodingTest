using System.Numerics;

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

BigInteger a = BigInteger.Parse(splitInput[0]);
BigInteger b = BigInteger.Parse(splitInput[1]);

Console.WriteLine(a * b);