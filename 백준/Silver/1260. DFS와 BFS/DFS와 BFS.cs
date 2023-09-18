int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = input[0];
int m = input[1];
int v = input[2];

List<int>[] graph = new List<int>[n];
bool[] visited = new bool[n];

for(int i = 0 ; i < n; i++)
{
    graph[i] = new List<int>();
}

for (int i = 0; i < m; i++)
{
    int[] inputNode = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int nodeNumber = inputNode[0] - 1;
    int linkNumber = inputNode[1] - 1;

    graph[nodeNumber].Add(linkNumber);
    graph[linkNumber].Add(nodeNumber);
}

for (int i = 0; i < graph.Length; i++)
{
    graph[i].Sort();
}

DFS(v-1);
Array.Fill(visited, false);
Console.WriteLine();
BFS(v-1);

void DFS(int start)
{
    Console.Write($"{start + 1} ");

    visited[start] = true;

    for (int i = 0; i < graph[start].Count; i++)
    {
        if (visited[graph[start][i]])
        {
            continue;
        }

        DFS(graph[start][i]);
    }
}

void BFS(int start)
{
    Queue<int> queue = new Queue<int>();
    queue.Enqueue(start);
    visited[start] = true;

    while (queue.Count > 0)
    {
        int current = queue.Dequeue();
        Console.Write($"{current+1} ");

        for (int i = 0; i < graph[current].Count; i++)
        {
            if (visited[graph[current][i]])
            {
                continue;
            }
            
            queue.Enqueue(graph[current][i]);
            visited[graph[current][i]] = true;
        }
    }
}