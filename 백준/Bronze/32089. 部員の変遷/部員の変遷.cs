while (true)
{
    int count = int.Parse(Console.ReadLine());
    
    if (count == 0)
    {
        break;
    }
    
    int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    int max = 0;
    
    for (int i = 0; i < numbers.Length - 2; i++)
    {
        max = Math.Max(max, numbers[i] + numbers[i + 1] + numbers[i + 2]);
    }
    
    Console.WriteLine(max);
}