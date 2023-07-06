int count = 0;
for (int i = 0; i < 6; i++)
{
    if (Console.ReadLine() == "W")
    {
        count++;
    }
}

if (count == 0)
{
    Console.WriteLine("-1");
}
else if (count >= 5)
{
    Console.WriteLine("1");
}
else if (count >= 3)
{
    Console.WriteLine("2");
}
else
{
    Console.WriteLine("3");
}