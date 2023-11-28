int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    // 공백 4 ~ 0
    for (int j = n - i; j > 0; j--)
    {
        Console.Write(" ");
    }
    
    // 별 1, 3, 5, 7, 9
    for (int j = 0; j < i * 2 - 1; j++)
    {
        Console.Write("*");
    }

    if (i < n)
    {
        Console.WriteLine();
    }
}