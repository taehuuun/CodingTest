int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    for (int j = 0; j <= n - i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}