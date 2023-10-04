string input = Console.ReadLine();

int bCnt = 0;
int cCnt = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'B')
    {
        bCnt++;
    }
    else
    {
        cCnt++;
    }
}

Console.WriteLine($"{(bCnt/2) + (cCnt/2)}");