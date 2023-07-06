string inputBalance = Console.ReadLine();
string[] splitInputBalance = inputBalance.Split(' ');

int balanceA = int.Parse(splitInputBalance[0]);
int balanceB = int.Parse(splitInputBalance[1]);

int chickenCost = int.Parse(Console.ReadLine());

if (balanceA + balanceB >= chickenCost * 2)
{
    Console.WriteLine((balanceA + balanceB) - chickenCost * 2);
}
else
{
    Console.WriteLine(balanceA + balanceB);
}