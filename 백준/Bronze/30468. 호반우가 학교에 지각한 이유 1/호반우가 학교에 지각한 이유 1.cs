int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int sum = input[0] + input[1] + input[2] + input[3];
int nSum = input[4] * 4;

if ((nSum - sum) > 0)
{
    Console.WriteLine(nSum - sum);
}
else
{
    Console.WriteLine(0);
}