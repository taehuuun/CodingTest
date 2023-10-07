int n = int.Parse(Console.ReadLine());
int[] plans = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int hour = 0;

for (int i = 0; i < n; i++)
{
    hour += plans[i];
}

hour += (plans.Length - 1) * 8;

Console.WriteLine($"{hour/24} {hour%24}");