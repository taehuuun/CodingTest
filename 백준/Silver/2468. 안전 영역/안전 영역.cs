int n = int.Parse(Console.ReadLine());

int[,] map = new int[n,n];
bool[,] visited = new bool[n,n];

int[] dirX = { 0, 0, -1, 1 };
int[] dirY = { -1, 1, 0, 0 };

int maxHeight = int.MinValue;
int maxSafeArea = int.MinValue;

for (int i = 0; i < n; i++)
{
    string inputRow = Console.ReadLine();
    string[] splitRow = inputRow.Split(' ');

    for (int j = 0; j < splitRow.Length; j++)
    {
        int height = int.Parse(splitRow[j]);
        map[i, j] = height;

        if (maxHeight < height)
        {
            maxHeight = height;
        }
    }
}

for (int curHeight = 0; curHeight <= maxHeight; curHeight++)
{
    int curSafeArea = 0;
    visited = new bool[n, n];
    
    for (int y = 0; y < n; y++)
    {
        for (int x = 0; x < n; x++)
        {
            if (map[y, x] > curHeight && !visited[y, x])
            {
                DFS(x, y, curHeight);
                curSafeArea++;
            }
        }
    }
    
    
    if (maxSafeArea < curSafeArea)
    {
        maxSafeArea = curSafeArea;
    }
}

Console.WriteLine(maxSafeArea);

void DFS(int x, int y, int height)
{
    if (visited[y, x])
    {
        return;
    }

    visited[y, x] = true;

    for (int i = 0; i < 4; i++)
    {
        int nextX = x + dirX[i];
        int nextY = y + dirY[i];

        if (nextX >= 0 && nextX < n &&
            nextY >= 0 && nextY < n &&
            map[nextY, nextX] > height && !visited[nextY, nextX]
           )
        {
            DFS(nextX, nextY, height);
        }
    }
}