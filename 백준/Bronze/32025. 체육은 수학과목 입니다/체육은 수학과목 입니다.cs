int h = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());

int min = Math.Min(h,m);

Console.WriteLine((float)min / 2 * 100);