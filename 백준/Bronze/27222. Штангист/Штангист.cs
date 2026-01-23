var sr = new StreamReader(Console.OpenStandardInput());

var n = int.Parse(sr.ReadLine());
var days = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
var data = new int[] { };
var sum = 0;

for (int i = 0; i < n; i++)
{
    data = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

    if (days[i] == 0)
    {
        continue;
    }

    if (data[1] < data[0])
    {
        continue;
    }
    
    sum += data[1] - data[0];
}

Console.WriteLine(sum);