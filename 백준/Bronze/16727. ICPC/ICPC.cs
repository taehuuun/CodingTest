int[] score1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] score2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

if (score1[0] + score2[1] == score1[1] + score2[0])
{
    if (score2[1] == score1[1])
    {
        Console.WriteLine("Penalty");
    }
    else if (score2[1] > score1[1])
    {
        Console.WriteLine("Persepolis");
    }
    else
    {
        Console.WriteLine("Esteghlal");
    }
}
else
{
    if (score1[0] + score2[1] > score1[1] + score2[0])
    {
        Console.WriteLine("Persepolis");
    }
    else
    {
        Console.WriteLine("Esteghlal");
    }
}