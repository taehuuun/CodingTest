int n = int.Parse(Console.ReadLine());
int cnt = 0;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split('-');
    int day = int.Parse(input[1]);

    if (day <= 90)
    {
        cnt++;
    }
}

Console.WriteLine(cnt);