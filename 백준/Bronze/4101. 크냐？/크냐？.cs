while (true)
{
    string input = Console.ReadLine();

    if (input == "0 0")
    {
        return;
    }

    string[] splitInput = input.Split(' ');

    int a = int.Parse(splitInput[0]);
    int b = int.Parse(splitInput[1]);

    if (a > b)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}