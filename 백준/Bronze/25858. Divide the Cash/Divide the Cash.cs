int[] data = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int teamCnt = data[0];
int prize = data[1];

int[] completeProblem = new int[teamCnt];
int totalProblem = 0;

for (int i = 0; i < teamCnt; i++)
{
    int completeCnt = int.Parse(Console.ReadLine());
    totalProblem += completeCnt;
    completeProblem[i] = completeCnt;
}

int prizePerScore = prize / totalProblem;

for (int i = 0; i < teamCnt; i++)
{
    Console.WriteLine(completeProblem[i] * prizePerScore);
}