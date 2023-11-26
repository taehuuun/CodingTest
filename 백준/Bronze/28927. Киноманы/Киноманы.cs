int max;
int mel;

int[] maxArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] melArr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

max = maxArr[0] * 3 + maxArr[1] * 20 + maxArr[2]* 120;
mel = melArr[0] * 3 + melArr[1] * 20 + melArr[2]* 120;

if (max > mel)
{
    Console.WriteLine("Max");
}
else if (max == mel)
{
    Console.WriteLine("Draw");
}
else
{
    Console.WriteLine("Mel");
}