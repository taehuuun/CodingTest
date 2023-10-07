int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int height = input[0];

for (int i = 0; i < input[1]; i++)
{
    if (height % 2 == 0)
    {
        height = (int)(height * 0.5f) ^ 6;
    }
    else
    {
        height = (2 * height) ^ 6;
    }
}

Console.WriteLine(height);