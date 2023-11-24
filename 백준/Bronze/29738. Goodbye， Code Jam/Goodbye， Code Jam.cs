int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int rank = int.Parse(Console.ReadLine());

    if (rank <= 25)
    {
        Console.WriteLine($"Case #{i+1}: World Finals");
    }
    else if (rank <= 1000)
    {
        Console.WriteLine($"Case #{i+1}: Round 3");
    }
    else if (rank <= 4500)
    {
        Console.WriteLine($"Case #{i + 1}: Round 2");
    }
    else
    {
        Console.WriteLine($"Case #{i + 1}: Round 1");
    }
}