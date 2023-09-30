string target = Console.ReadLine();
int loopCnt = int.Parse(Console.ReadLine());

int result = 0;

for (int i = 0; i < loopCnt; i++)
{
    string input = Console.ReadLine();

    if (target == input)
        result++;
}

Console.WriteLine(result);