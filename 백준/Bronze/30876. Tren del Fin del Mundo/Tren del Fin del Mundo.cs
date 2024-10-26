int n = int.Parse(Console.ReadLine());

Dictionary<int, List<int>> dict = new();

int minValue = int.MaxValue;

for (int i = 0; i < n; i++)
{
    int[] coord = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    if (!dict.ContainsKey(coord[1]))
    {
        dict[coord[1]] = new List<int>();
    }
    dict[coord[1]].Add(coord[0]);
 
    minValue = Math.Min(minValue, coord[1]);
}

Console.WriteLine($"{dict[minValue][0]} {minValue}");