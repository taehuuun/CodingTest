string first = Console.ReadLine();
string second = Console.ReadLine();

string[] splitFirst = first.Split(' ');
string[] splitSecond = second.Split(' ');

int a = int.Parse(splitFirst[0]) + int.Parse(splitSecond[1]);
int b = int.Parse(splitFirst[1]) + int.Parse(splitSecond[0]);

Console.WriteLine(Math.Min(a,b));