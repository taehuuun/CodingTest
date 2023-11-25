int[] ab = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int count = 3;

ab[0] -= 2;
ab[1] -= 1;

int c = Math.Min(ab[0], ab[1]);

count += 2 * c;

Console.WriteLine(count);