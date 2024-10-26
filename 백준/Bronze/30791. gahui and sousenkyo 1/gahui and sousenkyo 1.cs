int[] votes = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

int count = 0;

for (int i = 1; i < votes.Length; i++)
{
    if (votes[0] - votes[i] <= 1000)
    {
        count++;
    }
}

Console.WriteLine(count);