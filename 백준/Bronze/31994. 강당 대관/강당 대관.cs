PriorityQueue<string, int> pq = new();

for (int i = 0; i < 7; i++)
{
    string input = Console.ReadLine();
    string[] split = input.Split(' ');
    string name = split[0];
    int priority = int.Parse(split[1]) * -1;
    
    pq.Enqueue(name, priority);
}

Console.WriteLine(pq.Dequeue());