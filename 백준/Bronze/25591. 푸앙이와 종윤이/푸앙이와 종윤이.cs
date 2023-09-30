int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int a = 100 - input[0];
int b = 100 - input[1];
int c = 100 - (a+b);
int d = a * b;
int q = d / 100;
int r = d % 100;

Console.WriteLine($"{a} {b} {c} {d} {q} {r}");
Console.WriteLine($"{c + q} {r}");