int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int vertical = input[0];
int horizontal = input[1];

char[,] map = new char[vertical, horizontal];
bool[,] visited = new bool[vertical, horizontal];
int[,] distance = new int[vertical, horizontal];

int[] dirX = { 0, 0, -1, 1 };
int[] dirY = { -1, 1, 0, 0 };

for (int y = 0; y < vertical; y++)
{
    string row = Console.ReadLine();

    for (int x = 0; x < row.Length; x++)
    {
        map[y, x] = row[x];
    }
}

distance[0, 0] = 1;
BFS(0,0);

Console.WriteLine(distance[vertical-1, horizontal-1]);

void BFS(int x, int y)
{
    Queue<Position> queue = new Queue<Position>();
    
    queue.Enqueue(new Position(x,y));
    visited[y, x] = true;
    
    while (queue.Count > 0)
    {
        Position currentPos = queue.Dequeue();

        for (int i = 0; i < 4; i++)
        {
            int nextX = currentPos.X + dirX[i];
            int nextY = currentPos.Y + dirY[i];
            
            if(nextX < 0 || nextX >= horizontal)
                continue;
            if(nextY < 0 || nextY >= vertical)
                continue;
            if(visited[nextY,nextX])
                continue;
            if(map[nextY, nextX] != '1')
                continue;

            visited[nextY, nextX] = true;
            queue.Enqueue(new Position(nextX, nextY));
            distance[nextY, nextX] = distance[currentPos.Y, currentPos.X] + 1;
        }
    }
}

class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position() : this(0, 0) { }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }
}