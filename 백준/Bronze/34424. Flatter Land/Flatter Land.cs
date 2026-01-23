var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());
var interval = int.Parse(sr.ReadLine());

Console.WriteLine((n - 1) * interval);