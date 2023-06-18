while (true)
{
    int n = int.Parse(Console.ReadLine());
    int sum = 0;
    if (n == 0)
    {
        return;
    }

    for (int i = n; i > 0; i--)
    {
        sum += i;
    }
    
    Console.WriteLine(sum);
}