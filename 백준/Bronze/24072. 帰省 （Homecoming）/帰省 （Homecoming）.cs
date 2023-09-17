int[] input = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

if (input[0] <= input[2] && input[2] < input[1])
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}