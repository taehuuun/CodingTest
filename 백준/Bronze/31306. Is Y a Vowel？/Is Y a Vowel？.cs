string input = Console.ReadLine();

int vowelCnt = 0;
int yCount = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
    {
        vowelCnt++;
    }

    if (input[i] == 'y')
    {
        yCount++;
    }
}

Console.WriteLine($"{vowelCnt} {vowelCnt+yCount}");