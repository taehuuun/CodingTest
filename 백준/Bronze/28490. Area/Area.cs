int n = int.Parse(Console.ReadLine());

int maxSize = int.MinValue;

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    maxSize = Math.Max(input[0] * input[1], maxSize);
}

Console.WriteLine(maxSize);