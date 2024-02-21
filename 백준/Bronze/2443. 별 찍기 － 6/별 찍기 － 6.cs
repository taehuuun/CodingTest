int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write(" ");
    }
    
    for (int j = 0; j < n * 2 - (i * 2)-1; j++)
    {
        Console.Write("*");
    }
    
    Console.WriteLine();
}