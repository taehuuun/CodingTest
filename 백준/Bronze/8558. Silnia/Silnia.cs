int n = int.Parse(Console.ReadLine());

if (n is 0 or 1)
{
    Console.WriteLine("1");
}
else if (n > 4)
{
    Console.WriteLine("0");
}
else
{
    int factorial = 1;

    for (int i = 2; i <= n; i++)
    {
        factorial *= i;
    }
    
    Console.WriteLine(factorial%10);
}