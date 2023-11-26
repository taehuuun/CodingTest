while (true)
{
    int n = int.Parse(Console.ReadLine());
    if (n == 0) break;

    int[] teams = new int[n];
    for (int i = 0; i < n; i++)
    {
        teams[i] = int.Parse(Console.ReadLine());
    }

    Array.Reverse(teams);
    foreach (var team in teams)
    {
        Console.WriteLine(team);
    }
    Console.WriteLine("0");
}