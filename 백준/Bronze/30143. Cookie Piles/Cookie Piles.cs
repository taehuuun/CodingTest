int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int[] nad = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

    int totalCookie = nad[1];
    int lastCookie = nad[1];

    for (int j = 0; j < nad[0] - 1; j++)
    {
        lastCookie += nad[2];
        totalCookie += lastCookie;
    }
    
    Console.WriteLine(totalCookie);
}