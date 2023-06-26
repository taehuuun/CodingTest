string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int haveMoney = 100 * int.Parse(splitInput[0]);

if (haveMoney >= int.Parse(splitInput[1]))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}