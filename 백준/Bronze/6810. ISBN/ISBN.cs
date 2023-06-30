int sum = 91;

for (int i = 0; i < 3; i++)
{
    if (i % 2 == 0)
    {
        sum += int.Parse(Console.ReadLine());
    }
    else
    {
        sum += int.Parse(Console.ReadLine()) * 3;
    }
}

Console.WriteLine($"The 1-3-sum is {sum}");