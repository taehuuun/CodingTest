string inputMingukScore = Console.ReadLine();
string inputManseScore = Console.ReadLine();

string[] splitInputMingukScore = inputMingukScore.Split(' ');
string[] splitInputManseScore = inputManseScore.Split(' ');

int totalMingukScore = 0;
int totalManseScore = 0;

for (int i = 0; i < 4; i++)
{
    totalMingukScore += int.Parse(splitInputMingukScore[i]);
    totalManseScore += int.Parse(splitInputManseScore[i]);
}

Console.WriteLine(totalMingukScore >= totalManseScore ? totalMingukScore : totalManseScore);
