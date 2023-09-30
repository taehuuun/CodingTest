int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

Array.Sort(input);

if (input[0] + input[1] == input[2])
{
    Console.WriteLine("1");
}
else if (input[0] * input[1] == input[2])
{
    Console.WriteLine("2");
}
else
{
    Console.WriteLine("3");
}