int[] kn = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
long[] LANs = new long[kn[0]];

for (int i = 0; i < kn[0]; i++)
{
    long input = long.Parse(Console.ReadLine());

    LANs[i] = input;
}

long end = LANs.Max();

long mid = 0;

for (long start = 1; start <= end;)
{
    mid = (start + end)/ 2;

    if (GetCutLANCount(mid) < kn[1])
    {
        end = mid - 1;
    }
    else
    {
        start = mid + 1;
    }
}

Console.WriteLine(end);

long GetCutLANCount(long dividedValue)
{
    long cutLANCnt = 0;

    for (int i = 0; i < LANs.Length; i++)
    {
        cutLANCnt += LANs[i] / dividedValue;
    }

    return cutLANCnt;
}