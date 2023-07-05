DateTime targetDate = new DateTime(2015, 2, 18);

int m = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());

DateTime inputDate = new DateTime(2015,m,d);

TimeSpan difTime = inputDate- targetDate;

if (difTime.TotalSeconds == 0)
{
    Console.WriteLine("Special");
}
else if (difTime.TotalSeconds > 0)
{
    Console.WriteLine("After");
}
else
{
    Console.WriteLine("Before");
}