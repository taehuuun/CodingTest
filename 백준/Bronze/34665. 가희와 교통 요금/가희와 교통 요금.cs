var sr = new StreamReader(Console.OpenStandardInput());
var stationA = sr.ReadLine();
var stationB = sr.ReadLine();

Console.WriteLine(stationA == stationB ? 0 : 1550);