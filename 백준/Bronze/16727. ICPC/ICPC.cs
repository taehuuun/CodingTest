int[] score1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] score2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int pScore = score1[0] + score2[1];
int eScore = score1[1] + score2[0]; 
int homeE = score1[1];
int homeP = score2[1];

if (pScore == eScore)
{
    if (homeP == homeE)
    {
        Console.WriteLine("Penalty");
    }
    else if (homeP > homeE)
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
    if (pScore > eScore)
    {
        Console.WriteLine("Persepolis");
    }
    else
    {
        Console.WriteLine("Esteghlal");
    }
}