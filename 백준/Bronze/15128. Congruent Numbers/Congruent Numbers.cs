long[] input = Array.ConvertAll(Console.ReadLine().Split(),long.Parse);

double result = input[0] * input[2] % (input[1] * input[3] * 2);

if (result == 0)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}