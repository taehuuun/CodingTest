int[] solve = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

float half = solve[1] * 0.5f;

if (solve[0] >= half)
{
    Console.WriteLine("E");
}
else
{
    Console.WriteLine("H");
}