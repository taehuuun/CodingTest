using System.Net.NetworkInformation;

List<int> complexCount = new List<int>(); 
int n = int.Parse(Console.ReadLine());

int[,] map = new int[n,n];

int[] dirX = { 0, 0, -1, 1 };
int[] dirY = { -1, 1, 0, 0 };

int count = 0;

for (int row = 0; row < n; row++)
{
    string input = Console.ReadLine();

    for (int i = 0; i < input.Length; i++)
    {
        map[row, i] = input[i]-'0';
    }
}

void DFS(int row, int col)
{
    map[row, col] = 0;
    count++;
    
    for (int i = 0; i < 4; i++)
    {
        int nextX = col + dirX[i];
        int nextY = row + dirY[i];

        if (0 <= nextX && nextX < n && 0 <= nextY && nextY < n && map[nextY, nextX] == 1)
        {
            DFS(nextY,nextX);
        }
    }
}
for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        count = 0;
        
        if (map[row, col] == 1)
        {
            DFS(row, col);
            complexCount.Add(count);
        }
    }
}

complexCount.Sort();

Console.WriteLine($"{complexCount.Count}");

for (int i = 0; i < complexCount.Count; i++)
{
    Console.WriteLine($"{complexCount[i]}");
}
