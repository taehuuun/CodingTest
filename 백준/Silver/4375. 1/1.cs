int n;

while (int.TryParse(Console.ReadLine(), out n))
{
    long target = 1;
    long len = 1;

    while (true)
    {
        if (target % n == 0)
        {
            break;
        }
        target = 10 * target + 1;
        target %= n;
        len++;
    }
    
    Console.WriteLine(len);
}