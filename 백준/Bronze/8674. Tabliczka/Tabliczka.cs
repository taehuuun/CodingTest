string input = Console.ReadLine();
string[] splitInput = input.Split(' ');
long a  = long.Parse(splitInput[0]);
long b  = long.Parse(splitInput[1]);

if (a % 2 == 0 || b % 2 == 0)
{
    Console.WriteLine("0");
    return;
}

Console.WriteLine(Math.Min(a,b));