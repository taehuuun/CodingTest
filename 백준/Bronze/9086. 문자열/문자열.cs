int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string inputStr = Console.ReadLine();

    if (inputStr.Length == 1)
    {
        Console.WriteLine(new string(inputStr[0],2));
    }
    else if (inputStr.Length == 2)
    {
        Console.WriteLine(inputStr);
    }
    else
    {
        Console.WriteLine($"{inputStr[0]}{inputStr[inputStr.Length-1]}");
    }
}