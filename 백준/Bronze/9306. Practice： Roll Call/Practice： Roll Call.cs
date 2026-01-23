var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());

var name = string.Empty;
var first = string.Empty;

for(int i = 0; i < n; i++)
{
    name = sr.ReadLine();
    first = sr.ReadLine();

    Console.WriteLine($"Case {i+1}: {first}, {name}");
}