int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int proCount = 0;

for (int i = 0; i < input[0]; i++)
{
    string demo = Console.ReadLine();

    int agree = 0;

    for (int j = 0; j < input[1]; j++)
    {
        if (demo[j] == 'O')
        {
            agree++;
        }
    }

    if (agree > input[1] / 2)
    {
        proCount++;
    }
}

Console.WriteLine(proCount);
