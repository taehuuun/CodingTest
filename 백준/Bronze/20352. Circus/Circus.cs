double squareMeter = double.Parse(Console.ReadLine());

double meter = Math.Sqrt(squareMeter/Math.PI);

Console.WriteLine($"{2 * meter*Math.PI:0.##########}");