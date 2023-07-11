string score = Console.ReadLine();

int aScore = 0;
int bScore = 0;
bool deuce = false;

for (int i = 0; i < score.Length - 1; i += 2)
{
    if (score[i] == 'A')
    {
        aScore += score[i + 1] - '0';
    }
    else
    {
        bScore += score[i + 1] - '0';
    }

    if (!deuce)
    {
        if (aScore == 10 && bScore == 10)
        {
            deuce = true;
        }
        else
        {
            if (aScore >= 11 || bScore >= 11)
            {
                Console.WriteLine(aScore >= 11 ? "A" : "B");
                break;
            }
        }
    }
    else
    {
        if (Math.Abs(aScore - bScore) >= 2)
        {
            Console.WriteLine(aScore > bScore ? "A" : "B");
        }
    }
}