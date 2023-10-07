int n = int.Parse(Console.ReadLine());

int dScore = 0;
int pScore = 0;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    if (input == "D")
    {
        dScore++;
    }
    else
    {
        pScore++;
    }

    if (Math.Abs(dScore - pScore) >= 2)
    {
        break;
    }
}

Console.WriteLine($"{dScore}:{pScore}");