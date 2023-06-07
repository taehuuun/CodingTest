string inputInfo = Console.ReadLine();
string[] splitInfo = inputInfo.Split(' ');

int n = int.Parse(splitInfo[0]);
int m = int.Parse(splitInfo[1]);
int k = int.Parse(splitInfo[2]);

int[,] map = new int[n,m];
bool[,] visited = new bool[n,m];

int[] dirX = { 0, 0, -1, 1 };
int[] dirY = { -1, 1, 0, 0 };

List<int> areaSizes = new List<int>();
int areaCnt = 0;
int areaSize = 0;

for (int i = 0; i < k; i++)
{
    string inputCoord = Console.ReadLine();
    string[] splitCoord = inputCoord.Split(' ');
    
    int x1 = int.Parse(splitCoord[0]);
    int y1 = int.Parse(splitCoord[1]);
    int x2 = int.Parse(splitCoord[2]);
    int y2 = int.Parse(splitCoord[3]);

    for (int y = 0; y < y2 - y1; y++)
    {
        for (int x = 0; x < x2 - x1; x++)
        {
            map[y1+y, x1+x] = 1;
        }
    }
}

for (int y = 0; y < n; y++)
{
    for (int x = 0; x < m; x++)
    {
        if (map[y, x] == 0 && !visited[y, x])
        {
            areaCnt++;
            areaSize = 0;
            DFS(x, y);
            areaSizes.Add(areaSize);
        }
    }
}

areaSizes.Sort();
Console.WriteLine(areaCnt);
Console.WriteLine($"{string.Join(" ",areaSizes)}");

void DFS(int x, int y)
{
    if (visited[y, x])
    {
        return;
    }

    visited[y, x] = true;
    areaSize++;

    for (int i = 0; i < 4; i++)
    {
        int nextX = x + dirX[i];
        int nextY = y + dirY[i];

        if (nextX >= 0 && nextX < m &&
            nextY >= 0 && nextY < n &&
            map[nextY, nextX] == 0 && !visited[nextY, nextX])
        {
            DFS(nextX,nextY);
        }
    }
}