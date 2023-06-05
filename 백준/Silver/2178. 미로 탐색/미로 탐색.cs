string inputSize = Console.ReadLine();
string[] splitSize = inputSize.Split(' ');

int n = int.Parse(splitSize[0]);
int m = int.Parse(splitSize[1]);

char[,] map = new char[n, m];
int[,] visited = new int[n, m];
int[] dirX = { 0, 0, -1, 1 };
int[] dirY = { -1, 1, 0, 0 };

int distance = 0;

for (int i = 0; i < n; i++)
{
    string inputRow = Console.ReadLine();

    for (int j = 0; j < inputRow.Length; j++)
    {
        map[i, j] = inputRow[j];
    }
}

Queue<(int,int)> queue = new Queue<(int, int)>();

visited[0,0] = 1;
queue.Enqueue((0,0));

while (queue.Count > 0)
{
    var curPos = queue.Peek();
    queue.Dequeue();

    for (int i = 0; i < 4; i++)
    {
        int nextX = curPos.Item1 + dirX[i];
        int nextY = curPos.Item2 + dirY[i];

        if (nextX >= 0 && nextX < m && nextY >= 0 && nextY < n && map[nextY, nextX] == '1' && visited[nextY, nextX] == 0)
        {
            queue.Enqueue((nextX,nextY));
            visited[nextY, nextX] = visited[curPos.Item2, curPos.Item1] +1;
        }
    }
}

Console.WriteLine(visited[n-1,m-1]);