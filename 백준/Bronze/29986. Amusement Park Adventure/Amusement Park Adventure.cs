int[] nh = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int[] minHeight = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int result = 0;

for (int i = 0; i < minHeight.Length; i++)
{
    if (nh[1] >= minHeight[i])
    {
        result++;
    }
}

Console.WriteLine(result);