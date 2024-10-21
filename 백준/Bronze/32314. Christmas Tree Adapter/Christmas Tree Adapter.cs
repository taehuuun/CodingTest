int treeA = int.Parse(Console.ReadLine());
int[] candidate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

if (treeA <= candidate[0] / candidate[1])
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(0);
}
