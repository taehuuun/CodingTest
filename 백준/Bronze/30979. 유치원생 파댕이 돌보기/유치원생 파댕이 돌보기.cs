int t = int.Parse(Console.ReadLine());

int n = int.Parse(Console.ReadLine());
int[] f = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

if (f.Sum() >= t)
{
    Console.WriteLine("Padaeng_i Happy");
}
else
{
    Console.WriteLine("Padaeng_i Cry");
}