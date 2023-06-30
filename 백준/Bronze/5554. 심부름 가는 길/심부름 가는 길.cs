int totalSec  = 0;

for (int i = 0; i < 4; i++)
{
    totalSec += int.Parse(Console.ReadLine());
}

Console.WriteLine(totalSec/60);
Console.WriteLine(totalSec%60);