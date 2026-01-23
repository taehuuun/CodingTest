var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());

Console.WriteLine(n <= 10000 ? "Accepted" : "Time limit exceeded");