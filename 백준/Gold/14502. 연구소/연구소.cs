string inputSize = Console.ReadLine();
string[] splitSize = inputSize.Split(' ');

int h = int.Parse(splitSize[0]);
int w = int.Parse(splitSize[1]);

int[,] map = new int[h, w];
bool[,] visited;

List<(int y, int x)> wallPair = new List<(int y, int x)>();
List<(int y, int x)> virusPair = new List<(int y, int x)>();

int[] dirX ={0, 0, -1, 1};
int[] dirY ={1, -1, 0, 0};

int result = -1;

for (int y = 0; y < h; y++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    for (int x = 0; x < splitInput.Length; x++)
    {
        map[y, x] = int.Parse(splitInput[x]);
        
        if (map[y,x] == 0)
        {
            wallPair.Add((y,x));
        }
        else if (map[y,x] == 2)
        {
            virusPair.Add((y, x));
        }
    }
}

for (int i = 0; i < wallPair.Count; i++)
{
    for (int j = 0; j < i; j++)
    {
        for (int k = 0; k < j; k++)
        {
            map[wallPair[i].y, wallPair[i].x] = 1;
            map[wallPair[j].y, wallPair[j].x] = 1;
            map[wallPair[k].y, wallPair[k].x] = 1;
            result = Math.Max(result, Solve());
            map[wallPair[i].y, wallPair[i].x] = 0;
            map[wallPair[j].y, wallPair[j].x] = 0;
            map[wallPair[k].y, wallPair[k].x] = 0;
        }
    }
}

Console.WriteLine(result);

int Solve()
{
    visited = new bool[h, w];

    foreach (var virus in virusPair)
    {
        visited[virus.y, virus.x] = true;
        DFS(virus.x,virus.y);
    }

    int count = 0;

    for (int i = 0; i < h; i++)
    {
        for (int j = 0; j < w; j++)
        {
            if (map[i, j] == 0 && !visited[i, j])
                count++;
        }
    }

    return count;
}

void DFS(int x, int y)
{
    for(int i = 0; i < 4; i++)
    {
        int ny = y + dirY[i];
        int nx = x + dirX[i];
        
        if(ny < 0 || ny >= h || nx < 0 || nx >= w || visited[ny,nx] || map[ny,nx] == 1) 
            continue;

        visited[ny, nx] = true;
        DFS(nx, ny);
    }
}