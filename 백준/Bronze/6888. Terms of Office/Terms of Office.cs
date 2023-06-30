int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());


for (int i = 0; i <= y-x; i++)
{
    if (i % 4 == 0 && i % 2 == 0 && i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"All positions change in year {x + i}");
    }
}