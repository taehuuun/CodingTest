int n = int.Parse(Console.ReadLine());

int result = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    if (input[0] <= input[1])
    {
        result = Math.Min(result, input[1]);
    }
}

Console.WriteLine($"{(result == int.MaxValue ? -1 : result)}");