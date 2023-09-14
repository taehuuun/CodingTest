long area = long.Parse(Console.ReadLine());

double radius = Math.Sqrt(area / Math.PI);
double circumference = 2 * radius * Math.PI;

Console.WriteLine($"{circumference:0.#########}");