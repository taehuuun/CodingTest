int nextMonthUsing = int.Parse(Console.ReadLine());
int remainingQuota = int.Parse(Console.ReadLine());

int calValue = 60 + remainingQuota;

if (nextMonthUsing <= calValue)
{
    Console.WriteLine(nextMonthUsing * 1500);
}
else
{
    Console.WriteLine((nextMonthUsing - calValue)*3000 + (calValue *1500));
}
