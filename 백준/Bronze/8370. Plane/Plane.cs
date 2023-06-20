string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int n1 = int.Parse(splitInput[0]);
int k1 = int.Parse(splitInput[1]);
int n2 = int.Parse(splitInput[2]);
int k2 = int.Parse(splitInput[3]);

Console.WriteLine(n1*k1 + n2*k2);