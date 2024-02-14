int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string inputYear = Console.ReadLine();
    int currentYear = int.Parse(inputYear);

    if ((currentYear + 1) % int.Parse(inputYear.Substring(2)) == 0)
    {
        Console.WriteLine("Good");
    }
    else
    {
        Console.WriteLine("Bye");
    }
}