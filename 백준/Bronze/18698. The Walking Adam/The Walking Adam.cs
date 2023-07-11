int T = int.Parse(Console.ReadLine());

for (int t = 0; t < T; t++)
{
    string input = Console.ReadLine();

    int curCnt = 0;
    int maxValue = 0;

    foreach (char curChar in input)
    {
        if (curChar == 'U')
        {
            curCnt++;

            maxValue = Math.Max(maxValue, curCnt);
        }
        else
        {
            break;
        }
    }
    Console.WriteLine(maxValue);
}