int[] nm = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] basket = new int[nm[0]];

for (int i = 0; i < nm[1]; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    for (int j = input[0] - 1; j < input[1]; j++)
    {
        basket[j] = input[2];
    }
}

Console.WriteLine(string.Join(' ',basket));