int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

    Console.WriteLine($"Case {i+1}: {input[0] + input[1]}");
}