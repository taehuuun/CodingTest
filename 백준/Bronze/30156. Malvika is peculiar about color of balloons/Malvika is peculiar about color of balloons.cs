int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string s = Console.ReadLine();

    int aCount = 0;
    int bCount = 0;

    for (int j = 0; j < s.Length; j++)
    {
        if (s[j] == 'a')
        {
            aCount++;
        }
        else
        {
            bCount++;
        }
    }

    Console.WriteLine(Math.Min(aCount, bCount));
} 