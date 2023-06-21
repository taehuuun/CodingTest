string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int a = int.Parse(splitInput[0]);
int b = int.Parse(splitInput[1]);
int c = int.Parse(splitInput[2]);

Console.WriteLine((a + b) % c);
Console.WriteLine(((a % c) + (b % c)) % c);
Console.WriteLine((a * b) % c);
Console.WriteLine(((a % c) * (b % c)) % c);