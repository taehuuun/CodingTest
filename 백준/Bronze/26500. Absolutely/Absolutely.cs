int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

    double result = Math.Abs(input[1] - input[0]);
    Console.WriteLine($"{result:F1}");
}