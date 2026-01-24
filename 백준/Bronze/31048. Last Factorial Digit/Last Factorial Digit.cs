var sr = new StreamReader(Console.OpenStandardInput());
var t = int.Parse(sr.ReadLine());

var result = 0f;
var n = 0;

for (int i = 0; i < t; i++)
{
    result = 1;
    
    n = int.Parse(sr.ReadLine());
    for (int j = 1; j <= n; j++)
    {
        result *= j;
    }

    Console.WriteLine(result.ToString().Last());
}