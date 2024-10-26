int n = int.Parse(Console.ReadLine());

for (int i = 0; i < 3; i++)
{
    string line = Console.ReadLine();

    if (!line.Contains('7'))
    {
        Console.WriteLine("0");
        return;
    }
}

Console.WriteLine("777");