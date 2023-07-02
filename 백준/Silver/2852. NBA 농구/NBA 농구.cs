int n = int.Parse(Console.ReadLine());

string lastTime = "00:00";
int[] winningTime = new int[2];
int[] score = new int[2];

for (int i = 0; i < n; i++)
{
    string inputData = Console.ReadLine();
    string[] splitData = inputData.Split(' ');
    
    if (score[0] > score[1])
    {
       winningTime[0] += ConvertStringTimeToSec(splitData[1]) - ConvertStringTimeToSec(lastTime);
    }
    else if (score[1] > score[0])
    {
        winningTime[1] += ConvertStringTimeToSec(splitData[1]) - ConvertStringTimeToSec(lastTime);
    }
    
    if (splitData[0] == "1")
    {
        score[0]++;
    }
    else
    {
        score[1]++;
    }

    lastTime = splitData[1];
}

if (score[0] > score[1])
{
    winningTime[0] += ConvertStringTimeToSec("48:00") - ConvertStringTimeToSec(lastTime);
}
else if(score[1]> score[0])
{
    winningTime[1] += ConvertStringTimeToSec("48:00") - ConvertStringTimeToSec(lastTime);
}

Console.WriteLine(ConvertSecToStringTime(winningTime[0]));
Console.WriteLine(ConvertSecToStringTime(winningTime[1]));


int ConvertStringTimeToSec(string time)
{
    string[] splitTime = time.Split(':');
    return int.Parse(splitTime[0]) * 60 + int.Parse(splitTime[1]);
}

string ConvertSecToStringTime(int time)
{
    return $"{time / 60:00}:{time % 60:00}";
}