string? input = Console.ReadLine();

int colonCnt = 0;
int underBarCnt = 0;

if (input != null)
{
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ':')
            colonCnt++;
        else if (input[i] == '_')
            underBarCnt++;
    }
}

Console.WriteLine(input.Length + colonCnt + underBarCnt * 5);