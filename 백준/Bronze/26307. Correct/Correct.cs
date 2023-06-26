string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int h = int.Parse(splitInput[0]);
int m = int.Parse(splitInput[1]);

int startMin = 540;
int endMin = h * 60 + m;

Console.WriteLine(endMin - startMin);