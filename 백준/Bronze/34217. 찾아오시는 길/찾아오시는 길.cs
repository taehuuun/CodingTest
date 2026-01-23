var sr = new StreamReader(Console.OpenStandardInput());
int[] station = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);
int[] itbt = Array.ConvertAll(sr.ReadLine().Split(" "), int.Parse);

if (station[0] + itbt[0] == station[1] + itbt[1])
{
    Console.WriteLine("Either");
}
else
{
    Console.WriteLine(station[0] + itbt[0] < station[1] + itbt[1] ? "Hanyang Univ." : "Yongdap");
}