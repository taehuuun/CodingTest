int T = int.Parse(Console.ReadLine());

for (int t = 0; t < T; t++)
{
    int[] values = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (values[1] >= values[2])
    {
        Console.WriteLine("0");
        continue;
    }
    
    int targetKm = values[2] - values[1];

    if (values[0] == 1)
    {
        Console.WriteLine(targetKm);
    }
    else if (values[0] == 2)
    {
        Console.WriteLine(targetKm * 3);
    }
    else
    {
        Console.WriteLine(targetKm * 5);   
    }
}