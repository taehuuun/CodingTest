int n = int.Parse(Console.ReadLine());
int[] levels = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] result = new int[n];

for (int i = 0; i < levels.Length; i++)
{
    if (levels[i] >= 300)
    {
        result[i] = 1;
    }
    else if (levels[i] >= 275)
    {
        result[i] = 2;
    }
    else if (levels[i] >= 250)
    {
        result[i] = 3;
    }
    else
    {
        result[i] = 4;
    }
}

Console.WriteLine(string.Join(' ', result));