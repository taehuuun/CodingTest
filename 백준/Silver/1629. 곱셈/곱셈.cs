using System.Text.Json.Serialization;

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');
long a = long.Parse(splitInput[0]);
long b = long.Parse(splitInput[1]);
long c = long.Parse(splitInput[2]);

Console.WriteLine(Go(a, b));

long Go(long a, long b)
{
    if (b == 1)
    {
        return a % c;
    }

    long ret = Go(a, b / 2);
    ret = ret * ret % c;
    if (b % 2 != 0)
    {
        ret = ret * a % c;
    }
    return ret;
}
