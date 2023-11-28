int n = int.Parse(Console.ReadLine());

int[] cups = { 1, 0, 0 };

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    (cups[input[0]-1], cups[input[1]-1]) = (cups[input[1]-1], cups[input[0]-1]);
}

for (int i = 0; i < cups.Length; i++)
{
    if (cups[i] == 1)
    {
        Console.WriteLine(i+1);
        return;
    }
}