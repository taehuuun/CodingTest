string[] startTime = Console.ReadLine().Replace(" ","").Split(':');
string[] endTime = Console.ReadLine().Replace(" ","").Split(':');

int startTimeTotalSec = int.Parse(startTime[0]) * 3600 + int.Parse(startTime[1]) * 60 + int.Parse(startTime[2]);
int endTimeTotalSec = int.Parse(endTime[0]) * 3600 + int.Parse(endTime[1]) * 60 + int.Parse(endTime[2]);

if (endTimeTotalSec < startTimeTotalSec)
{
    endTimeTotalSec += 86400;
}
Console.WriteLine(endTimeTotalSec - startTimeTotalSec);