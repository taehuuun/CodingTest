var sr = new StreamReader(Console.OpenStandardInput());
int n = int.Parse(sr.ReadLine());

var sum = 0f;

for (int i = 0; i < n; i++)
{
    var input = Array.ConvertAll(sr.ReadLine().Split(), float.Parse);
    
    sum += input[0] * input[1];
}

Console.WriteLine($"{sum:0.000}");


