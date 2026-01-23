var sr = new StreamReader(Console.OpenStandardInput());
var n = double.Parse(sr.ReadLine());

Console.WriteLine($"{n - 0.3f:0.####}");