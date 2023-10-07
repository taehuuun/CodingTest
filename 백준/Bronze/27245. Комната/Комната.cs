int horizontal = int.Parse(Console.ReadLine());
int vertical = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int comLong = Math.Max(horizontal, vertical);
int comShort = Math.Min(horizontal, vertical);

Console.WriteLine($"{(comShort / height >= 2 && comLong / comShort <= 2 ? "good" : "bad")}");