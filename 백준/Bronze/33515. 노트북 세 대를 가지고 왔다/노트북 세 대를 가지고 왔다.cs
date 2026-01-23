var sr = new StreamReader(Console.OpenStandardInput());
int[] t = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

Console.WriteLine(Math.Min(t[0], t[1]));