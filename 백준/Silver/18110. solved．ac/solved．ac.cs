int n = int.Parse(Console.ReadLine());
int answer = 0;

int[] scoreCnts = new int[31];

int cutOff = (int)Math.Round((n * 0.15f),MidpointRounding.AwayFromZero);

int minRemoveCnt = cutOff;
int maxRemoveCnt = cutOff;


// n이 0이면 0출력후 반환
if (n == 0)
{
    Console.WriteLine(0);
    return;
}

// n개의 점수들을 입력 받고 각 점수의 최소 최대를 고른다
for (int i = 0; i < n; i++)
{
    int inputScore = int.Parse(Console.ReadLine()); 
    scoreCnts[inputScore]++;
}

for (int i = 1; i < scoreCnts.Length; i++)
{
    if (minRemoveCnt == 0)
    {
        break;
    }

    if (scoreCnts[i] > 0)
    {
        while (minRemoveCnt > 0 && scoreCnts[i] >0)
        {
            scoreCnts[i]--;
            minRemoveCnt--;
        }
    }
}

for (int i = scoreCnts.Length-1; i >=1 ; i--)
{
    if (maxRemoveCnt == 0)
    {
        break;
    }

    if (scoreCnts[i] > 0)
    {
        while (maxRemoveCnt > 0 && scoreCnts[i] >0)
        {
            scoreCnts[i]--;
            maxRemoveCnt--;
        }
    }
}

for (int i = 0; i < scoreCnts.Length; i++)
{
    if (scoreCnts[i] > 0)
    {
        answer += i * scoreCnts[i];
    }
}

n -= cutOff * 2;
answer = (int)Math.Round(answer / (double)(n), MidpointRounding.AwayFromZero);

Console.WriteLine($"{answer}");