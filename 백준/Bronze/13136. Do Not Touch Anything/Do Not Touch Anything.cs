using System.Numerics;

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int r = int.Parse(splitInput[0]);
int c = int.Parse(splitInput[1]);
int n = int.Parse(splitInput[2]);

BigInteger row = r/n + (r%n == 0 ? 0 : 1);
BigInteger col = c/n + (c%n == 0 ? 0 : 1);
BigInteger result = row * col;

Console.WriteLine(result);