string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);

double m = (double)(b - a) / 400;
double win = 1 / (1 + Math.Pow(10, m));

Console.WriteLine(win);