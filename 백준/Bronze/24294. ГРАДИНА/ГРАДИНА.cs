int w1 = int.Parse(Console.ReadLine());
int h1 = int.Parse(Console.ReadLine());
int w2 = int.Parse(Console.ReadLine());
int h2 = int.Parse(Console.ReadLine());

Console.WriteLine((h1 + h2) * 2+ Math.Max(w1, w2) * 2 + 4);