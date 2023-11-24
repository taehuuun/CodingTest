int[] NUL = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

if (NUL[0] >= 1000 && NUL[1] >= 8000 || NUL[0] >= 1000 && NUL[2] >= 260)
{
    Console.WriteLine("Very Good");
}
else if (NUL[0] >= 1000)
{
    Console.WriteLine("Good");
}
else
{
    Console.WriteLine("Bad");
}