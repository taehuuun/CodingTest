int n = int.Parse(Console.ReadLine());

int minValue= int.MaxValue;

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    minValue = Math.Min(input[0] + input[1], minValue);
}

Console.WriteLine(minValue);