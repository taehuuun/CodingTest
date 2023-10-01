int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Console.WriteLine($"{input[0]} {input[1]}");
    
    if (input[0] == 1)
    {
        Console.WriteLine(input[1]);
    }
    else
    {
        Console.WriteLine(input[1] + (input[0] - 1) * (input[1] - 2));
    }
}