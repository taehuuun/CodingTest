int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int c4 = input[0];
int a3 = input[1];
int a4 = input[2];

double c4M2Mass = (double)c4 / 1000000;
double a3M2Mass = (double)a3 / 1000000;
double a4M2Mass = (double)a4 / 1000000;

double c4Mass = 229 * 324 * c4M2Mass * 2;
double a3Mass = 297 * 420 * a3M2Mass * 2;
double a4Mass = 210 * 297 * a4M2Mass;

Console.WriteLine($"{c4Mass + a3Mass + a4Mass:0.000000}");