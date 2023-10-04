string input = Console.ReadLine();

int aScore = 0;
int bScore = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'A')
    {
        aScore++;
    }
    else
    {
        bScore++;
    }
}

Console.WriteLine($"{aScore} : {bScore}");