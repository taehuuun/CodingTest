string[] strings = new string[5];

int maxLength = 0;

for (int i = 0; i < 5; i++)
{
    strings[i] = Console.ReadLine();
    maxLength = Math.Max(strings[i].Length, maxLength);
}

for (int x = 0; x < maxLength; x++)
{
    for (int y = 0; y < 5; y++)
    {
        if (x < strings[y].Length)
        {
            Console.Write(strings[y][x]);
        }
    }
}