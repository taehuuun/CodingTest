int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int n = input[0];
int x = input[1];
int result = -1;

for (int i = 0; i < n; ++i)
{
    int[] busTime = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    
    int s = busTime[0];
    int t = busTime[1];

    if (s + t <= x)
    {
        result = Math.Max(result, s);
    }
}

Console.WriteLine(result);