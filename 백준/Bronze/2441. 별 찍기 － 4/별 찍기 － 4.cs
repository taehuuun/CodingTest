int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    for (int j = n - i; j > 0; j--)
    {
        Console.Write("*");
    }

    if (i < n - 1)
    {
        Console.WriteLine();
    }
}