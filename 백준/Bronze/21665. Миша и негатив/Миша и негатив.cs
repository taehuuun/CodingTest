int[] inputSize = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

string[] origin = new string[inputSize[0]];
string[] reverse = new string[inputSize[0]];

int count = 0;

for (int i = 0; i < origin.Length; i++)
{
    origin[i] = Console.ReadLine();
}
Console.ReadLine();

for (int i = 0; i < reverse.Length; i++)
{
    reverse[i] = Console.ReadLine();
}

for (int y = 0; y < inputSize[0]; y++)
{
    for (int x = 0; x < inputSize[1]; x++)
    {
        if (origin[y][x] == reverse[y][x])
        {
            count++;
        }
    }
}

Console.WriteLine(count);