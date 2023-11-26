int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    
    Console.WriteLine(input[0] * input[2] - input[0] + input[1]);
}