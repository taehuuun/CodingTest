int originTemp = int.Parse(Console.ReadLine());
int targetTemp = int.Parse(Console.ReadLine());
int heatFrozenMeatTime = int.Parse(Console.ReadLine());
int defrostMeatTime = int.Parse(Console.ReadLine());
int heatUnFrozenMeatTime = int.Parse(Console.ReadLine());

int totalSec = 0;

if (originTemp < 0)
{
    totalSec += Math.Abs(originTemp) * heatFrozenMeatTime;
    totalSec += defrostMeatTime;
    totalSec += targetTemp * heatUnFrozenMeatTime;
}
else if (originTemp == 0)
{
    totalSec += defrostMeatTime;
    totalSec += targetTemp * heatUnFrozenMeatTime;
}
else
{
    totalSec += (targetTemp - originTemp) * heatUnFrozenMeatTime;
}

Console.WriteLine(totalSec);