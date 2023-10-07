int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < n; i++)
{
    int input = int.Parse(Console.ReadLine());

    sum += input;
}

Console.WriteLine(sum);