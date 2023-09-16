int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    if (input[0] <= 1 && input[1] <= 2 || input[0] <= 2 && input[1] <= 1)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}