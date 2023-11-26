int sleep = int.Parse(Console.ReadLine());
int wakeUp = int.Parse(Console.ReadLine());

if (sleep > wakeUp)
{
    Console.WriteLine(wakeUp + 24 - sleep);
}
else
{
    Console.WriteLine(wakeUp - sleep);
}