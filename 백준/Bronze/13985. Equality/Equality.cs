string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

if (int.Parse(splitInput[0]) + int.Parse(splitInput[2]) == int.Parse(splitInput[4]))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}