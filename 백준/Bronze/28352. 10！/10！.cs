int n = int.Parse(Console.ReadLine());

long total = 1;

for (int i = 1; i <= n; i++)
{
    total *= i;
}

Console.WriteLine(total/604800);