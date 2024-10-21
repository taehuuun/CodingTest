int n = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    int problem = int.Parse(Console.ReadLine());

    if (problem % 2 != 0)
    {
        count++;
    }
}

Console.WriteLine(count);