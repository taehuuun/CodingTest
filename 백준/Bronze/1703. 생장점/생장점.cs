while (true)
{
    string input = Console.ReadLine();

    if (input == "0")
    {
        return;
    }

    int total = 1;
    string[] split = input.Split(' ');

    int count = int.Parse(split[0]);

    for (int i = 1; i <= count * 2; i += 2)
    {
        total *= int.Parse(split[i]);
        total -= int.Parse(split[i+ 1]);
    }
    
    Console.WriteLine(total);
}