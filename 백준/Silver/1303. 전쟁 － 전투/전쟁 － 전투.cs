int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int horizontal = input[0];
int vertical = input[1];

string[] map = new string[vertical];
bool[,] visited = new bool[vertical, horizontal];

int[] dirX = { 0, 0, -1, 1 };
int[] dirY = { -1, 1, 0, 0 };

int white = 0;
int blue = 0;

for (int y = 0; y < vertical; y++)
{
    map[y] = Console.ReadLine();
}

for (int y = 0; y < vertical; y++)
{
    for (int x = 0; x < horizontal; x++)
    {
        if (visited[y, x])
        {
            continue;
        }

        char currentTeam = map[y][x]; 
        int count = DFS(x, y,currentTeam);

        if (currentTeam == 'W')
        {
            white += count * count;
        }
        else
        {
            blue += count * count;
        }
    }
}

Console.WriteLine($"{white} {blue}");

int DFS(int x, int y, char team)
{
    int count = 1;

    visited[y, x] = true;

    for (int i = 0; i < 4; i++)
    {
        int nextX = x + dirX[i];
        int nextY = y + dirY[i];

        if(nextY < 0 || nextY >= vertical)
            continue;
        if (nextX < 0 || nextX >= horizontal)
            continue;
        if (visited[nextY, nextX])
            continue;
        if(map[nextY][nextX] != team)
            continue;

        count += DFS(nextX, nextY, team);
    }

    return count;
}