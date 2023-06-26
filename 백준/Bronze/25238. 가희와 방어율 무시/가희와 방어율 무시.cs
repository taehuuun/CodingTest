string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int a = int.Parse(splitInput[0]);
int b = int.Parse(splitInput[1]);

Console.WriteLine((a * (100 - b) / 100 >= 100) ? 0 : 1);