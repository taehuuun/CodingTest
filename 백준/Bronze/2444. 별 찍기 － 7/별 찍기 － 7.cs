int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n * 2 - 1; i++)
{
    // n - 1 번째 까지 작업
    if (i < n)
    {
        for (int j = 0; j < n - i; j++)
        {
            Console.Write(" ");
        }

        for (int j = 0; j < (i-1) * 2 + 1; j++)
        {
            Console.Write("*");
        }
    }
    // n 번째까지 작업
    else if (i == n)
    {
        for (int j = 0; j < n * 2-1; j++)
        {
            Console.Write("*");
        }
    }
    // n + 1 부터 작업
    else
    {
        // 공백 작업
        for (int j = 0; j < i - n; j++)
        {
            Console.Write(" ");
        }
        
        // 별 찍는 작업
        for (int j = 0; j < n * 2 - ((i - n) * 2)-1; j++)
        {
            Console.Write("*");
        }
    }
    
    if(i <  n * 2 - 1)
        Console.WriteLine();
}