int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (input[1] <= 2)
{
    Console.WriteLine("NEWBIE!");
}
else if (input[1] > 2 && input[1] <= input[0])
{
    Console.WriteLine("OLDBIE!");
}
else
{
    Console.WriteLine("TLE!");
}