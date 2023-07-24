int[] kda = Array.ConvertAll(Console.ReadLine().Split('/'),int.Parse);

if (kda[0] + kda[2] < kda[1] || kda[1] == 0)
{
    Console.WriteLine("hasu");
}
else
{
    Console.WriteLine("gosu");
}