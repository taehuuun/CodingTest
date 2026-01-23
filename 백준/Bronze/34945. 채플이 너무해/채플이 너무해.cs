var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());

Console.WriteLine(n + 2 < 8 ? "Oh My God!" : "Success!");