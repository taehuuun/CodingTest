var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());
var arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

int minIndex = 0;
int temp = int.MaxValue;

for (int i = 0; i < n; i++)
{
    if (arr[i] < temp)
    {
        temp = arr[i];
        minIndex = i;
    }
}

Console.WriteLine(minIndex);