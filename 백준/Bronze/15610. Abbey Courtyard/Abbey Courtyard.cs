long n = long.Parse(Console.ReadLine());

double oneLength = Math.Sqrt(n);
double totalLength = oneLength * 4;

Console.WriteLine($"{totalLength:0.0#######}");