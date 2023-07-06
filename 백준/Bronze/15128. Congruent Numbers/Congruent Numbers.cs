string[] input = Console.ReadLine().Split();
int[] intInput = Array.ConvertAll(input, int.Parse);

double result = 0.5 * intInput[0] / intInput[1] * intInput[2] / intInput[3];

if (Math.Floor(result).Equals(result))
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}