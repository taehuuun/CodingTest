using System.Numerics;

string input = Console.ReadLine();
string[] splitInput = input.Split();
BigInteger money = BigInteger.Parse(splitInput[0]);
BigInteger organismCnt = BigInteger.Parse(splitInput[1]);

Console.WriteLine(money/organismCnt);
Console.WriteLine(money%organismCnt);