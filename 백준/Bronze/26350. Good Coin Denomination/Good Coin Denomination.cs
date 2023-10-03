int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] coinDeno = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    string result = "Good coin denominations!";
    
    for (int j = 1; j < coinDeno.Length-1; j++)
    {
        if (coinDeno[j] * 2 > coinDeno[j + 1])
        {
            result = "Bad coin denominations!";
            break;
        }
    }
    
    Console.Write($"Denominations: ");
    for (int j = 0; j < coinDeno[0]; j++)
    {
        Console.Write($"{coinDeno[j+1]} ");
    }
    Console.WriteLine();
    Console.WriteLine(result);

    if (i < n - 1)
    {
        Console.WriteLine();
    }
}