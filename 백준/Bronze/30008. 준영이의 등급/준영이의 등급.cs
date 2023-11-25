int[] nk = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);

int[] rank = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse); ;

int[] result = new int[nk[1]];

for (int i = 0; i < nk[1]; i++)
{
    int percentage = rank[i] * 100 / nk[0];

    int resultRank;
    
    if (percentage is >= 0 and <= 4)
    {
        resultRank = 1;
    }
    else if (percentage is > 4 and <= 11)
    {
        resultRank = 2;
    }
    else if (percentage is > 11 and <= 23)
    {
        resultRank = 3;
    }
    else if (percentage is > 23 and <= 40)
    {
        resultRank = 4;
    }
    else if (percentage is > 40 and <= 60)
    {
        resultRank = 5;
    }
    else if (percentage is > 60 and <= 77)
    {
        resultRank = 6;
    }
    else if (percentage is > 77 and <= 89)
    {
        resultRank = 7;
    }
    else if (percentage is > 89 and <= 96)
    {
        resultRank = 8;
    }
    else
    {
        resultRank = 9;
    }

    result[i] = resultRank;
}

Console.WriteLine(string.Join(" ",result));