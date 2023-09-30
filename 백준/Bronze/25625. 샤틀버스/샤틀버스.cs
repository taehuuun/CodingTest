int[] times = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int result = 0;

if (times[0] < times[1])
{
    result = times[1] - times[0];
}
else if (times[0] == times[1])
{
    result = 0;
}
else
{
    result = times[0] + times[1];
}

Console.WriteLine(result);