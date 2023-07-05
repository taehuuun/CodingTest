string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int a = int.Parse(splitInput[0]);
int b = int.Parse(splitInput[1]);

int result = a == b ? a : Math.Max(a, b);

Console.WriteLine(result);