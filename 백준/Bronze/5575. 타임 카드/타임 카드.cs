for (int i = 0; i < 3; i++)
{
    Console.WriteLine(ConvertTotalSecondToStringTime(ConvertStringTimeToSecond(Console.ReadLine().Split(' '))));
}

int ConvertStringTimeToSecond(string[] strTimes)
{
    int workOutTotalSec = int.Parse(strTimes[3]) * 3600 + int.Parse(strTimes[4]) * 60+ int.Parse(strTimes[5]);
    int workInTotalSec = int.Parse(strTimes[0]) * 3600 + int.Parse(strTimes[1]) * 60+ int.Parse(strTimes[2]);

    return workOutTotalSec - workInTotalSec;
}

string ConvertTotalSecondToStringTime(int totalSec)
{
    int hour = totalSec / 3600;
    totalSec -= hour * 3600;
    
    int min = totalSec / 60;
    totalSec -= min * 60;
    
    int sec = totalSec;

    return $"{hour} {min} {sec}";
}