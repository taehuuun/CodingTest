int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int inputNum = int.Parse(Console.ReadLine());

    if (inputNum % 2 == 0)
    {
        Console.WriteLine($"{inputNum} is even");
    }
    else
    {
        Console.WriteLine($"{inputNum} is odd");
    }
}