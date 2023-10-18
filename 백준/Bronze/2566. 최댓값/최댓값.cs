int maxValue = int.MinValue;
int maxY = 0;
int maxX = 0;

for (int y = 1; y <= 9; y++)
{
    int[] inputRow = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    for (int x = 1; x <= inputRow.Length; x++)
    {
        if (maxValue < inputRow[x - 1])
        {
            maxValue = inputRow[x - 1];
            maxY = y;
            maxX = x;
        }
    }
}

Console.WriteLine($"{maxValue}");
Console.WriteLine($"{maxY} {maxX}");