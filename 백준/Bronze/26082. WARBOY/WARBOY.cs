string input = Console.ReadLine();
string[] splintInput = input.Split(' ');

int a = int.Parse(splintInput[0]);
int b = int.Parse(splintInput[1]);
int c = int.Parse(splintInput[2]);

int rivalCostEffect = b / a;
int warBoyCostEffect = rivalCostEffect * 3;

int warBoyEffect = warBoyCostEffect * c;

Console.WriteLine(warBoyEffect);