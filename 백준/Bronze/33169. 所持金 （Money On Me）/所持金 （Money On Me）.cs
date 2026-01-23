var sr = new StreamReader(Console.OpenStandardInput());
var a = int.Parse(sr.ReadLine());
var b = int.Parse(sr.ReadLine());

Console.WriteLine(a * 1000 + b * 10000);