string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int n = int.Parse(splitInput[0]);
int a = int.Parse(splitInput[1]);
int b = int.Parse(splitInput[2]);

if (a < b)
{
    Console.WriteLine("Bus");
}
else if (a > b)
{
    Console.WriteLine("Subway");
}
else
{
    Console.WriteLine("Anything");
}