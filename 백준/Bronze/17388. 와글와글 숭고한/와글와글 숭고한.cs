int[] scores = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int totalScore = 0;
int minScore = 999999;
int minIdx = 0;
for (int i = 0; i < scores.Length; i++)
{
    totalScore += scores[i];
    if (minScore > scores[i])
    {
        minScore = scores[i];
        minIdx = i;
    }
}

if (totalScore >= 100)
{
    Console.WriteLine("OK");
}
else
{
    if (minIdx == 0)
    {
        Console.WriteLine("Soongsil");
    }
    else if (minIdx == 1)
    {
        Console.WriteLine("Korea");
    }
    else
    {
        Console.Write("Hanyang");
    }
}