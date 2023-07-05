string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int snackCost = int.Parse(splitInput[0]);
int snackCount = int.Parse(splitInput[1]);
int haveMoney = int.Parse(splitInput[2]);

int result = snackCost * snackCount - haveMoney > 0 ? snackCost * snackCount - haveMoney : 0;

Console.WriteLine(result);