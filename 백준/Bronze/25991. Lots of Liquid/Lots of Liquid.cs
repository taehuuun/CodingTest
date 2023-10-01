int n = int.Parse(Console.ReadLine());

double sum = 0;

double[] input = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

for (int i = 0; i < input.Length; i++)
{
    sum += Math.Pow(input[i], 3);
}

sum = Math.Pow(sum,(double)1/3);

Console.WriteLine($"{sum:0.##############}");