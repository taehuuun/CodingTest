int[] sun = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] moon = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int sunStart = sun[1] - sun[0];
int moonStart = moon[1] - moon[0];
int cnt = 0;

for (int i = 1; i <= 5000; i++)
{
    if (sunStart == moonStart)
    {
        Console.WriteLine(sunStart);
        break;
    }
    if (i % sun[1] == 0)
    {
        sunStart += sun[1];
    }

    if (i % moon[1] == 0)
    {
        moonStart += moon[1];
    }
}