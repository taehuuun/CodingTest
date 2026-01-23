var sr = new StreamReader(Console.OpenStandardInput());
int a = int.Parse(sr.ReadLine());
int b = int.Parse(sr.ReadLine());
int c = int.Parse(sr.ReadLine());

Console.WriteLine(a + b + c <= 21 ? "1" : "0");