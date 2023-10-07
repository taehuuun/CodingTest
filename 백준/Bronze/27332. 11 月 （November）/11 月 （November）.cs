int day = int.Parse(Console.ReadLine());
int week = int.Parse(Console.ReadLine());

if (day + week * 7 <= 30)
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}