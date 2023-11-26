string input = Console.ReadLine();

if (!input.Contains('7') && int.Parse(input) % 7 != 0)
{
    Console.WriteLine("0");
}

else if (!input.Contains('7') && int.Parse(input) % 7 == 0)
{
    Console.WriteLine("1");
}

else if (input.Contains('7') && int.Parse(input) % 7 != 0)
{
    Console.WriteLine("2");
}
else
{
    Console.WriteLine("3");
}