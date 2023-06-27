while (true)
{
    string input = Console.ReadLine();

    if (input.Equals("# 0 0"))
        return;

    string[] splitInput = input.Split(' ');

    int age = int.Parse(splitInput[1]);
    int weight = int.Parse(splitInput[2]);

    if (age > 17 || weight >= 80)
    {
        Console.WriteLine($"{splitInput[0]} Senior");
    }
    else
    {
        Console.WriteLine($"{splitInput[0]} Junior");
    }
}