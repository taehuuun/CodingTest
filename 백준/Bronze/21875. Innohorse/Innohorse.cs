var sr = new StreamReader(Console.OpenStandardInput());
var a = sr.ReadLine();
var b = sr.ReadLine();

var n = Math.Abs(a[0] - b[0]);
var m = Math.Abs(a[1] - b[1]);

Console.WriteLine($"{Math.Min(n, m)} {Math.Max(n, m)}");