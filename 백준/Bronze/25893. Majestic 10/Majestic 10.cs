int n = int.Parse(Console.ReadLine());
string[] printStr = { "zilch", "double", "double-double", "triple-double" };

for (int i = 0; i < n; i++)
{
    int cnt = 0;
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    for (int j = 0; j < 3; j++)
    {
        if (input[j] >= 10)
        {
            cnt++;
        }
    }
    
    Console.WriteLine(string.Join(' ', input));
    Console.WriteLine(printStr[cnt]);

    if (i < n-1)
    {
        Console.WriteLine();
    }
}