Dictionary<int, int> price = new();
int result = 0;

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    price.Add(i+1, int.Parse(Console.ReadLine()));
}

int m = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    int order = int.Parse(Console.ReadLine());
    result += price[order];
}

Console.WriteLine(result);