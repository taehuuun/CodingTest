int[] mapSize = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

char[,] map = new char[mapSize[0], mapSize[1]];

int minCount = int.MaxValue;

string[] wStartBoard =
{
    "WBWBWBWB",
    "BWBWBWBW",
    "WBWBWBWB",
    "BWBWBWBW",
    "WBWBWBWB",
    "BWBWBWBW",
    "WBWBWBWB",
    "BWBWBWBW"
};

string[] bStartBoard =
{
    "BWBWBWBW",
    "WBWBWBWB",
    "BWBWBWBW",
    "WBWBWBWB",
    "BWBWBWBW",
    "WBWBWBWB",
    "BWBWBWBW",
    "WBWBWBWB"
};

for (int y = 0; y < mapSize[0]; y++)
{
    string inputRow = Console.ReadLine();

    for (int x = 0; x < inputRow.Length; x++)
    {
        map[y,x] = inputRow[x];
    }
}

for (int y = 0; y+8 <= map.GetLength(0); y++)
{
    for (int x = 0; x+8 <= map.GetLength(1); x++)
    {
        minCount = Math.Min(minCount, GetCountBoard(x, y));
    }
}

Console.WriteLine(minCount);

int GetCountBoard(int curX, int curY)
{
    int wCount = 0;
    int bCount = 0;
    
    for (int y = 0; y < 8; y++)
    {
        for (int x = 0; x  <  8; x++)
        {
            if (wStartBoard[y][x] != map[curY + y, curX + x])
            {
                wCount++;
            }

            if (bStartBoard[y][x] != map[curY + y, curX + x])
            {
                bCount++;
            }
        }
    }

    return Math.Min(wCount, bCount);
}