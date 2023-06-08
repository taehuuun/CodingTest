string inputStr = Console.ReadLine();
string[] splitInput = inputStr.Split(' ');

int h = int.Parse(splitInput[0]);
int w = int.Parse(splitInput[1]);

int[,] map = new int[h, w];

for (int y = 0; y < h; y++)
{
    string mapData = Console.ReadLine();

    for (int x = 0; x < mapData.Length; x++)
    {
        map[y, x] = mapData[x] == 'c' ? 0 : -1;
    }
}

for (int y = 0; y < h; y++)
{
    int lasValue = -1;
    for (int x = 0; x < w; x++)
    {
        if (map[y, x] == 0)
        {
            lasValue = 0;
        }
        else if(map[y,x] == -1 && lasValue >= 0)
        {
            lasValue++;
            map[y, x] = lasValue;
        }
    }
}

for (int y = 0; y < h; y++)
{
    for (int x = 0; x < w; x++)
    {
        Console.Write($"{map[y,x]} ");
    }
    
    Console.WriteLine();
}