string inputTime = Console.ReadLine();
int timeToSec = StringTimeToSec(inputTime);

timeToSec += int.Parse(Console.ReadLine());

Console.WriteLine(SecToStringTime(timeToSec));

int StringTimeToSec(string stringTime)
{
    string[] splitTime = stringTime.Split(' ');

    return (int.Parse(splitTime[0]) * 3600 + int.Parse(splitTime[1]) * 60 + int.Parse(splitTime[2]));
}

string SecToStringTime(int totalSec)
{
    int hour = totalSec / 3600;
    totalSec -= 3600 * hour;
    int min = totalSec / 60;
    totalSec -= min * 60;

    while (hour >= 24)
    {
        hour -= 24;
    }
    
    return $"{hour} {min} {totalSec}";
}