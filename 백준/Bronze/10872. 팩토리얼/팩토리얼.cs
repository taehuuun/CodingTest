int n = int.Parse(Console.ReadLine());

int answer = 1;

for (int i = 2; i <= n; i++)
{
    answer *= i;
}

Console.WriteLine(answer);