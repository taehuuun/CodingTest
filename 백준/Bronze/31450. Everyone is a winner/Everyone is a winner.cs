int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

if (input[0] % input[1] == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}