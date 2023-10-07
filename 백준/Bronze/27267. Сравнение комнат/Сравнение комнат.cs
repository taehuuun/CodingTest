int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

if (input[0] * input[1] > input[2] * input[3])
{
    Console.WriteLine("M");
}
else if (input[0] * input[1] < input[2] * input[3])
{
    Console.WriteLine("P");
}
else
{
    Console.WriteLine("E");
}