int n = int.Parse(Console.ReadLine());

int total = 0;

for (int i = 0; i < n; i++)
{
    total += int.Parse(Console.ReadLine());
}

total -= n-1;

Console.WriteLine(total);